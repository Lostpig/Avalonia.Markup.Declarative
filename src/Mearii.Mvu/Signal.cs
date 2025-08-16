using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mearii.Mvu;

public class Signal<T> : Signal, ISignal<T>
{
    protected T _value;
    public T Value => Get();

    public Signal(T initValue)
    {
        _value = initValue;
    }
    public T Get()
    {
        if (SignalTraceContext.IsTracing)
        {
            SignalTraceContext.Current?.AddDependency(this);
        }
        return _value;
    }
    public T UnTrackedValue()
    {
        return _value;
    }
    public void Set(T value)
    {
        if (value == null && _value == null) return;
        if (_value is not null && _value.Equals(value)) return;

        _value = value;
        NotifyChanged();
    }
    public void Update(Func<T, T> updateFunc)
    {
        var newValue = updateFunc(_value);
        Set(newValue);
    }
}

public class CollectionSignal<T> : Signal, ISignal<ICollection<T>>
{
    protected ICollection<T> _collection;
    public ICollection<T> Value => Get();
    public CollectionSignal(ICollection<T> initValue)
    {
        _collection = initValue;
    }
    public ICollection<T> Get()
    {
        if (SignalTraceContext.IsTracing)
        {
            SignalTraceContext.Current?.AddDependency(this);
        }
        return [.. _collection];
    }
    public ICollection<T> UnTrackedValue()
    {
        return [.. _collection]; ;
    }

    public void Set(ICollection<T> collection)
    {
        if (_collection != collection)
        {
            _collection = collection;
            NotifyChanged();
        }
    }
    public void Add(T item)
    {
        _collection.Add(item);
        NotifyChanged();
    }
    public void Remove(T item)
    {
        if (_collection.Remove(item))
        {
            NotifyChanged();
        }
    }
}

public class ComputedSignal<T> : Signal, ISignal<T>
{
    protected readonly List<IDisposable> _subscriptions = [];
    protected Func<T> _computeFunc;
    protected T _cache;
    protected bool _isChanging = false;

    public T Value => Get();
    public T Get()
    {
        if (SignalTraceContext.IsTracing)
        {
            SignalTraceContext.Current?.AddDependency(this);
        }

        return _computeFunc();
    }
    public T UnTrackedValue()
    {
        return _computeFunc();
    }

    public ComputedSignal(Func<T> computeFunc)
    {
        var dependencies = SignalTraceContext.TraceDependencies(computeFunc, out var initValue);
        IniializeDependencies(dependencies);

        _computeFunc = computeFunc;
        _cache = initValue;
    }
    protected void IniializeDependencies(ICollection<Signal> dependencies)
    {
        foreach (var signal in dependencies)
        {
            _subscriptions.Add(signal.Subscribe(UpdateValue));
        }
    }
    protected void UpdateValue()
    {
        var newValue = _computeFunc();
        if (!Equals(_cache, newValue))
        {
            _cache = newValue;
            NotifyChanged();
        }
    }
    protected override void NotifyChanged()
    {
        if (_isChanging)
        {
            Debug.WriteLine("Signal Cyclic Dependencies.");
            return;
        }

        _isChanging = true;
        try
        {
            base.NotifyChanged();
        }
        finally
        {
            _isChanging = false;
        }
    }
}

public class Signal : IValueChanged
{
    protected readonly List<Action> _handlers = [];

    protected virtual void NotifyChanged()
    {
        foreach (var handler in _handlers)
        {
            handler();
        }
    }

    public IDisposable Subscribe(Action handler)
    {
        if (!_handlers.Contains(handler))
            _handlers.Add(handler);
        return new Unsubscriber(_handlers, handler);
    }
    protected class Unsubscriber(ICollection<Action> handlers, Action handler) : IDisposable
    {
        public void Dispose()
        {
            handlers.Remove(handler);
        }
    }
}

public class Effect : IDisposable
{
    protected bool _running = false;
    protected readonly List<IDisposable> _subscriptions = [];
    protected Action _effectAction;
    public event Action? CleanUp;
    public Effect(Action effectAction)
    {
        _effectAction = effectAction;
        Excute(Initialize);
    }
    protected void Initialize()
    {
        var dependencies = SignalTraceContext.TraceDependencies(_effectAction);
        IniializeDependencies(dependencies);
    }
    protected void ExcuteEffect()
    {
        Excute(() =>
        {
            CleanUp?.Invoke();
            _effectAction();
        });
    }
    protected async void Excute(Action action)
    {
        if (_running) return;

        try
        {
            _running = true;
            await Task.Run(action);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Effect execution failed: {ex.Message}");
        }
        finally
        {
            _running = false;
        }
    }
    protected void IniializeDependencies(ICollection<Signal> dependencies)
    {
        foreach (var signal in dependencies)
        {
            _subscriptions.Add(signal.Subscribe(ExcuteEffect));
        }
    }

    public void Dispose()
    {
        foreach (var subscription in _subscriptions)
        {
            subscription.Dispose();
        }
        CleanUp?.Invoke();
        _running = false;
    }
}

public interface IValueChanged
{
    IDisposable Subscribe(Action handler);
}
public interface ISignal<T>
{
    T Value { get; }
    T Get();
    T UnTrackedValue();
}