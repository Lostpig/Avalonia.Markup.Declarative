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
public static partial class DatePickerPresenter_MarkupExtensions
{
//================= Properties ======================//
 // Date

/*ValueSetterGenerator*/
public static T Date<T>(this T control, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
=> control._set(() => control.Date = value!);

/*BindFromFuncSetterGenerator*/
public static T Date<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(func, Avalonia.Controls.DatePickerPresenter.DateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Date<T>(this T control, ISignal<System.DateTimeOffset> signal, Action<System.DateTimeOffset>? onChanged = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(signal, Avalonia.Controls.DatePickerPresenter.DateProperty!, onChanged);


 // DayFormat

/*ValueSetterGenerator*/
public static T DayFormat<T>(this T control, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
=> control._set(() => control.DayFormat = value!);

/*BindFromFuncSetterGenerator*/
public static T DayFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(func, Avalonia.Controls.DatePickerPresenter.DayFormatProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T DayFormat<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(signal, Avalonia.Controls.DatePickerPresenter.DayFormatProperty!, onChanged);


 // DayVisible

/*ValueSetterGenerator*/
public static T DayVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
=> control._set(() => control.DayVisible = value!);

/*BindFromFuncSetterGenerator*/
public static T DayVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(func, Avalonia.Controls.DatePickerPresenter.DayVisibleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T DayVisible<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(signal, Avalonia.Controls.DatePickerPresenter.DayVisibleProperty!, onChanged);


 // MaxYear

/*ValueSetterGenerator*/
public static T MaxYear<T>(this T control, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
=> control._set(() => control.MaxYear = value!);

/*BindFromFuncSetterGenerator*/
public static T MaxYear<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(func, Avalonia.Controls.DatePickerPresenter.MaxYearProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MaxYear<T>(this T control, ISignal<System.DateTimeOffset> signal, Action<System.DateTimeOffset>? onChanged = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(signal, Avalonia.Controls.DatePickerPresenter.MaxYearProperty!, onChanged);


 // MinYear

/*ValueSetterGenerator*/
public static T MinYear<T>(this T control, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
=> control._set(() => control.MinYear = value!);

/*BindFromFuncSetterGenerator*/
public static T MinYear<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(func, Avalonia.Controls.DatePickerPresenter.MinYearProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MinYear<T>(this T control, ISignal<System.DateTimeOffset> signal, Action<System.DateTimeOffset>? onChanged = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(signal, Avalonia.Controls.DatePickerPresenter.MinYearProperty!, onChanged);


 // MonthFormat

/*ValueSetterGenerator*/
public static T MonthFormat<T>(this T control, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
=> control._set(() => control.MonthFormat = value!);

/*BindFromFuncSetterGenerator*/
public static T MonthFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(func, Avalonia.Controls.DatePickerPresenter.MonthFormatProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MonthFormat<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(signal, Avalonia.Controls.DatePickerPresenter.MonthFormatProperty!, onChanged);


 // MonthVisible

/*ValueSetterGenerator*/
public static T MonthVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
=> control._set(() => control.MonthVisible = value!);

/*BindFromFuncSetterGenerator*/
public static T MonthVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(func, Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MonthVisible<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(signal, Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty!, onChanged);


 // YearFormat

/*ValueSetterGenerator*/
public static T YearFormat<T>(this T control, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
=> control._set(() => control.YearFormat = value!);

/*BindFromFuncSetterGenerator*/
public static T YearFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(func, Avalonia.Controls.DatePickerPresenter.YearFormatProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T YearFormat<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(signal, Avalonia.Controls.DatePickerPresenter.YearFormatProperty!, onChanged);


 // YearVisible

/*ValueSetterGenerator*/
public static T YearVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
=> control._set(() => control.YearVisible = value!);

/*BindFromFuncSetterGenerator*/
public static T YearVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(func, Avalonia.Controls.DatePickerPresenter.YearVisibleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T YearVisible<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(signal, Avalonia.Controls.DatePickerPresenter.YearVisibleProperty!, onChanged);



//================= Styles ======================//
 // Date

/*ValueStyleSetterGenerator*/
public static Style<T> Date<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Date<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DateProperty, binding);


 // DayFormat

/*ValueStyleSetterGenerator*/
public static Style<T> DayFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DayFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, binding);


 // DayVisible

/*ValueStyleSetterGenerator*/
public static Style<T> DayVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DayVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, binding);


 // MaxYear

/*ValueStyleSetterGenerator*/
public static Style<T> MaxYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MaxYearProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, binding);


 // MinYear

/*ValueStyleSetterGenerator*/
public static Style<T> MinYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MinYearProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MinYearProperty, binding);


 // MonthFormat

/*ValueStyleSetterGenerator*/
public static Style<T> MonthFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MonthFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, binding);


 // MonthVisible

/*ValueStyleSetterGenerator*/
public static Style<T> MonthVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MonthVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, binding);


 // YearFormat

/*ValueStyleSetterGenerator*/
public static Style<T> YearFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> YearFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, binding);


 // YearVisible

/*ValueStyleSetterGenerator*/
public static Style<T> YearVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> YearVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, binding);



}
