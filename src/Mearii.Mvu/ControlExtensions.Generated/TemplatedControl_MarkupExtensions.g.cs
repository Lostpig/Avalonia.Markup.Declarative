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
public static partial class TemplatedControl_MarkupExtensions
{
//================= Properties ======================//
 // Background

/*ValueSetterGenerator*/
public static T Background<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._set(() => control.Background = value!);

/*BindFromFuncSetterGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(func, Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Background<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(signal, Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty!, onChanged);


 // BackgroundSizing

/*ValueSetterGenerator*/
public static T BackgroundSizing<T>(this T control, Avalonia.Media.BackgroundSizing value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._set(() => control.BackgroundSizing = value!);

/*BindFromFuncSetterGenerator*/
public static T BackgroundSizing<T>(this T control, Func<Avalonia.Media.BackgroundSizing> func, Action<Avalonia.Media.BackgroundSizing>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(func, Avalonia.Controls.Primitives.TemplatedControl.BackgroundSizingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T BackgroundSizing<T>(this T control, ISignal<Avalonia.Media.BackgroundSizing> signal, Action<Avalonia.Media.BackgroundSizing>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(signal, Avalonia.Controls.Primitives.TemplatedControl.BackgroundSizingProperty!, onChanged);


 // BorderBrush

/*ValueSetterGenerator*/
public static T BorderBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._set(() => control.BorderBrush = value!);

/*BindFromFuncSetterGenerator*/
public static T BorderBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(func, Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T BorderBrush<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(signal, Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty!, onChanged);


 // BorderThickness

/*ValueSetterGenerator*/
public static T BorderThickness<T>(this T control, Avalonia.Thickness value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._set(() => control.BorderThickness = value!);

/*BindFromFuncSetterGenerator*/
public static T BorderThickness<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(func, Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T BorderThickness<T>(this T control, ISignal<Avalonia.Thickness> signal, Action<Avalonia.Thickness>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(signal, Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T BorderThickness<T>(this T control, System.Double uniformLength = default!) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(uniformLength));
public static T BorderThickness<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(horizontal, vertical));
public static T BorderThickness<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(left, top, right, bottom));


 // CornerRadius

/*ValueSetterGenerator*/
public static T CornerRadius<T>(this T control, Avalonia.CornerRadius value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._set(() => control.CornerRadius = value!);

/*BindFromFuncSetterGenerator*/
public static T CornerRadius<T>(this T control, Func<Avalonia.CornerRadius> func, Action<Avalonia.CornerRadius>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(func, Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CornerRadius<T>(this T control, ISignal<Avalonia.CornerRadius> signal, Action<Avalonia.CornerRadius>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(signal, Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T CornerRadius<T>(this T control, System.Double uniformRadius = default!) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(uniformRadius));
public static T CornerRadius<T>(this T control, System.Double top = default!, System.Double bottom = default!) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(top, bottom));
public static T CornerRadius<T>(this T control, System.Double topLeft = default!, System.Double topRight = default!, System.Double bottomRight = default!, System.Double bottomLeft = default!) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));


 // FontFamily

/*ValueSetterGenerator*/
public static T FontFamily<T>(this T control, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._set(() => control.FontFamily = value!);

/*BindFromFuncSetterGenerator*/
public static T FontFamily<T>(this T control, Func<Avalonia.Media.FontFamily> func, Action<Avalonia.Media.FontFamily>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(func, Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontFamily<T>(this T control, ISignal<Avalonia.Media.FontFamily> signal, Action<Avalonia.Media.FontFamily>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(signal, Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty!, onChanged);


 // FontFeatures

/*ValueSetterGenerator*/
public static T FontFeatures<T>(this T control, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._set(() => control.FontFeatures = value!);

/*BindFromFuncSetterGenerator*/
public static T FontFeatures<T>(this T control, Func<Avalonia.Media.FontFeatureCollection> func, Action<Avalonia.Media.FontFeatureCollection>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(func, Avalonia.Controls.Primitives.TemplatedControl.FontFeaturesProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontFeatures<T>(this T control, ISignal<Avalonia.Media.FontFeatureCollection> signal, Action<Avalonia.Media.FontFeatureCollection>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(signal, Avalonia.Controls.Primitives.TemplatedControl.FontFeaturesProperty!, onChanged);


 // FontSize

/*ValueSetterGenerator*/
public static T FontSize<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._set(() => control.FontSize = value!);

/*BindFromFuncSetterGenerator*/
public static T FontSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(func, Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontSize<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(signal, Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty!, onChanged);


 // FontStyle

/*ValueSetterGenerator*/
public static T FontStyle<T>(this T control, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._set(() => control.FontStyle = value!);

/*BindFromFuncSetterGenerator*/
public static T FontStyle<T>(this T control, Func<Avalonia.Media.FontStyle> func, Action<Avalonia.Media.FontStyle>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(func, Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontStyle<T>(this T control, ISignal<Avalonia.Media.FontStyle> signal, Action<Avalonia.Media.FontStyle>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(signal, Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty!, onChanged);


 // FontWeight

/*ValueSetterGenerator*/
public static T FontWeight<T>(this T control, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._set(() => control.FontWeight = value!);

/*BindFromFuncSetterGenerator*/
public static T FontWeight<T>(this T control, Func<Avalonia.Media.FontWeight> func, Action<Avalonia.Media.FontWeight>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(func, Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontWeight<T>(this T control, ISignal<Avalonia.Media.FontWeight> signal, Action<Avalonia.Media.FontWeight>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(signal, Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty!, onChanged);


 // FontStretch

/*ValueSetterGenerator*/
public static T FontStretch<T>(this T control, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._set(() => control.FontStretch = value!);

/*BindFromFuncSetterGenerator*/
public static T FontStretch<T>(this T control, Func<Avalonia.Media.FontStretch> func, Action<Avalonia.Media.FontStretch>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(func, Avalonia.Controls.Primitives.TemplatedControl.FontStretchProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontStretch<T>(this T control, ISignal<Avalonia.Media.FontStretch> signal, Action<Avalonia.Media.FontStretch>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(signal, Avalonia.Controls.Primitives.TemplatedControl.FontStretchProperty!, onChanged);


 // Foreground

/*ValueSetterGenerator*/
public static T Foreground<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._set(() => control.Foreground = value!);

/*BindFromFuncSetterGenerator*/
public static T Foreground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(func, Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Foreground<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(signal, Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty!, onChanged);


 // Padding

/*ValueSetterGenerator*/
public static T Padding<T>(this T control, Avalonia.Thickness value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._set(() => control.Padding = value!);

/*BindFromFuncSetterGenerator*/
public static T Padding<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(func, Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Padding<T>(this T control, ISignal<Avalonia.Thickness> signal, Action<Avalonia.Thickness>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(signal, Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T Padding<T>(this T control, System.Double uniformLength = default!) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(() => control.Padding = new Avalonia.Thickness(uniformLength));
public static T Padding<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(() => control.Padding = new Avalonia.Thickness(horizontal, vertical));
public static T Padding<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(() => control.Padding = new Avalonia.Thickness(left, top, right, bottom));


 // Template

/*ValueSetterGenerator*/
public static T Template<T>(this T control, Avalonia.Controls.Templates.IControlTemplate value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> control._set(() => control.Template = value!);

/*BindFromFuncSetterGenerator*/
public static T Template<T>(this T control, Func<Avalonia.Controls.Templates.IControlTemplate> func, Action<Avalonia.Controls.Templates.IControlTemplate>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(func, Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Template<T>(this T control, ISignal<Avalonia.Controls.Templates.IControlTemplate> signal, Action<Avalonia.Controls.Templates.IControlTemplate>? onChanged = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => control._set(signal, Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty!, onChanged);



//================= Attached Properties ======================//
 // IsTemplateFocusTarget

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T TemplatedControl_IsTemplateFocusTarget<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T TemplatedControl_IsTemplateFocusTarget<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T TemplatedControl_IsTemplateFocusTarget<T>(this T control, System.Boolean value, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty!, onChanged);



//================= Events ======================//
 // TemplateApplied

/*ActionToEventGenerator*/
public static T OnTemplateApplied<T>(this T control, Action<Avalonia.Controls.Primitives.TemplateAppliedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.TemplatedControl 
{
  control.AddHandler(Avalonia.Controls.Primitives.TemplatedControl.TemplateAppliedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Primitives.TemplatedControl.TemplateAppliedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Background

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty, binding);


 // BackgroundSizing

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundSizing<T>(this Style<T> style, Avalonia.Media.BackgroundSizing value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BackgroundSizingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundSizing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BackgroundSizingProperty, binding);


 // BorderBrush

/*ValueStyleSetterGenerator*/
public static Style<T> BorderBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BorderBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty, binding);


 // BorderThickness

/*ValueStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, new Avalonia.Thickness(uniformLength));public static Style<T> BorderThickness<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> BorderThickness<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty, new Avalonia.Thickness(left, top, right, bottom));


 // CornerRadius

/*ValueStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, Avalonia.CornerRadius value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, System.Double uniformRadius) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, new Avalonia.CornerRadius(uniformRadius));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double top, System.Double bottom) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, new Avalonia.CornerRadius(top, bottom));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double topLeft, System.Double topRight, System.Double bottomRight, System.Double bottomLeft) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty, new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));


 // FontFamily

/*ValueStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontFamilyProperty, binding);


 // FontFeatures

/*ValueStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontFeaturesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontFeaturesProperty, binding);


 // FontSize

/*ValueStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontSizeProperty, binding);


 // FontStyle

/*ValueStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontStyleProperty, binding);


 // FontWeight

/*ValueStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontWeightProperty, binding);


 // FontStretch

/*ValueStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontStretchProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.FontStretchProperty, binding);


 // Foreground

/*ValueStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.ForegroundProperty, binding);


 // Padding

/*ValueStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, new Avalonia.Thickness(uniformLength));public static Style<T> Padding<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> Padding<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Primitives.TemplatedControl 
   => style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty, new Avalonia.Thickness(left, top, right, bottom));


 // Template

/*ValueStyleSetterGenerator*/
public static Style<T> Template<T>(this Style<T> style, Avalonia.Controls.Templates.IControlTemplate value) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Template<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.TemplatedControl 
=> style._addSetter(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty, binding);



}
