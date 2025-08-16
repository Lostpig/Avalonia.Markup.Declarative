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
public static partial class TimePickerPresenter_MarkupExtensions
{
//================= Properties ======================//
 // MinuteIncrement

/*ValueSetterGenerator*/
public static T MinuteIncrement<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TimePickerPresenter 
=> control._set(() => control.MinuteIncrement = value!);

/*BindFromFuncSetterGenerator*/
public static T MinuteIncrement<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(func, Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MinuteIncrement<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(signal, Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty!, onChanged);


 // SecondIncrement

/*ValueSetterGenerator*/
public static T SecondIncrement<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TimePickerPresenter 
=> control._set(() => control.SecondIncrement = value!);

/*BindFromFuncSetterGenerator*/
public static T SecondIncrement<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(func, Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SecondIncrement<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(signal, Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty!, onChanged);


 // ClockIdentifier

/*ValueSetterGenerator*/
public static T ClockIdentifier<T>(this T control, System.String value) where T : Avalonia.Controls.TimePickerPresenter 
=> control._set(() => control.ClockIdentifier = value!);

/*BindFromFuncSetterGenerator*/
public static T ClockIdentifier<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(func, Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ClockIdentifier<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(signal, Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty!, onChanged);


 // UseSeconds

/*ValueSetterGenerator*/
public static T UseSeconds<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TimePickerPresenter 
=> control._set(() => control.UseSeconds = value!);

/*BindFromFuncSetterGenerator*/
public static T UseSeconds<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(func, Avalonia.Controls.TimePickerPresenter.UseSecondsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T UseSeconds<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(signal, Avalonia.Controls.TimePickerPresenter.UseSecondsProperty!, onChanged);


 // Time

/*ValueSetterGenerator*/
public static T Time<T>(this T control, System.TimeSpan value) where T : Avalonia.Controls.TimePickerPresenter 
=> control._set(() => control.Time = value!);

/*BindFromFuncSetterGenerator*/
public static T Time<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(func, Avalonia.Controls.TimePickerPresenter.TimeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Time<T>(this T control, ISignal<System.TimeSpan> signal, Action<System.TimeSpan>? onChanged = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(signal, Avalonia.Controls.TimePickerPresenter.TimeProperty!, onChanged);



//================= Styles ======================//
 // MinuteIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> MinuteIncrement<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinuteIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty, binding);


 // SecondIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> SecondIncrement<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SecondIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty, binding);


 // ClockIdentifier

/*ValueStyleSetterGenerator*/
public static Style<T> ClockIdentifier<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClockIdentifier<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty, binding);


 // UseSeconds

/*ValueStyleSetterGenerator*/
public static Style<T> UseSeconds<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseSeconds<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty, binding);


 // Time

/*ValueStyleSetterGenerator*/
public static Style<T> Time<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.TimeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Time<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.TimeProperty, binding);



}
