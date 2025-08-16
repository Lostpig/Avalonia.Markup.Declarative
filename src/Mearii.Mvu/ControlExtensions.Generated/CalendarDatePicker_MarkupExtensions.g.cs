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
public static partial class CalendarDatePicker_MarkupExtensions
{
//================= Properties ======================//
 // DisplayDate

/*ValueSetterGenerator*/
public static T DisplayDate<T>(this T control, System.DateTime value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.DisplayDate = value!);

/*BindFromFuncSetterGenerator*/
public static T DisplayDate<T>(this T control, Func<System.DateTime> func, Action<System.DateTime>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(func, Avalonia.Controls.CalendarDatePicker.DisplayDateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T DisplayDate<T>(this T control, ISignal<System.DateTime> signal, Action<System.DateTime>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(signal, Avalonia.Controls.CalendarDatePicker.DisplayDateProperty!, onChanged);


 // DisplayDateStart

/*ValueSetterGenerator*/
public static T DisplayDateStart<T>(this T control, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.DisplayDateStart = value!);

/*BindFromFuncSetterGenerator*/
public static T DisplayDateStart<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(func, Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T DisplayDateStart<T>(this T control, ISignal<System.Nullable<System.DateTime>> signal, Action<System.Nullable<System.DateTime>>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(signal, Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty!, onChanged);


 // DisplayDateEnd

/*ValueSetterGenerator*/
public static T DisplayDateEnd<T>(this T control, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.DisplayDateEnd = value!);

/*BindFromFuncSetterGenerator*/
public static T DisplayDateEnd<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(func, Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T DisplayDateEnd<T>(this T control, ISignal<System.Nullable<System.DateTime>> signal, Action<System.Nullable<System.DateTime>>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(signal, Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty!, onChanged);


 // FirstDayOfWeek

/*ValueSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, System.DayOfWeek value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.FirstDayOfWeek = value!);

/*BindFromFuncSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, Func<System.DayOfWeek> func, Action<System.DayOfWeek>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(func, Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, ISignal<System.DayOfWeek> signal, Action<System.DayOfWeek>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(signal, Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty!, onChanged);


 // IsDropDownOpen

/*ValueSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.IsDropDownOpen = value!);

/*BindFromFuncSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(func, Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(signal, Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty!, onChanged);


 // IsTodayHighlighted

/*ValueSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.IsTodayHighlighted = value!);

/*BindFromFuncSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(func, Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(signal, Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty!, onChanged);


 // SelectedDate

/*ValueSetterGenerator*/
public static T SelectedDate<T>(this T control, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.SelectedDate = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectedDate<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(func, Avalonia.Controls.CalendarDatePicker.SelectedDateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectedDate<T>(this T control, ISignal<System.Nullable<System.DateTime>> signal, Action<System.Nullable<System.DateTime>>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(signal, Avalonia.Controls.CalendarDatePicker.SelectedDateProperty!, onChanged);


 // SelectedDateFormat

/*ValueSetterGenerator*/
public static T SelectedDateFormat<T>(this T control, Avalonia.Controls.CalendarDatePickerFormat value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.SelectedDateFormat = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectedDateFormat<T>(this T control, Func<Avalonia.Controls.CalendarDatePickerFormat> func, Action<Avalonia.Controls.CalendarDatePickerFormat>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(func, Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectedDateFormat<T>(this T control, ISignal<Avalonia.Controls.CalendarDatePickerFormat> signal, Action<Avalonia.Controls.CalendarDatePickerFormat>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(signal, Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty!, onChanged);


 // CustomDateFormatString

/*ValueSetterGenerator*/
public static T CustomDateFormatString<T>(this T control, System.String value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.CustomDateFormatString = value!);

/*BindFromFuncSetterGenerator*/
public static T CustomDateFormatString<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(func, Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CustomDateFormatString<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(signal, Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty!, onChanged);


 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.Text = value!);

/*BindFromFuncSetterGenerator*/
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(func, Avalonia.Controls.CalendarDatePicker.TextProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Text<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(signal, Avalonia.Controls.CalendarDatePicker.TextProperty!, onChanged);


 // Watermark

/*ValueSetterGenerator*/
public static T Watermark<T>(this T control, System.String value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.Watermark = value!);

/*BindFromFuncSetterGenerator*/
public static T Watermark<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(func, Avalonia.Controls.CalendarDatePicker.WatermarkProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Watermark<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(signal, Avalonia.Controls.CalendarDatePicker.WatermarkProperty!, onChanged);


 // UseFloatingWatermark

/*ValueSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.UseFloatingWatermark = value!);

/*BindFromFuncSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(func, Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(signal, Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty!, onChanged);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.HorizontalContentAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(func, Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, ISignal<Avalonia.Layout.HorizontalAlignment> signal, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(signal, Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty!, onChanged);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.CalendarDatePicker 
=> control._set(() => control.VerticalContentAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(func, Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, ISignal<Avalonia.Layout.VerticalAlignment> signal, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(signal, Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty!, onChanged);



//================= Events ======================//
 // CalendarClosed

/*ActionToEventGenerator*/
public static T OnCalendarClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.CalendarDatePicker  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.CalendarClosed += h);


 // CalendarOpened

/*ActionToEventGenerator*/
public static T OnCalendarOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.CalendarDatePicker  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.CalendarOpened += h);


 // DateValidationError

/*ActionToEventGenerator*/
public static T OnDateValidationError<T>(this T control, Action<Avalonia.Controls.CalendarDatePickerDateValidationErrorEventArgs> action) where T : Avalonia.Controls.CalendarDatePicker  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.CalendarDatePickerDateValidationErrorEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DateValidationError += h);


 // SelectedDateChanged

/*ActionToEventGenerator*/
public static T OnSelectedDateChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action) where T : Avalonia.Controls.CalendarDatePicker  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.SelectionChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectedDateChanged += h);



//================= Styles ======================//
 // DisplayDate

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDate<T>(this Style<T> style, System.DateTime value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty, binding);


 // DisplayDateStart

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDateStart<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDateStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty, binding);


 // DisplayDateEnd

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDateEnd<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDateEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty, binding);


 // FirstDayOfWeek

/*ValueStyleSetterGenerator*/
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, System.DayOfWeek value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty, binding);


 // IsDropDownOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty, binding);


 // IsTodayHighlighted

/*ValueStyleSetterGenerator*/
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty, binding);


 // SelectedDate

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty, binding);


 // SelectedDateFormat

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedDateFormat<T>(this Style<T> style, Avalonia.Controls.CalendarDatePickerFormat value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedDateFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty, binding);


 // CustomDateFormatString

/*ValueStyleSetterGenerator*/
public static Style<T> CustomDateFormatString<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CustomDateFormatString<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.TextProperty, binding);


 // Watermark

/*ValueStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.WatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.WatermarkProperty, binding);


 // UseFloatingWatermark

/*ValueStyleSetterGenerator*/
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty, binding);



}
