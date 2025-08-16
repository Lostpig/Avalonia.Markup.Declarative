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
public static partial class DatePicker_MarkupExtensions
{
//================= Properties ======================//
 // DayFormat

/*ValueSetterGenerator*/
public static T DayFormat<T>(this T control, System.String value) where T : Avalonia.Controls.DatePicker 
=> control._set(() => control.DayFormat = value!);

/*BindFromFuncSetterGenerator*/
public static T DayFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.DatePicker 
   => control._set(func, Avalonia.Controls.DatePicker.DayFormatProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T DayFormat<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.DatePicker 
   => control._set(signal, Avalonia.Controls.DatePicker.DayFormatProperty!, onChanged);


 // DayVisible

/*ValueSetterGenerator*/
public static T DayVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DatePicker 
=> control._set(() => control.DayVisible = value!);

/*BindFromFuncSetterGenerator*/
public static T DayVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.DatePicker 
   => control._set(func, Avalonia.Controls.DatePicker.DayVisibleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T DayVisible<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.DatePicker 
   => control._set(signal, Avalonia.Controls.DatePicker.DayVisibleProperty!, onChanged);


 // MaxYear

/*ValueSetterGenerator*/
public static T MaxYear<T>(this T control, System.DateTimeOffset value) where T : Avalonia.Controls.DatePicker 
=> control._set(() => control.MaxYear = value!);

/*BindFromFuncSetterGenerator*/
public static T MaxYear<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null) where T : Avalonia.Controls.DatePicker 
   => control._set(func, Avalonia.Controls.DatePicker.MaxYearProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MaxYear<T>(this T control, ISignal<System.DateTimeOffset> signal, Action<System.DateTimeOffset>? onChanged = null) where T : Avalonia.Controls.DatePicker 
   => control._set(signal, Avalonia.Controls.DatePicker.MaxYearProperty!, onChanged);


 // MinYear

/*ValueSetterGenerator*/
public static T MinYear<T>(this T control, System.DateTimeOffset value) where T : Avalonia.Controls.DatePicker 
=> control._set(() => control.MinYear = value!);

/*BindFromFuncSetterGenerator*/
public static T MinYear<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null) where T : Avalonia.Controls.DatePicker 
   => control._set(func, Avalonia.Controls.DatePicker.MinYearProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MinYear<T>(this T control, ISignal<System.DateTimeOffset> signal, Action<System.DateTimeOffset>? onChanged = null) where T : Avalonia.Controls.DatePicker 
   => control._set(signal, Avalonia.Controls.DatePicker.MinYearProperty!, onChanged);


 // MonthFormat

/*ValueSetterGenerator*/
public static T MonthFormat<T>(this T control, System.String value) where T : Avalonia.Controls.DatePicker 
=> control._set(() => control.MonthFormat = value!);

/*BindFromFuncSetterGenerator*/
public static T MonthFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.DatePicker 
   => control._set(func, Avalonia.Controls.DatePicker.MonthFormatProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MonthFormat<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.DatePicker 
   => control._set(signal, Avalonia.Controls.DatePicker.MonthFormatProperty!, onChanged);


 // MonthVisible

/*ValueSetterGenerator*/
public static T MonthVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DatePicker 
=> control._set(() => control.MonthVisible = value!);

/*BindFromFuncSetterGenerator*/
public static T MonthVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.DatePicker 
   => control._set(func, Avalonia.Controls.DatePicker.MonthVisibleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MonthVisible<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.DatePicker 
   => control._set(signal, Avalonia.Controls.DatePicker.MonthVisibleProperty!, onChanged);


 // YearFormat

/*ValueSetterGenerator*/
public static T YearFormat<T>(this T control, System.String value) where T : Avalonia.Controls.DatePicker 
=> control._set(() => control.YearFormat = value!);

/*BindFromFuncSetterGenerator*/
public static T YearFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.DatePicker 
   => control._set(func, Avalonia.Controls.DatePicker.YearFormatProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T YearFormat<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.DatePicker 
   => control._set(signal, Avalonia.Controls.DatePicker.YearFormatProperty!, onChanged);


 // YearVisible

/*ValueSetterGenerator*/
public static T YearVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DatePicker 
=> control._set(() => control.YearVisible = value!);

/*BindFromFuncSetterGenerator*/
public static T YearVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.DatePicker 
   => control._set(func, Avalonia.Controls.DatePicker.YearVisibleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T YearVisible<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.DatePicker 
   => control._set(signal, Avalonia.Controls.DatePicker.YearVisibleProperty!, onChanged);


 // SelectedDate

/*ValueSetterGenerator*/
public static T SelectedDate<T>(this T control, System.Nullable<System.DateTimeOffset> value) where T : Avalonia.Controls.DatePicker 
=> control._set(() => control.SelectedDate = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectedDate<T>(this T control, Func<System.Nullable<System.DateTimeOffset>> func, Action<System.Nullable<System.DateTimeOffset>>? onChanged = null) where T : Avalonia.Controls.DatePicker 
   => control._set(func, Avalonia.Controls.DatePicker.SelectedDateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectedDate<T>(this T control, ISignal<System.Nullable<System.DateTimeOffset>> signal, Action<System.Nullable<System.DateTimeOffset>>? onChanged = null) where T : Avalonia.Controls.DatePicker 
   => control._set(signal, Avalonia.Controls.DatePicker.SelectedDateProperty!, onChanged);



//================= Events ======================//
 // SelectedDateChanged

/*ActionToEventGenerator*/
public static T OnSelectedDateChanged<T>(this T control, Action<Avalonia.Controls.DatePickerSelectedValueChangedEventArgs> action) where T : Avalonia.Controls.DatePicker  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.DatePickerSelectedValueChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectedDateChanged += h);



//================= Styles ======================//
 // DayFormat

/*ValueStyleSetterGenerator*/
public static Style<T> DayFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.DayFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DayFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.DayFormatProperty, binding);


 // DayVisible

/*ValueStyleSetterGenerator*/
public static Style<T> DayVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.DayVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DayVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.DayVisibleProperty, binding);


 // MaxYear

/*ValueStyleSetterGenerator*/
public static Style<T> MaxYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MaxYearProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MaxYearProperty, binding);


 // MinYear

/*ValueStyleSetterGenerator*/
public static Style<T> MinYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MinYearProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MinYearProperty, binding);


 // MonthFormat

/*ValueStyleSetterGenerator*/
public static Style<T> MonthFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MonthFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MonthFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MonthFormatProperty, binding);


 // MonthVisible

/*ValueStyleSetterGenerator*/
public static Style<T> MonthVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MonthVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MonthVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MonthVisibleProperty, binding);


 // YearFormat

/*ValueStyleSetterGenerator*/
public static Style<T> YearFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.YearFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> YearFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.YearFormatProperty, binding);


 // YearVisible

/*ValueStyleSetterGenerator*/
public static Style<T> YearVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.YearVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> YearVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.YearVisibleProperty, binding);


 // SelectedDate

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, System.Nullable<System.DateTimeOffset> value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.SelectedDateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.SelectedDateProperty, binding);



}
