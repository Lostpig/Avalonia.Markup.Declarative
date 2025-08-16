using Avalonia.Controls;
using System;

namespace Mearii.Mvu;

public class FuncComponent(Func<Control> build) : MvuComponent
{
    protected override object Build() => build.Invoke();
}
