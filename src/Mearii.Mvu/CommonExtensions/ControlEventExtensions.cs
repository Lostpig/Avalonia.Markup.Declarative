using Avalonia;
using System;

namespace Mearii.Mvu;

public static class ControlEventExtensions
{
    public static TControl _setEvent<TControl, THandler>(this TControl control, THandler handler, Action<THandler> subscribe)
        where TControl : AvaloniaObject
    {
        subscribe?.Invoke(handler);
        return control;
    }
}
