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
public static partial class RepeatButton_MarkupExtensions
{
//================= Properties ======================//
 // Interval

/*ValueSetterGenerator*/
public static T Interval<T>(this T control, System.Int32 value) where T : Avalonia.Controls.RepeatButton 
=> control._set(() => control.Interval = value!);

/*BindFromFuncSetterGenerator*/
public static T Interval<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.RepeatButton 
   => control._set(func, Avalonia.Controls.RepeatButton.IntervalProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Interval<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.RepeatButton 
   => control._set(signal, Avalonia.Controls.RepeatButton.IntervalProperty!, onChanged);


 // Delay

/*ValueSetterGenerator*/
public static T Delay<T>(this T control, System.Int32 value) where T : Avalonia.Controls.RepeatButton 
=> control._set(() => control.Delay = value!);

/*BindFromFuncSetterGenerator*/
public static T Delay<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.RepeatButton 
   => control._set(func, Avalonia.Controls.RepeatButton.DelayProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Delay<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.RepeatButton 
   => control._set(signal, Avalonia.Controls.RepeatButton.DelayProperty!, onChanged);



//================= Styles ======================//
 // Interval

/*ValueStyleSetterGenerator*/
public static Style<T> Interval<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.RepeatButton 
=> style._addSetter(Avalonia.Controls.RepeatButton.IntervalProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Interval<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.RepeatButton 
=> style._addSetter(Avalonia.Controls.RepeatButton.IntervalProperty, binding);


 // Delay

/*ValueStyleSetterGenerator*/
public static Style<T> Delay<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.RepeatButton 
=> style._addSetter(Avalonia.Controls.RepeatButton.DelayProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Delay<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.RepeatButton 
=> style._addSetter(Avalonia.Controls.RepeatButton.DelayProperty, binding);



}
