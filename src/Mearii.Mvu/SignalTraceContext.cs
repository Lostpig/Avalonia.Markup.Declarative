using System;
using System.Collections.Generic;

namespace Mearii.Mvu;

internal class SignalTraceContext
{
    private static readonly Stack<SignalTraceContext> _stack = new();
    internal static SignalTraceContext? Current => _stack.Count > 0 ? _stack.Peek() : null;
    internal static bool IsTracing => Current is not null;
    internal static IList<Signal> TraceDependencies<T>(Func<T> getterFunc, out T result)
    {
        var context = new SignalTraceContext();

        lock (_stack)
        {
            _stack.Push(context);
            result = getterFunc();
            _stack.Pop();
        }

        return context._dependencies;
    }
    internal static IList<Signal> TraceDependencies(Action action)
    {
        var context = new SignalTraceContext();

        lock (_stack)
        {
            _stack.Push(context);
            action();
            _stack.Pop();
        }

        return context._dependencies;
    }

    private readonly List<Signal> _dependencies = [];
    private SignalTraceContext()
    {

    }
    internal void AddDependency(Signal signal)
    {
        if (!_dependencies.Contains(signal))
            _dependencies.Add(signal);
    }
}
