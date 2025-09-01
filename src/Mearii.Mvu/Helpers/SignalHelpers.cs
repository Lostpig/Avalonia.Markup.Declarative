using Avalonia;
using System;
using System.Collections.Generic;

namespace Mearii.Mvu.Helpers;

public static class SignalHelpers
{
    public static Signal<TValue> ControlPropertySignal<TContorl, TValue>(
        TContorl control,
        AvaloniaProperty<TValue> property) where TContorl : AvaloniaObject
    {
        var value = control.GetValue(property);
        if (value is not TValue tv)
            throw new ArgumentException($"Property {property.Name} on {typeof(TContorl).Name} must be of type {typeof(TValue).Name}");

        var signal = new Signal<TValue>(tv);
        var observer = new SignalPropertySync<TValue>(signal);
        var observable = control.GetObservable(property);
        observable.Subscribe(observer);

        return signal;
    }

    class SignalPropertySync<T> : IObserver<T>, IObservable<T>, IDisposable
    {
        private readonly Signal<T> _signal;
        private IDisposable? _subscription;
        private readonly List<IObserver<T>> _observers = [];

        public SignalPropertySync(Signal<T> signal)
        {
            _signal = signal;
            _signal.Subscribe(UpdateHandler);
        }


        public void OnCompleted() { }
        public void OnError(Exception error) { }
        public void OnNext(T value)
        {
            _signal.Set(value);
        }

        private void UpdateHandler()
        {
            foreach(var observer in _observers)
            {
                observer.OnNext(_signal.Value);
            }
        }
        public IDisposable Subscribe(IObserver<T> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
            return new Unsubscriber(_observers, observer);
        }
        public void Dispose()
        {
            _subscription?.Dispose();
        }

        private class Unsubscriber(ICollection<IObserver<T>> observers, IObserver<T> observer) : IDisposable
        {
            public void Dispose()
            {
                if (observers.Contains(observer))
                    observers.Remove(observer);
            }
        }
    }
}
