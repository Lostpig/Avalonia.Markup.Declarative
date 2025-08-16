using Avalonia;
using System;
using System.Collections.Generic;


namespace Mearii.Mvu;

internal class ReactiveState<TControl, TValue> : ReactiveState, IObserver<TValue> where TControl : AvaloniaObject
{
    protected readonly IObservable<TValue>? _obs;
    protected readonly TControl _control;
    protected readonly AvaloniaProperty<TValue>? _avaloniaProperty;
    protected readonly Action<TControl, TValue>? _setter;
    protected readonly Action<TValue>? _changeHandler;

    public Func<TValue> GetterFunc { get; }
    public TValue Value => GetterFunc();
    private TValue? _cacheValue;

    internal ReactiveState(TControl control, Func<TValue> getter, Action<TControl, TValue> setter, Action<TValue>? changeHandler)
        : this(control, getter, setter, null, changeHandler) { }
    internal ReactiveState(TControl control, Func<TValue> getter, AvaloniaProperty<TValue> avaloniaProperty, Action<TValue>? changeHandler)
        : this(control, getter, null, avaloniaProperty, changeHandler) { }
    internal ReactiveState(TControl control, ISignal<TValue> signal, AvaloniaProperty<TValue> avaloniaProperty, Action<TValue>? changeHandler)
        : this(control, () => signal.Value, null, avaloniaProperty, changeHandler) { }
    internal ReactiveState(TControl control, ISignal<TValue> signal, Action<TControl, TValue> setter, Action<TValue>? changeHandler)
    : this(control, () => signal.Value, setter, null, changeHandler) { }

    private ReactiveState(
        TControl control, 
        Func<TValue> getter,
        Action<TControl, TValue>? setter,
        AvaloniaProperty<TValue>? avaloniaProperty,
        Action<TValue>? changeHandler)
    {
        _control = control;
        GetterFunc = getter;
        _setter = setter;
        _avaloniaProperty = avaloniaProperty;
        _changeHandler = changeHandler;

        var dependencies = SignalTraceContext.TraceDependencies(GetterFunc, out var initialValue);
        InitializeDependencies(dependencies);
        SetValue(initialValue);

        if (_avaloniaProperty != null)
        {
            if (_changeHandler != null)
            {
                _obs = _control.GetObservable(_avaloniaProperty);
                _obs.Subscribe(this);
            }
        }
    }

    protected void SetValue(TValue newValue)
    {
        if (_avaloniaProperty != null)
        {
            if (!Equals(_control.GetValue(_avaloniaProperty), newValue))
            {
                _control.SetValue(_avaloniaProperty, newValue);
                _changeHandler?.Invoke(newValue);
            }
        }
        else if (_setter != null && !Equals(_cacheValue, newValue))
        {
            _cacheValue = newValue;
            _setter.Invoke(_control, newValue);
            _changeHandler?.Invoke(newValue);
        }
    }
    protected override void UpdateValue()
    {
        TValue newValue = GetterFunc();
        SetValue(newValue);
    }

    #region implement IObserver
    public void OnNext(TValue value)
    {
        if (Value == null && value == null)
            return;

        if (value != null && value.Equals(Value))
            return;

        _changeHandler?.Invoke(value);
    }

    public void OnCompleted()
    {
        throw new NotImplementedException();
    }

    public void OnError(Exception error)
    {
        throw new NotImplementedException();
    }
    #endregion
}

internal abstract class ReactiveState : IDisposable
{
    protected readonly List<IDisposable> _subscriptions = [];
    protected void InitializeDependencies(ICollection<Signal> dependencies)
    {
        foreach (var signal in dependencies)
        {
            _subscriptions.Add(signal.Subscribe(UpdateValue));
        }
    }
    protected abstract void UpdateValue();
    public virtual void Dispose()
    {
        foreach (var subscription in _subscriptions)
        {
            subscription.Dispose();
        }
        _subscriptions.Clear();
    }
}