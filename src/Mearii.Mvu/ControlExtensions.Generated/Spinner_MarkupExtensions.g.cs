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
public static partial class Spinner_MarkupExtensions
{
//================= Properties ======================//
 // ValidSpinDirection

/*ValueSetterGenerator*/
public static T ValidSpinDirection<T>(this T control, Avalonia.Controls.ValidSpinDirections value) where T : Avalonia.Controls.Spinner 
=> control._set(() => control.ValidSpinDirection = value!);

/*BindFromFuncSetterGenerator*/
public static T ValidSpinDirection<T>(this T control, Func<Avalonia.Controls.ValidSpinDirections> func, Action<Avalonia.Controls.ValidSpinDirections>? onChanged = null) where T : Avalonia.Controls.Spinner 
   => control._set(func, Avalonia.Controls.Spinner.ValidSpinDirectionProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ValidSpinDirection<T>(this T control, ISignal<Avalonia.Controls.ValidSpinDirections> signal, Action<Avalonia.Controls.ValidSpinDirections>? onChanged = null) where T : Avalonia.Controls.Spinner 
   => control._set(signal, Avalonia.Controls.Spinner.ValidSpinDirectionProperty!, onChanged);



//================= Events ======================//
 // Spin

/*ActionToEventGenerator*/
public static T OnSpin<T>(this T control, Action<Avalonia.Controls.SpinEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Spinner 
{
  control.AddHandler(Avalonia.Controls.Spinner.SpinEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Spinner.SpinEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // ValidSpinDirection

/*ValueStyleSetterGenerator*/
public static Style<T> ValidSpinDirection<T>(this Style<T> style, Avalonia.Controls.ValidSpinDirections value) where T : Avalonia.Controls.Spinner 
=> style._addSetter(Avalonia.Controls.Spinner.ValidSpinDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ValidSpinDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Spinner 
=> style._addSetter(Avalonia.Controls.Spinner.ValidSpinDirectionProperty, binding);



}
