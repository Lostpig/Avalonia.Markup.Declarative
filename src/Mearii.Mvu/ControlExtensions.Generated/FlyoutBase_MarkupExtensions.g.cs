#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Mearii.Mvu;
[global::System.CodeDom.Compiler.GeneratedCode("Mearii.AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class FlyoutBase_MarkupExtensions
{
//================= Attached Properties ======================//
 // AttachedFlyout

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T FlyoutBase_AttachedFlyout<T>(this T control, Func<Avalonia.Controls.Primitives.FlyoutBase> func, Action<Avalonia.Controls.Primitives.FlyoutBase>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T FlyoutBase_AttachedFlyout<T>(this T control, ISignal<Avalonia.Controls.Primitives.FlyoutBase> signal, Action<Avalonia.Controls.Primitives.FlyoutBase>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty!, onChanged);



//================= Events ======================//
 // Opened

/*ActionToEventGenerator*/
public static T OnOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.FlyoutBase  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Opened += h);


 // Closed

/*ActionToEventGenerator*/
public static T OnClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.FlyoutBase  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Closed += h);



}
