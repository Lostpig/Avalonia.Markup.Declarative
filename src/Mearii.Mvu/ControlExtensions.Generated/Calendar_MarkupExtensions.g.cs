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
public static partial class Calendar_MarkupExtensions
{
//================= Properties ======================//
 // FirstDayOfWeek

/*ValueSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, System.DayOfWeek value) where T : Avalonia.Controls.Calendar 
=> control._set(() => control.FirstDayOfWeek = value!);

/*BindFromFuncSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, Func<System.DayOfWeek> func, Action<System.DayOfWeek>? onChanged = null) where T : Avalonia.Controls.Calendar 
   => control._set(func, Avalonia.Controls.Calendar.FirstDayOfWeekProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, ISignal<System.DayOfWeek> signal, Action<System.DayOfWeek>? onChanged = null) where T : Avalonia.Controls.Calendar 
   => control._set(signal, Avalonia.Controls.Calendar.FirstDayOfWeekProperty!, onChanged);


 // IsTodayHighlighted

/*ValueSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Calendar 
=> control._set(() => control.IsTodayHighlighted = value!);

/*BindFromFuncSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Calendar 
   => control._set(func, Avalonia.Controls.Calendar.IsTodayHighlightedProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Calendar 
   => control._set(signal, Avalonia.Controls.Calendar.IsTodayHighlightedProperty!, onChanged);


 // HeaderBackground

/*ValueSetterGenerator*/
public static T HeaderBackground<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Calendar 
=> control._set(() => control.HeaderBackground = value!);

/*BindFromFuncSetterGenerator*/
public static T HeaderBackground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Calendar 
   => control._set(func, Avalonia.Controls.Calendar.HeaderBackgroundProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HeaderBackground<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Calendar 
   => control._set(signal, Avalonia.Controls.Calendar.HeaderBackgroundProperty!, onChanged);


 // DisplayMode

/*ValueSetterGenerator*/
public static T DisplayMode<T>(this T control, Avalonia.Controls.CalendarMode value) where T : Avalonia.Controls.Calendar 
=> control._set(() => control.DisplayMode = value!);

/*BindFromFuncSetterGenerator*/
public static T DisplayMode<T>(this T control, Func<Avalonia.Controls.CalendarMode> func, Action<Avalonia.Controls.CalendarMode>? onChanged = null) where T : Avalonia.Controls.Calendar 
   => control._set(func, Avalonia.Controls.Calendar.DisplayModeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T DisplayMode<T>(this T control, ISignal<Avalonia.Controls.CalendarMode> signal, Action<Avalonia.Controls.CalendarMode>? onChanged = null) where T : Avalonia.Controls.Calendar 
   => control._set(signal, Avalonia.Controls.Calendar.DisplayModeProperty!, onChanged);


 // SelectionMode

/*ValueSetterGenerator*/
public static T SelectionMode<T>(this T control, Avalonia.Controls.CalendarSelectionMode value) where T : Avalonia.Controls.Calendar 
=> control._set(() => control.SelectionMode = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectionMode<T>(this T control, Func<Avalonia.Controls.CalendarSelectionMode> func, Action<Avalonia.Controls.CalendarSelectionMode>? onChanged = null) where T : Avalonia.Controls.Calendar 
   => control._set(func, Avalonia.Controls.Calendar.SelectionModeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectionMode<T>(this T control, ISignal<Avalonia.Controls.CalendarSelectionMode> signal, Action<Avalonia.Controls.CalendarSelectionMode>? onChanged = null) where T : Avalonia.Controls.Calendar 
   => control._set(signal, Avalonia.Controls.Calendar.SelectionModeProperty!, onChanged);


 // SelectedDate

/*ValueSetterGenerator*/
public static T SelectedDate<T>(this T control, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar 
=> control._set(() => control.SelectedDate = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectedDate<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null) where T : Avalonia.Controls.Calendar 
   => control._set(func, Avalonia.Controls.Calendar.SelectedDateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectedDate<T>(this T control, ISignal<System.Nullable<System.DateTime>> signal, Action<System.Nullable<System.DateTime>>? onChanged = null) where T : Avalonia.Controls.Calendar 
   => control._set(signal, Avalonia.Controls.Calendar.SelectedDateProperty!, onChanged);


 // DisplayDate

/*ValueSetterGenerator*/
public static T DisplayDate<T>(this T control, System.DateTime value) where T : Avalonia.Controls.Calendar 
=> control._set(() => control.DisplayDate = value!);

/*BindFromFuncSetterGenerator*/
public static T DisplayDate<T>(this T control, Func<System.DateTime> func, Action<System.DateTime>? onChanged = null) where T : Avalonia.Controls.Calendar 
   => control._set(func, Avalonia.Controls.Calendar.DisplayDateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T DisplayDate<T>(this T control, ISignal<System.DateTime> signal, Action<System.DateTime>? onChanged = null) where T : Avalonia.Controls.Calendar 
   => control._set(signal, Avalonia.Controls.Calendar.DisplayDateProperty!, onChanged);


 // DisplayDateStart

/*ValueSetterGenerator*/
public static T DisplayDateStart<T>(this T control, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar 
=> control._set(() => control.DisplayDateStart = value!);

/*BindFromFuncSetterGenerator*/
public static T DisplayDateStart<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null) where T : Avalonia.Controls.Calendar 
   => control._set(func, Avalonia.Controls.Calendar.DisplayDateStartProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T DisplayDateStart<T>(this T control, ISignal<System.Nullable<System.DateTime>> signal, Action<System.Nullable<System.DateTime>>? onChanged = null) where T : Avalonia.Controls.Calendar 
   => control._set(signal, Avalonia.Controls.Calendar.DisplayDateStartProperty!, onChanged);


 // DisplayDateEnd

/*ValueSetterGenerator*/
public static T DisplayDateEnd<T>(this T control, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar 
=> control._set(() => control.DisplayDateEnd = value!);

/*BindFromFuncSetterGenerator*/
public static T DisplayDateEnd<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null) where T : Avalonia.Controls.Calendar 
   => control._set(func, Avalonia.Controls.Calendar.DisplayDateEndProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T DisplayDateEnd<T>(this T control, ISignal<System.Nullable<System.DateTime>> signal, Action<System.Nullable<System.DateTime>>? onChanged = null) where T : Avalonia.Controls.Calendar 
   => control._set(signal, Avalonia.Controls.Calendar.DisplayDateEndProperty!, onChanged);



//================= Events ======================//
 // SelectedDatesChanged

/*ActionToEventGenerator*/
public static T OnSelectedDatesChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action) where T : Avalonia.Controls.Calendar  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.SelectionChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectedDatesChanged += h);


 // DisplayDateChanged

/*ActionToEventGenerator*/
public static T OnDisplayDateChanged<T>(this T control, Action<Avalonia.Controls.CalendarDateChangedEventArgs> action) where T : Avalonia.Controls.Calendar  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.CalendarDateChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DisplayDateChanged += h);


 // DisplayModeChanged

/*ActionToEventGenerator*/
public static T OnDisplayModeChanged<T>(this T control, Action<Avalonia.Controls.CalendarModeChangedEventArgs> action) where T : Avalonia.Controls.Calendar  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.CalendarModeChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DisplayModeChanged += h);



//================= Styles ======================//
 // FirstDayOfWeek

/*ValueStyleSetterGenerator*/
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, System.DayOfWeek value) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.FirstDayOfWeekProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, binding);


 // IsTodayHighlighted

/*ValueStyleSetterGenerator*/
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.IsTodayHighlightedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, binding);


 // HeaderBackground

/*ValueStyleSetterGenerator*/
public static Style<T> HeaderBackground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.HeaderBackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HeaderBackground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.HeaderBackgroundProperty, binding);


 // DisplayMode

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayMode<T>(this Style<T> style, Avalonia.Controls.CalendarMode value) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.DisplayModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.DisplayModeProperty, binding);


 // SelectionMode

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionMode<T>(this Style<T> style, Avalonia.Controls.CalendarSelectionMode value) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.SelectionModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.SelectionModeProperty, binding);


 // SelectedDate

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.SelectedDateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.SelectedDateProperty, binding);


 // DisplayDate

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDate<T>(this Style<T> style, System.DateTime value) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateProperty, binding);


 // DisplayDateStart

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDateStart<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateStartProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDateStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateStartProperty, binding);


 // DisplayDateEnd

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDateEnd<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateEndProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDateEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar 
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateEndProperty, binding);



}
