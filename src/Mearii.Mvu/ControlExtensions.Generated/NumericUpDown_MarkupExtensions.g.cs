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
public static partial class NumericUpDown_MarkupExtensions
{
//================= Properties ======================//
 // AllowSpin

/*ValueSetterGenerator*/
public static T AllowSpin<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NumericUpDown 
=> control._set(() => control.AllowSpin = value!);

/*BindFromFuncSetterGenerator*/
public static T AllowSpin<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(func, Avalonia.Controls.NumericUpDown.AllowSpinProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T AllowSpin<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(signal, Avalonia.Controls.NumericUpDown.AllowSpinProperty!, onChanged);


 // ButtonSpinnerLocation

/*ValueSetterGenerator*/
public static T ButtonSpinnerLocation<T>(this T control, Avalonia.Controls.Location value) where T : Avalonia.Controls.NumericUpDown 
=> control._set(() => control.ButtonSpinnerLocation = value!);

/*BindFromFuncSetterGenerator*/
public static T ButtonSpinnerLocation<T>(this T control, Func<Avalonia.Controls.Location> func, Action<Avalonia.Controls.Location>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(func, Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ButtonSpinnerLocation<T>(this T control, ISignal<Avalonia.Controls.Location> signal, Action<Avalonia.Controls.Location>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(signal, Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty!, onChanged);


 // ShowButtonSpinner

/*ValueSetterGenerator*/
public static T ShowButtonSpinner<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NumericUpDown 
=> control._set(() => control.ShowButtonSpinner = value!);

/*BindFromFuncSetterGenerator*/
public static T ShowButtonSpinner<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(func, Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ShowButtonSpinner<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(signal, Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty!, onChanged);


 // ClipValueToMinMax

/*ValueSetterGenerator*/
public static T ClipValueToMinMax<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NumericUpDown 
=> control._set(() => control.ClipValueToMinMax = value!);

/*BindFromFuncSetterGenerator*/
public static T ClipValueToMinMax<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(func, Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ClipValueToMinMax<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(signal, Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty!, onChanged);


 // NumberFormat

/*ValueSetterGenerator*/
public static T NumberFormat<T>(this T control, System.Globalization.NumberFormatInfo value) where T : Avalonia.Controls.NumericUpDown 
=> control._set(() => control.NumberFormat = value!);

/*BindFromFuncSetterGenerator*/
public static T NumberFormat<T>(this T control, Func<System.Globalization.NumberFormatInfo> func, Action<System.Globalization.NumberFormatInfo>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(func, Avalonia.Controls.NumericUpDown.NumberFormatProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T NumberFormat<T>(this T control, ISignal<System.Globalization.NumberFormatInfo> signal, Action<System.Globalization.NumberFormatInfo>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(signal, Avalonia.Controls.NumericUpDown.NumberFormatProperty!, onChanged);


 // FormatString

/*ValueSetterGenerator*/
public static T FormatString<T>(this T control, System.String value) where T : Avalonia.Controls.NumericUpDown 
=> control._set(() => control.FormatString = value!);

/*BindFromFuncSetterGenerator*/
public static T FormatString<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(func, Avalonia.Controls.NumericUpDown.FormatStringProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FormatString<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(signal, Avalonia.Controls.NumericUpDown.FormatStringProperty!, onChanged);


 // Increment

/*ValueSetterGenerator*/
public static T Increment<T>(this T control, System.Decimal value) where T : Avalonia.Controls.NumericUpDown 
=> control._set(() => control.Increment = value!);

/*BindFromFuncSetterGenerator*/
public static T Increment<T>(this T control, Func<System.Decimal> func, Action<System.Decimal>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(func, Avalonia.Controls.NumericUpDown.IncrementProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Increment<T>(this T control, ISignal<System.Decimal> signal, Action<System.Decimal>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(signal, Avalonia.Controls.NumericUpDown.IncrementProperty!, onChanged);


 // IsReadOnly

/*ValueSetterGenerator*/
public static T IsReadOnly<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NumericUpDown 
=> control._set(() => control.IsReadOnly = value!);

/*BindFromFuncSetterGenerator*/
public static T IsReadOnly<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(func, Avalonia.Controls.NumericUpDown.IsReadOnlyProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsReadOnly<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(signal, Avalonia.Controls.NumericUpDown.IsReadOnlyProperty!, onChanged);


 // Maximum

/*ValueSetterGenerator*/
public static T Maximum<T>(this T control, System.Decimal value) where T : Avalonia.Controls.NumericUpDown 
=> control._set(() => control.Maximum = value!);

/*BindFromFuncSetterGenerator*/
public static T Maximum<T>(this T control, Func<System.Decimal> func, Action<System.Decimal>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(func, Avalonia.Controls.NumericUpDown.MaximumProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Maximum<T>(this T control, ISignal<System.Decimal> signal, Action<System.Decimal>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(signal, Avalonia.Controls.NumericUpDown.MaximumProperty!, onChanged);


 // Minimum

/*ValueSetterGenerator*/
public static T Minimum<T>(this T control, System.Decimal value) where T : Avalonia.Controls.NumericUpDown 
=> control._set(() => control.Minimum = value!);

/*BindFromFuncSetterGenerator*/
public static T Minimum<T>(this T control, Func<System.Decimal> func, Action<System.Decimal>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(func, Avalonia.Controls.NumericUpDown.MinimumProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Minimum<T>(this T control, ISignal<System.Decimal> signal, Action<System.Decimal>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(signal, Avalonia.Controls.NumericUpDown.MinimumProperty!, onChanged);


 // ParsingNumberStyle

/*ValueSetterGenerator*/
public static T ParsingNumberStyle<T>(this T control, System.Globalization.NumberStyles value) where T : Avalonia.Controls.NumericUpDown 
=> control._set(() => control.ParsingNumberStyle = value!);

/*BindFromFuncSetterGenerator*/
public static T ParsingNumberStyle<T>(this T control, Func<System.Globalization.NumberStyles> func, Action<System.Globalization.NumberStyles>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(func, Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ParsingNumberStyle<T>(this T control, ISignal<System.Globalization.NumberStyles> signal, Action<System.Globalization.NumberStyles>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(signal, Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty!, onChanged);


 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String value) where T : Avalonia.Controls.NumericUpDown 
=> control._set(() => control.Text = value!);

/*BindFromFuncSetterGenerator*/
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(func, Avalonia.Controls.NumericUpDown.TextProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Text<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(signal, Avalonia.Controls.NumericUpDown.TextProperty!, onChanged);


 // TextConverter

/*ValueSetterGenerator*/
public static T TextConverter<T>(this T control, Avalonia.Data.Converters.IValueConverter value) where T : Avalonia.Controls.NumericUpDown 
=> control._set(() => control.TextConverter = value!);

/*BindFromFuncSetterGenerator*/
public static T TextConverter<T>(this T control, Func<Avalonia.Data.Converters.IValueConverter> func, Action<Avalonia.Data.Converters.IValueConverter>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(func, Avalonia.Controls.NumericUpDown.TextConverterProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TextConverter<T>(this T control, ISignal<Avalonia.Data.Converters.IValueConverter> signal, Action<Avalonia.Data.Converters.IValueConverter>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(signal, Avalonia.Controls.NumericUpDown.TextConverterProperty!, onChanged);


 // Value

/*ValueSetterGenerator*/
public static T Value<T>(this T control, System.Nullable<System.Decimal> value) where T : Avalonia.Controls.NumericUpDown 
=> control._set(() => control.Value = value!);

/*BindFromFuncSetterGenerator*/
public static T Value<T>(this T control, Func<System.Nullable<System.Decimal>> func, Action<System.Nullable<System.Decimal>>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(func, Avalonia.Controls.NumericUpDown.ValueProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Value<T>(this T control, ISignal<System.Nullable<System.Decimal>> signal, Action<System.Nullable<System.Decimal>>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(signal, Avalonia.Controls.NumericUpDown.ValueProperty!, onChanged);


 // Watermark

/*ValueSetterGenerator*/
public static T Watermark<T>(this T control, System.String value) where T : Avalonia.Controls.NumericUpDown 
=> control._set(() => control.Watermark = value!);

/*BindFromFuncSetterGenerator*/
public static T Watermark<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(func, Avalonia.Controls.NumericUpDown.WatermarkProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Watermark<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(signal, Avalonia.Controls.NumericUpDown.WatermarkProperty!, onChanged);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.NumericUpDown 
=> control._set(() => control.HorizontalContentAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(func, Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, ISignal<Avalonia.Layout.HorizontalAlignment> signal, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(signal, Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty!, onChanged);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.NumericUpDown 
=> control._set(() => control.VerticalContentAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(func, Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, ISignal<Avalonia.Layout.VerticalAlignment> signal, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(signal, Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty!, onChanged);


 // TextAlignment

/*ValueSetterGenerator*/
public static T TextAlignment<T>(this T control, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.NumericUpDown 
=> control._set(() => control.TextAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func, Action<Avalonia.Media.TextAlignment>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(func, Avalonia.Controls.NumericUpDown.TextAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TextAlignment<T>(this T control, ISignal<Avalonia.Media.TextAlignment> signal, Action<Avalonia.Media.TextAlignment>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(signal, Avalonia.Controls.NumericUpDown.TextAlignmentProperty!, onChanged);


 // InnerLeftContent

/*ValueSetterGenerator*/
public static T InnerLeftContent<T>(this T control, System.Object value) where T : Avalonia.Controls.NumericUpDown 
=> control._set(() => control.InnerLeftContent = value!);

/*BindFromFuncSetterGenerator*/
public static T InnerLeftContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(func, Avalonia.Controls.NumericUpDown.InnerLeftContentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T InnerLeftContent<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(signal, Avalonia.Controls.NumericUpDown.InnerLeftContentProperty!, onChanged);


 // InnerRightContent

/*ValueSetterGenerator*/
public static T InnerRightContent<T>(this T control, System.Object value) where T : Avalonia.Controls.NumericUpDown 
=> control._set(() => control.InnerRightContent = value!);

/*BindFromFuncSetterGenerator*/
public static T InnerRightContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(func, Avalonia.Controls.NumericUpDown.InnerRightContentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T InnerRightContent<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(signal, Avalonia.Controls.NumericUpDown.InnerRightContentProperty!, onChanged);



//================= Events ======================//
 // Spinned

/*ActionToEventGenerator*/
public static T OnSpinned<T>(this T control, Action<Avalonia.Controls.SpinEventArgs> action) where T : Avalonia.Controls.NumericUpDown  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.SpinEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Spinned += h);


 // ValueChanged

/*ActionToEventGenerator*/
public static T OnValueChanged<T>(this T control, Action<Avalonia.Controls.NumericUpDownValueChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.NumericUpDown 
{
  control.AddHandler(Avalonia.Controls.NumericUpDown.ValueChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.NumericUpDown.ValueChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // AllowSpin

/*ValueStyleSetterGenerator*/
public static Style<T> AllowSpin<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.AllowSpinProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AllowSpin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.AllowSpinProperty, binding);


 // ButtonSpinnerLocation

/*ValueStyleSetterGenerator*/
public static Style<T> ButtonSpinnerLocation<T>(this Style<T> style, Avalonia.Controls.Location value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ButtonSpinnerLocation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty, binding);


 // ShowButtonSpinner

/*ValueStyleSetterGenerator*/
public static Style<T> ShowButtonSpinner<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowButtonSpinner<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty, binding);


 // ClipValueToMinMax

/*ValueStyleSetterGenerator*/
public static Style<T> ClipValueToMinMax<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClipValueToMinMax<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty, binding);


 // NumberFormat

/*ValueStyleSetterGenerator*/
public static Style<T> NumberFormat<T>(this Style<T> style, System.Globalization.NumberFormatInfo value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.NumberFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> NumberFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.NumberFormatProperty, binding);


 // FormatString

/*ValueStyleSetterGenerator*/
public static Style<T> FormatString<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.FormatStringProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FormatString<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.FormatStringProperty, binding);


 // Increment

/*ValueStyleSetterGenerator*/
public static Style<T> Increment<T>(this Style<T> style, System.Decimal value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.IncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Increment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.IncrementProperty, binding);


 // IsReadOnly

/*ValueStyleSetterGenerator*/
public static Style<T> IsReadOnly<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsReadOnly<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty, binding);


 // Maximum

/*ValueStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, System.Decimal value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.MaximumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.MaximumProperty, binding);


 // Minimum

/*ValueStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, System.Decimal value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.MinimumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.MinimumProperty, binding);


 // ParsingNumberStyle

/*ValueStyleSetterGenerator*/
public static Style<T> ParsingNumberStyle<T>(this Style<T> style, System.Globalization.NumberStyles value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ParsingNumberStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextProperty, binding);


 // TextConverter

/*ValueStyleSetterGenerator*/
public static Style<T> TextConverter<T>(this Style<T> style, Avalonia.Data.Converters.IValueConverter value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextConverterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextConverter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextConverterProperty, binding);


 // Value

/*ValueStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, System.Nullable<System.Decimal> value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ValueProperty, binding);


 // Watermark

/*ValueStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.WatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.WatermarkProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty, binding);


 // TextAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextAlignmentProperty, binding);


 // InnerLeftContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty, binding);


 // InnerRightContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.InnerRightContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.InnerRightContentProperty, binding);



}
