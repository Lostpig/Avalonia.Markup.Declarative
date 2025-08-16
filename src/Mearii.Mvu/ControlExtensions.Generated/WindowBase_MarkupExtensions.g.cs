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
public static partial class WindowBase_MarkupExtensions
{
//================= Properties ======================//
 // Topmost

/*ValueSetterGenerator*/
public static T Topmost<T>(this T control, System.Boolean value) where T : Avalonia.Controls.WindowBase 
=> control._set(() => control.Topmost = value!);

/*BindFromFuncSetterGenerator*/
public static T Topmost<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.WindowBase 
   => control._set(func, Avalonia.Controls.WindowBase.TopmostProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Topmost<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.WindowBase 
   => control._set(signal, Avalonia.Controls.WindowBase.TopmostProperty!, onChanged);



//================= Events ======================//
 // Activated

/*ActionToEventGenerator*/
public static T OnActivated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.WindowBase  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Activated += h);


 // Deactivated

/*ActionToEventGenerator*/
public static T OnDeactivated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.WindowBase  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Deactivated += h);


 // PositionChanged

/*ActionToEventGenerator*/
public static T OnPositionChanged<T>(this T control, Action<Avalonia.Controls.PixelPointEventArgs> action) where T : Avalonia.Controls.WindowBase  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.PixelPointEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PositionChanged += h);


 // Resized

/*ActionToEventGenerator*/
public static T OnResized<T>(this T control, Action<Avalonia.Controls.WindowResizedEventArgs> action) where T : Avalonia.Controls.WindowBase  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.WindowResizedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Resized += h);



//================= Styles ======================//
 // Topmost

/*ValueStyleSetterGenerator*/
public static Style<T> Topmost<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.WindowBase 
=> style._addSetter(Avalonia.Controls.WindowBase.TopmostProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Topmost<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WindowBase 
=> style._addSetter(Avalonia.Controls.WindowBase.TopmostProperty, binding);



}
