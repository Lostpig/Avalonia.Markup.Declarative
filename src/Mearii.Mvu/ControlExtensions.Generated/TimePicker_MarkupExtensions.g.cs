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
public static partial class TimePicker_MarkupExtensions
{
//================= Properties ======================//
 // MinuteIncrement

/*ValueSetterGenerator*/
public static T MinuteIncrement<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TimePicker 
=> control._set(() => control.MinuteIncrement = value!);

/*BindFromFuncSetterGenerator*/
public static T MinuteIncrement<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TimePicker 
   => control._set(func, Avalonia.Controls.TimePicker.MinuteIncrementProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MinuteIncrement<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TimePicker 
   => control._set(signal, Avalonia.Controls.TimePicker.MinuteIncrementProperty!, onChanged);


 // SecondIncrement

/*ValueSetterGenerator*/
public static T SecondIncrement<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TimePicker 
=> control._set(() => control.SecondIncrement = value!);

/*BindFromFuncSetterGenerator*/
public static T SecondIncrement<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TimePicker 
   => control._set(func, Avalonia.Controls.TimePicker.SecondIncrementProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SecondIncrement<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TimePicker 
   => control._set(signal, Avalonia.Controls.TimePicker.SecondIncrementProperty!, onChanged);


 // ClockIdentifier

/*ValueSetterGenerator*/
public static T ClockIdentifier<T>(this T control, System.String value) where T : Avalonia.Controls.TimePicker 
=> control._set(() => control.ClockIdentifier = value!);

/*BindFromFuncSetterGenerator*/
public static T ClockIdentifier<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.TimePicker 
   => control._set(func, Avalonia.Controls.TimePicker.ClockIdentifierProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ClockIdentifier<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.TimePicker 
   => control._set(signal, Avalonia.Controls.TimePicker.ClockIdentifierProperty!, onChanged);


 // UseSeconds

/*ValueSetterGenerator*/
public static T UseSeconds<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TimePicker 
=> control._set(() => control.UseSeconds = value!);

/*BindFromFuncSetterGenerator*/
public static T UseSeconds<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TimePicker 
   => control._set(func, Avalonia.Controls.TimePicker.UseSecondsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T UseSeconds<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TimePicker 
   => control._set(signal, Avalonia.Controls.TimePicker.UseSecondsProperty!, onChanged);


 // SelectedTime

/*ValueSetterGenerator*/
public static T SelectedTime<T>(this T control, System.Nullable<System.TimeSpan> value) where T : Avalonia.Controls.TimePicker 
=> control._set(() => control.SelectedTime = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectedTime<T>(this T control, Func<System.Nullable<System.TimeSpan>> func, Action<System.Nullable<System.TimeSpan>>? onChanged = null) where T : Avalonia.Controls.TimePicker 
   => control._set(func, Avalonia.Controls.TimePicker.SelectedTimeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectedTime<T>(this T control, ISignal<System.Nullable<System.TimeSpan>> signal, Action<System.Nullable<System.TimeSpan>>? onChanged = null) where T : Avalonia.Controls.TimePicker 
   => control._set(signal, Avalonia.Controls.TimePicker.SelectedTimeProperty!, onChanged);



//================= Events ======================//
 // SelectedTimeChanged

/*ActionToEventGenerator*/
public static T OnSelectedTimeChanged<T>(this T control, Action<Avalonia.Controls.TimePickerSelectedValueChangedEventArgs> action) where T : Avalonia.Controls.TimePicker  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.TimePickerSelectedValueChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectedTimeChanged += h);



//================= Styles ======================//
 // MinuteIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> MinuteIncrement<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.MinuteIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinuteIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.MinuteIncrementProperty, binding);


 // SecondIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> SecondIncrement<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.SecondIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SecondIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.SecondIncrementProperty, binding);


 // ClockIdentifier

/*ValueStyleSetterGenerator*/
public static Style<T> ClockIdentifier<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.ClockIdentifierProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClockIdentifier<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.ClockIdentifierProperty, binding);


 // UseSeconds

/*ValueStyleSetterGenerator*/
public static Style<T> UseSeconds<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.UseSecondsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseSeconds<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.UseSecondsProperty, binding);


 // SelectedTime

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedTime<T>(this Style<T> style, System.Nullable<System.TimeSpan> value) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.SelectedTimeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedTime<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.SelectedTimeProperty, binding);



}
