using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Mearii.Mvu;

internal class ViewPropertyComputedState<TValue> : ViewPropertyComputedState, IObservable<TValue>, INotifyPropertyChanged
{
    public Func<TValue> GetterFunc { get; }
    public TValue Value => GetterFunc();

    public ViewPropertyComputedState(string? expressionString, Func<TValue> getterFunc)
    {
        GetterFunc = getterFunc;
        ExpressionString = expressionString;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public override void OnPropertyChanged()
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Value"));
        NotifyObservers(Value);
    }

    private readonly List<IObserver<TValue>> _observers = [];

    public IDisposable Subscribe(IObserver<TValue> observer)
    {
        if (!_observers.Contains(observer))
            _observers.Add(observer);
        return new Unsubscriber(_observers, observer);
    }

    public void NotifyObservers(TValue value)
    {
        foreach (var observer in _observers)
            observer.OnNext(value);
    }

    private class Unsubscriber(ICollection<IObserver<TValue>> observers, IObserver<TValue> observer) : IDisposable
    {
        public void Dispose()
        {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }
    }
}

internal abstract class ViewPropertyComputedState
{
    internal string? ExpressionString { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is ViewPropertyComputedState state &&
               ExpressionString == state.ExpressionString;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(ExpressionString);
    }

    public abstract void OnPropertyChanged();
}