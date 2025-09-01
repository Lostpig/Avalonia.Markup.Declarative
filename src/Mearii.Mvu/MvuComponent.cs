using Avalonia;
using Avalonia.Controls;
using Avalonia.Threading;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;

namespace Mearii.Mvu;

public abstract class MvuComponent<TViewModel> : MvuComponent
{
    protected TViewModel? _viewModel;
    public virtual TViewModel? ViewModel
    {
        get => _viewModel;
        set => _viewModel = value;
    }

    protected MvuComponent(TViewModel viewModel)
        : base(true)
    {
        ViewModel = viewModel;
        OnCreated();
        Initialize();
    }

    protected abstract object Build(TViewModel vm);
    protected override object Build() => Build(ViewModel);
}

public abstract class MvuComponent : Decorator, IReloadable, IDeclarativeComponent
{
    internal readonly List<ViewSignalComputedState> _signalStates = [];
    internal readonly List<ViewPropertyComputedState> _propertyStates = [];
    private INameScope? _nameScope;
    /// <summary>
    /// Current NameScope of this view
    /// </summary>
    protected INameScope Scope => _nameScope ??= new NameScope();

    /// <summary>
    /// Creates a new instance of the control using the component factory. Injects services into the control if needed.
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static TControl New<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TControl>() where TControl : Control
    {
        if (AppBuilderExtensions.ComponentControlFactory == null)
            throw new InvalidOperationException("Please set Component Factory by calling UseComponentControlFactory on AppBuilder");

        var control = AppBuilderExtensions.ComponentControlFactory.CreateControlInstance<TControl>();
        return control;
    }

    public event Action? ViewInitialized;
    protected abstract object Build();
    protected virtual StyleGroup? BuildStyles() => null;

    protected MvuComponent(bool deferredLoading)
    {
        if (!deferredLoading)
        {
            OnCreated();
            Initialize();
        }
    }
    protected MvuComponent(): this(false)
    {

    }

    /// <summary>
    /// Called from constructor, right before initialization and building UI
    /// Override this method when you want to run some stuff before creation of children controls
    /// </summary>
    protected virtual void OnCreated()
    {
        InjectServices();
        InitializePropertyStates();
    }
    protected virtual void OnAfterInitialized() { }

    protected void Initialize()
    {
        try
        {
            NameScope.SetNameScope(this, Scope);

            using (var context = new ComponentBuildContext(this))
            {
                context.SetState(ComponentBuildContextState.StyleBuilding);
                if (BuildStyles() is { } styleGroup)
                {
                    context.SetState(ComponentBuildContextState.StyleSelectorUpdating);
                    var viewStyles = StyleBuilder.StylesToRange(styleGroup).ToImmutableList();
                    Styles.AddRange(viewStyles);
                }

                context.SetState(ComponentBuildContextState.ViewBuilding);
                var content = Build();
                Child = content as Control;

                context.SetState(ComponentBuildContextState.None);
            }

            ViewInitialized?.Invoke();
            OnAfterInitialized();
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            Debug.WriteLine(ex.StackTrace);
            throw new ComponentBuildingException($"Build error in {GetType().Name} : {ex.Message}", ex);
        }
    }
    internal void AddState(ViewSignalComputedState state)
    {
        ArgumentNullException.ThrowIfNull(state);
        if (!_signalStates.Contains(state))
            _signalStates.Add(state);
    }
    internal void AddComputedState(ViewPropertyComputedState state)
    {
        ArgumentNullException.ThrowIfNull(state);
        if (!_propertyStates.Contains(state))
            _propertyStates.Add(state);
    }

    [RequiresUnreferencedCode("Method InjectServices is using reflection to iterate through Type hierarchy. That's can not be analyzed statically.")]
    private void InjectServices()
    {
        var componentType = GetType();
        var types = new List<Type>();

        // Walk up the inheritance chain, but stop at object
        for (var type = componentType; type != null && type != typeof(object); type = type.BaseType)
        {
            types.Add(type);
        }

        // Go from base to derived so base properties are injected first
        types.Reverse();

        foreach (var type in types)
        {
            var injectProps = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                .Where(x => x.GetCustomAttribute<InjectAttribute>() != null)
                .ToArray();

            foreach (var propertyInfo in injectProps)
            {
                var service = GetServiceFromProvider(propertyInfo.PropertyType);

                if (propertyInfo.CanWrite)
                {
                    propertyInfo.SetValue(this, service);
                }
                else
                {
                    if (type.GetField($"<{propertyInfo.Name}>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance) is { } backingField)
                        backingField.SetValue(this, service);
                    else
                        throw new InvalidOperationException($"Can't inject {service?.GetType()} service. Ensure that target property: {type.Name}.{propertyInfo.Name} has public setter or it's an auto-property");
                }
            }
        }
    }

    private void InitializePropertyStates()
    {
        PropertyChanged += OnBasePropertyChanged;
    }
    private void OnBasePropertyChanged(object? sender, AvaloniaPropertyChangedEventArgs e)
    {
        if (Dispatcher.UIThread.CheckAccess())
        {
            // If on UI thread, proceed directly
            PerformStateUpdate();
        }
        else
        {
            // If not on UI thread, dispatch to UI thread
            Dispatcher.UIThread.Post(PerformStateUpdate, DispatcherPriority.Normal);
        }
    }
    private bool _isUpdatingState = false;
    private void PerformStateUpdate()
    {
        if (_isUpdatingState)
            return;
        _isUpdatingState = true;
        try
        {
            foreach (var computedState in _propertyStates)
                computedState.OnPropertyChanged();
        }
        finally
        {
            _isUpdatingState = false;
        }
    }

    private static object? GetServiceFromProvider(Type serviceType)
    {
        if (AppBuilderExtensions.ServiceProvider == null)
            throw new InvalidOperationException("Please set Service Provider by calling UseServiceProvider on AppBuilder");

        return AppBuilderExtensions.ServiceProvider.GetService(serviceType);
    }

    #region Hot reload stuff
    public void Reload()
    {
        Dispatcher.UIThread.InvokeAsync(() =>
        {
            foreach (var state in _signalStates)
            {
                state.Dispose();
            }
            _signalStates.Clear();

            OnBeforeReload();
            Child = null;
            VisualChildren.Clear();
            _nameScope = null;

            var oldDataContext = DataContext;
            DataContext = null; // guarantee that OnDataContextChanged is called

            OnCreated();
            Initialize();
            DataContext = oldDataContext; // set DataContext back

            InvalidateArrange();
            InvalidateMeasure();
            InvalidateVisual();
        });
    }

    protected virtual void OnBeforeReload()
    {
    }

    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnAttachedToVisualTree(e);
        HotReloadManager.RegisterInstance(this);
    }

    protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnDetachedFromVisualTree(e);
        HotReloadManager.UnregisterInstance(this);
    }
    #endregion
}
