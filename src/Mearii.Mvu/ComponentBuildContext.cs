using System;
using System.Collections.Generic;

namespace Mearii.Mvu;

internal enum ComponentBuildContextState
{
    None,
    StyleBuilding,
    StyleSelectorUpdating,
    ViewBuilding
}

internal class ComponentBuildContext : IDisposable
{
    private static readonly Stack<ComponentBuildContext> ComponentStack = new();
    private static ComponentBuildContext? _currentContext;

    internal static MvuComponent? CurrentComponent => _currentContext?._component;
    internal static ComponentBuildContextState? CurrentState => _currentContext?._state;

    private readonly MvuComponent _component;
    private ComponentBuildContextState _state;

    public ComponentBuildContext(MvuComponent component)
    {
        _component = component;

        if (_currentContext != null)
            ComponentStack.Push(_currentContext);

        _currentContext = this;
    }

    internal void SetState(ComponentBuildContextState state)
    {
        _state = state;
    }

    public void Dispose()
    {
        _currentContext = ComponentStack.Count > 0 ? ComponentStack.Pop() : null;
    }
}

public class ComponentBuildingException(string message, Exception innerException) : Exception(message, innerException);
