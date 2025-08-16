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
public static partial class RangeBase_MarkupExtensions
{
//================= Properties ======================//
 // Minimum

/*ValueSetterGenerator*/
public static T Minimum<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._set(() => control.Minimum = value!);

/*BindFromFuncSetterGenerator*/
public static T Minimum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(func, Avalonia.Controls.Primitives.RangeBase.MinimumProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Minimum<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(signal, Avalonia.Controls.Primitives.RangeBase.MinimumProperty!, onChanged);


 // Maximum

/*ValueSetterGenerator*/
public static T Maximum<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._set(() => control.Maximum = value!);

/*BindFromFuncSetterGenerator*/
public static T Maximum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(func, Avalonia.Controls.Primitives.RangeBase.MaximumProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Maximum<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(signal, Avalonia.Controls.Primitives.RangeBase.MaximumProperty!, onChanged);


 // Value

/*ValueSetterGenerator*/
public static T Value<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._set(() => control.Value = value!);

/*BindFromFuncSetterGenerator*/
public static T Value<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(func, Avalonia.Controls.Primitives.RangeBase.ValueProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Value<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(signal, Avalonia.Controls.Primitives.RangeBase.ValueProperty!, onChanged);


 // SmallChange

/*ValueSetterGenerator*/
public static T SmallChange<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._set(() => control.SmallChange = value!);

/*BindFromFuncSetterGenerator*/
public static T SmallChange<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(func, Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SmallChange<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(signal, Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty!, onChanged);


 // LargeChange

/*ValueSetterGenerator*/
public static T LargeChange<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._set(() => control.LargeChange = value!);

/*BindFromFuncSetterGenerator*/
public static T LargeChange<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(func, Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T LargeChange<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(signal, Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty!, onChanged);



//================= Events ======================//
 // ValueChanged

/*ActionToEventGenerator*/
public static T OnValueChanged<T>(this T control, Action<Avalonia.Controls.Primitives.RangeBaseValueChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.RangeBase 
{
  control.AddHandler(Avalonia.Controls.Primitives.RangeBase.ValueChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Primitives.RangeBase.ValueChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Minimum

/*ValueStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.MinimumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.MinimumProperty, binding);


 // Maximum

/*ValueStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.MaximumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.MaximumProperty, binding);


 // Value

/*ValueStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.ValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.ValueProperty, binding);


 // SmallChange

/*ValueStyleSetterGenerator*/
public static Style<T> SmallChange<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SmallChange<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty, binding);


 // LargeChange

/*ValueStyleSetterGenerator*/
public static Style<T> LargeChange<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LargeChange<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty, binding);



}
