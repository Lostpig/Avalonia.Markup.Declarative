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
public static partial class ContentPresenter_MarkupExtensions
{
//================= Properties ======================//
 // Background

/*ValueSetterGenerator*/
public static T Background<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.Background = value!);

/*BindFromFuncSetterGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Background<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty!, onChanged);


 // BackgroundSizing

/*ValueSetterGenerator*/
public static T BackgroundSizing<T>(this T control, Avalonia.Media.BackgroundSizing value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.BackgroundSizing = value!);

/*BindFromFuncSetterGenerator*/
public static T BackgroundSizing<T>(this T control, Func<Avalonia.Media.BackgroundSizing> func, Action<Avalonia.Media.BackgroundSizing>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T BackgroundSizing<T>(this T control, ISignal<Avalonia.Media.BackgroundSizing> signal, Action<Avalonia.Media.BackgroundSizing>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty!, onChanged);


 // BorderBrush

/*ValueSetterGenerator*/
public static T BorderBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.BorderBrush = value!);

/*BindFromFuncSetterGenerator*/
public static T BorderBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T BorderBrush<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty!, onChanged);


 // BorderThickness

/*ValueSetterGenerator*/
public static T BorderThickness<T>(this T control, Avalonia.Thickness value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.BorderThickness = value!);

/*BindFromFuncSetterGenerator*/
public static T BorderThickness<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T BorderThickness<T>(this T control, ISignal<Avalonia.Thickness> signal, Action<Avalonia.Thickness>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T BorderThickness<T>(this T control, System.Double uniformLength = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(uniformLength));
public static T BorderThickness<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(horizontal, vertical));
public static T BorderThickness<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(left, top, right, bottom));


 // CornerRadius

/*ValueSetterGenerator*/
public static T CornerRadius<T>(this T control, Avalonia.CornerRadius value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.CornerRadius = value!);

/*BindFromFuncSetterGenerator*/
public static T CornerRadius<T>(this T control, Func<Avalonia.CornerRadius> func, Action<Avalonia.CornerRadius>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CornerRadius<T>(this T control, ISignal<Avalonia.CornerRadius> signal, Action<Avalonia.CornerRadius>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T CornerRadius<T>(this T control, System.Double uniformRadius = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(uniformRadius));
public static T CornerRadius<T>(this T control, System.Double top = default!, System.Double bottom = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(top, bottom));
public static T CornerRadius<T>(this T control, System.Double topLeft = default!, System.Double topRight = default!, System.Double bottomRight = default!, System.Double bottomLeft = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));


 // BoxShadow

/*ValueSetterGenerator*/
public static T BoxShadow<T>(this T control, Avalonia.Media.BoxShadows value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.BoxShadow = value!);

/*BindFromFuncSetterGenerator*/
public static T BoxShadow<T>(this T control, Func<Avalonia.Media.BoxShadows> func, Action<Avalonia.Media.BoxShadows>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T BoxShadow<T>(this T control, ISignal<Avalonia.Media.BoxShadows> signal, Action<Avalonia.Media.BoxShadows>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T BoxShadow<T>(this T control, Avalonia.Media.BoxShadow shadow = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.BoxShadow = new Avalonia.Media.BoxShadows(shadow));
public static T BoxShadow<T>(this T control, Avalonia.Media.BoxShadow first = default!, Avalonia.Media.BoxShadow[] rest = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.BoxShadow = new Avalonia.Media.BoxShadows(first, rest));


 // Foreground

/*ValueSetterGenerator*/
public static T Foreground<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.Foreground = value!);

/*BindFromFuncSetterGenerator*/
public static T Foreground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Foreground<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty!, onChanged);


 // FontFamily

/*ValueSetterGenerator*/
public static T FontFamily<T>(this T control, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.FontFamily = value!);

/*BindFromFuncSetterGenerator*/
public static T FontFamily<T>(this T control, Func<Avalonia.Media.FontFamily> func, Action<Avalonia.Media.FontFamily>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontFamily<T>(this T control, ISignal<Avalonia.Media.FontFamily> signal, Action<Avalonia.Media.FontFamily>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty!, onChanged);


 // FontSize

/*ValueSetterGenerator*/
public static T FontSize<T>(this T control, System.Double value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.FontSize = value!);

/*BindFromFuncSetterGenerator*/
public static T FontSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontSize<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty!, onChanged);


 // FontStyle

/*ValueSetterGenerator*/
public static T FontStyle<T>(this T control, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.FontStyle = value!);

/*BindFromFuncSetterGenerator*/
public static T FontStyle<T>(this T control, Func<Avalonia.Media.FontStyle> func, Action<Avalonia.Media.FontStyle>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontStyle<T>(this T control, ISignal<Avalonia.Media.FontStyle> signal, Action<Avalonia.Media.FontStyle>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty!, onChanged);


 // FontWeight

/*ValueSetterGenerator*/
public static T FontWeight<T>(this T control, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.FontWeight = value!);

/*BindFromFuncSetterGenerator*/
public static T FontWeight<T>(this T control, Func<Avalonia.Media.FontWeight> func, Action<Avalonia.Media.FontWeight>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontWeight<T>(this T control, ISignal<Avalonia.Media.FontWeight> signal, Action<Avalonia.Media.FontWeight>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty!, onChanged);


 // FontStretch

/*ValueSetterGenerator*/
public static T FontStretch<T>(this T control, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.FontStretch = value!);

/*BindFromFuncSetterGenerator*/
public static T FontStretch<T>(this T control, Func<Avalonia.Media.FontStretch> func, Action<Avalonia.Media.FontStretch>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontStretch<T>(this T control, ISignal<Avalonia.Media.FontStretch> signal, Action<Avalonia.Media.FontStretch>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty!, onChanged);


 // TextAlignment

/*ValueSetterGenerator*/
public static T TextAlignment<T>(this T control, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.TextAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func, Action<Avalonia.Media.TextAlignment>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TextAlignment<T>(this T control, ISignal<Avalonia.Media.TextAlignment> signal, Action<Avalonia.Media.TextAlignment>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty!, onChanged);


 // TextWrapping

/*ValueSetterGenerator*/
public static T TextWrapping<T>(this T control, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.TextWrapping = value!);

/*BindFromFuncSetterGenerator*/
public static T TextWrapping<T>(this T control, Func<Avalonia.Media.TextWrapping> func, Action<Avalonia.Media.TextWrapping>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TextWrapping<T>(this T control, ISignal<Avalonia.Media.TextWrapping> signal, Action<Avalonia.Media.TextWrapping>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty!, onChanged);


 // TextTrimming

/*ValueSetterGenerator*/
public static T TextTrimming<T>(this T control, Avalonia.Media.TextTrimming value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.TextTrimming = value!);

/*BindFromFuncSetterGenerator*/
public static T TextTrimming<T>(this T control, Func<Avalonia.Media.TextTrimming> func, Action<Avalonia.Media.TextTrimming>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TextTrimming<T>(this T control, ISignal<Avalonia.Media.TextTrimming> signal, Action<Avalonia.Media.TextTrimming>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty!, onChanged);


 // LineHeight

/*ValueSetterGenerator*/
public static T LineHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.LineHeight = value!);

/*BindFromFuncSetterGenerator*/
public static T LineHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T LineHeight<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty!, onChanged);


 // MaxLines

/*ValueSetterGenerator*/
public static T MaxLines<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.MaxLines = value!);

/*BindFromFuncSetterGenerator*/
public static T MaxLines<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MaxLines<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty!, onChanged);


 // Content

/*ValueSetterGenerator*/
public static T Content<T>(this T control, System.Object value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.Content = value!);

/*BindFromFuncSetterGenerator*/
public static T Content<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.ContentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Content<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.ContentProperty!, onChanged);


 // ContentTemplate

/*ValueSetterGenerator*/
public static T ContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.ContentTemplate = value!);

/*BindFromFuncSetterGenerator*/
public static T ContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ContentTemplate<T>(this T control, ISignal<Avalonia.Controls.Templates.IDataTemplate> signal, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty!, onChanged);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.HorizontalContentAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, ISignal<Avalonia.Layout.HorizontalAlignment> signal, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty!, onChanged);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.VerticalContentAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, ISignal<Avalonia.Layout.VerticalAlignment> signal, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty!, onChanged);


 // Padding

/*ValueSetterGenerator*/
public static T Padding<T>(this T control, Avalonia.Thickness value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.Padding = value!);

/*BindFromFuncSetterGenerator*/
public static T Padding<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Padding<T>(this T control, ISignal<Avalonia.Thickness> signal, Action<Avalonia.Thickness>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T Padding<T>(this T control, System.Double uniformLength = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.Padding = new Avalonia.Thickness(uniformLength));
public static T Padding<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.Padding = new Avalonia.Thickness(horizontal, vertical));
public static T Padding<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(() => control.Padding = new Avalonia.Thickness(left, top, right, bottom));


 // RecognizesAccessKey

/*ValueSetterGenerator*/
public static T RecognizesAccessKey<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> control._set(() => control.RecognizesAccessKey = value!);

/*BindFromFuncSetterGenerator*/
public static T RecognizesAccessKey<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T RecognizesAccessKey<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty!, onChanged);



//================= Styles ======================//
 // Background

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty, binding);


 // BackgroundSizing

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundSizing<T>(this Style<T> style, Avalonia.Media.BackgroundSizing value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundSizing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BackgroundSizingProperty, binding);


 // BorderBrush

/*ValueStyleSetterGenerator*/
public static Style<T> BorderBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BorderBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty, binding);


 // BorderThickness

/*ValueStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, new Avalonia.Thickness(uniformLength));public static Style<T> BorderThickness<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> BorderThickness<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty, new Avalonia.Thickness(left, top, right, bottom));


 // CornerRadius

/*ValueStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, Avalonia.CornerRadius value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, System.Double uniformRadius) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, new Avalonia.CornerRadius(uniformRadius));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double top, System.Double bottom) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, new Avalonia.CornerRadius(top, bottom));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double topLeft, System.Double topRight, System.Double bottomRight, System.Double bottomLeft) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty, new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));


 // BoxShadow

/*ValueStyleSetterGenerator*/
public static Style<T> BoxShadow<T>(this Style<T> style, Avalonia.Media.BoxShadows value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BoxShadow<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> BoxShadow<T>(this Style<T> style, Avalonia.Media.BoxShadow shadow) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, new Avalonia.Media.BoxShadows(shadow));public static Style<T> BoxShadow<T>(this Style<T> style, Avalonia.Media.BoxShadow first, Avalonia.Media.BoxShadow[] rest) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty, new Avalonia.Media.BoxShadows(first, rest));


 // Foreground

/*ValueStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ForegroundProperty, binding);


 // FontFamily

/*ValueStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontFamilyProperty, binding);


 // FontSize

/*ValueStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontSizeProperty, binding);


 // FontStyle

/*ValueStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontStyleProperty, binding);


 // FontWeight

/*ValueStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontWeightProperty, binding);


 // FontStretch

/*ValueStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.FontStretchProperty, binding);


 // TextAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextAlignmentProperty, binding);


 // TextWrapping

/*ValueStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextWrappingProperty, binding);


 // TextTrimming

/*ValueStyleSetterGenerator*/
public static Style<T> TextTrimming<T>(this Style<T> style, Avalonia.Media.TextTrimming value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextTrimming<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.TextTrimmingProperty, binding);


 // LineHeight

/*ValueStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.LineHeightProperty, binding);


 // MaxLines

/*ValueStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.MaxLinesProperty, binding);


 // Content

/*ValueStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty, binding);


 // ContentTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty, binding);


 // Padding

/*ValueStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, new Avalonia.Thickness(uniformLength));public static Style<T> Padding<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> Padding<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Presenters.ContentPresenter 
   => style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty, new Avalonia.Thickness(left, top, right, bottom));


 // RecognizesAccessKey

/*ValueStyleSetterGenerator*/
public static Style<T> RecognizesAccessKey<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RecognizesAccessKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty, binding);



}
