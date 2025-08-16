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
public static partial class Border_MarkupExtensions
{
//================= Properties ======================//
 // Background

/*ValueSetterGenerator*/
public static T Background<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Border 
=> control._set(() => control.Background = value!);

/*BindFromFuncSetterGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Border 
   => control._set(func, Avalonia.Controls.Border.BackgroundProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Background<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Border 
   => control._set(signal, Avalonia.Controls.Border.BackgroundProperty!, onChanged);


 // BackgroundSizing

/*ValueSetterGenerator*/
public static T BackgroundSizing<T>(this T control, Avalonia.Media.BackgroundSizing value) where T : Avalonia.Controls.Border 
=> control._set(() => control.BackgroundSizing = value!);

/*BindFromFuncSetterGenerator*/
public static T BackgroundSizing<T>(this T control, Func<Avalonia.Media.BackgroundSizing> func, Action<Avalonia.Media.BackgroundSizing>? onChanged = null) where T : Avalonia.Controls.Border 
   => control._set(func, Avalonia.Controls.Border.BackgroundSizingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T BackgroundSizing<T>(this T control, ISignal<Avalonia.Media.BackgroundSizing> signal, Action<Avalonia.Media.BackgroundSizing>? onChanged = null) where T : Avalonia.Controls.Border 
   => control._set(signal, Avalonia.Controls.Border.BackgroundSizingProperty!, onChanged);


 // BorderBrush

/*ValueSetterGenerator*/
public static T BorderBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Border 
=> control._set(() => control.BorderBrush = value!);

/*BindFromFuncSetterGenerator*/
public static T BorderBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Border 
   => control._set(func, Avalonia.Controls.Border.BorderBrushProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T BorderBrush<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Border 
   => control._set(signal, Avalonia.Controls.Border.BorderBrushProperty!, onChanged);


 // BorderThickness

/*ValueSetterGenerator*/
public static T BorderThickness<T>(this T control, Avalonia.Thickness value) where T : Avalonia.Controls.Border 
=> control._set(() => control.BorderThickness = value!);

/*BindFromFuncSetterGenerator*/
public static T BorderThickness<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null) where T : Avalonia.Controls.Border 
   => control._set(func, Avalonia.Controls.Border.BorderThicknessProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T BorderThickness<T>(this T control, ISignal<Avalonia.Thickness> signal, Action<Avalonia.Thickness>? onChanged = null) where T : Avalonia.Controls.Border 
   => control._set(signal, Avalonia.Controls.Border.BorderThicknessProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T BorderThickness<T>(this T control, System.Double uniformLength = default!) where T : Avalonia.Controls.Border 
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(uniformLength));
public static T BorderThickness<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Avalonia.Controls.Border 
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(horizontal, vertical));
public static T BorderThickness<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Avalonia.Controls.Border 
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(left, top, right, bottom));


 // CornerRadius

/*ValueSetterGenerator*/
public static T CornerRadius<T>(this T control, Avalonia.CornerRadius value) where T : Avalonia.Controls.Border 
=> control._set(() => control.CornerRadius = value!);

/*BindFromFuncSetterGenerator*/
public static T CornerRadius<T>(this T control, Func<Avalonia.CornerRadius> func, Action<Avalonia.CornerRadius>? onChanged = null) where T : Avalonia.Controls.Border 
   => control._set(func, Avalonia.Controls.Border.CornerRadiusProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CornerRadius<T>(this T control, ISignal<Avalonia.CornerRadius> signal, Action<Avalonia.CornerRadius>? onChanged = null) where T : Avalonia.Controls.Border 
   => control._set(signal, Avalonia.Controls.Border.CornerRadiusProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T CornerRadius<T>(this T control, System.Double uniformRadius = default!) where T : Avalonia.Controls.Border 
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(uniformRadius));
public static T CornerRadius<T>(this T control, System.Double top = default!, System.Double bottom = default!) where T : Avalonia.Controls.Border 
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(top, bottom));
public static T CornerRadius<T>(this T control, System.Double topLeft = default!, System.Double topRight = default!, System.Double bottomRight = default!, System.Double bottomLeft = default!) where T : Avalonia.Controls.Border 
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));


 // BoxShadow

/*ValueSetterGenerator*/
public static T BoxShadow<T>(this T control, Avalonia.Media.BoxShadows value) where T : Avalonia.Controls.Border 
=> control._set(() => control.BoxShadow = value!);

/*BindFromFuncSetterGenerator*/
public static T BoxShadow<T>(this T control, Func<Avalonia.Media.BoxShadows> func, Action<Avalonia.Media.BoxShadows>? onChanged = null) where T : Avalonia.Controls.Border 
   => control._set(func, Avalonia.Controls.Border.BoxShadowProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T BoxShadow<T>(this T control, ISignal<Avalonia.Media.BoxShadows> signal, Action<Avalonia.Media.BoxShadows>? onChanged = null) where T : Avalonia.Controls.Border 
   => control._set(signal, Avalonia.Controls.Border.BoxShadowProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T BoxShadow<T>(this T control, Avalonia.Media.BoxShadow shadow = default!) where T : Avalonia.Controls.Border 
   => control._set(() => control.BoxShadow = new Avalonia.Media.BoxShadows(shadow));
public static T BoxShadow<T>(this T control, Avalonia.Media.BoxShadow first = default!, Avalonia.Media.BoxShadow[] rest = default!) where T : Avalonia.Controls.Border 
   => control._set(() => control.BoxShadow = new Avalonia.Media.BoxShadows(first, rest));



//================= Styles ======================//
 // Background

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.BackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.BackgroundProperty, binding);


 // BackgroundSizing

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundSizing<T>(this Style<T> style, Avalonia.Media.BackgroundSizing value) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.BackgroundSizingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundSizing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.BackgroundSizingProperty, binding);


 // BorderBrush

/*ValueStyleSetterGenerator*/
public static Style<T> BorderBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.BorderBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BorderBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.BorderBrushProperty, binding);


 // BorderThickness

/*ValueStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.BorderThicknessProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.BorderThicknessProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Border 
   => style._addSetter(Avalonia.Controls.Border.BorderThicknessProperty, new Avalonia.Thickness(uniformLength));public static Style<T> BorderThickness<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Border 
   => style._addSetter(Avalonia.Controls.Border.BorderThicknessProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> BorderThickness<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Border 
   => style._addSetter(Avalonia.Controls.Border.BorderThicknessProperty, new Avalonia.Thickness(left, top, right, bottom));


 // CornerRadius

/*ValueStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, Avalonia.CornerRadius value) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.CornerRadiusProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.CornerRadiusProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, System.Double uniformRadius) where T : Avalonia.Controls.Border 
   => style._addSetter(Avalonia.Controls.Border.CornerRadiusProperty, new Avalonia.CornerRadius(uniformRadius));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double top, System.Double bottom) where T : Avalonia.Controls.Border 
   => style._addSetter(Avalonia.Controls.Border.CornerRadiusProperty, new Avalonia.CornerRadius(top, bottom));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double topLeft, System.Double topRight, System.Double bottomRight, System.Double bottomLeft) where T : Avalonia.Controls.Border 
   => style._addSetter(Avalonia.Controls.Border.CornerRadiusProperty, new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));


 // BoxShadow

/*ValueStyleSetterGenerator*/
public static Style<T> BoxShadow<T>(this Style<T> style, Avalonia.Media.BoxShadows value) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.BoxShadowProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BoxShadow<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Border 
=> style._addSetter(Avalonia.Controls.Border.BoxShadowProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> BoxShadow<T>(this Style<T> style, Avalonia.Media.BoxShadow shadow) where T : Avalonia.Controls.Border 
   => style._addSetter(Avalonia.Controls.Border.BoxShadowProperty, new Avalonia.Media.BoxShadows(shadow));public static Style<T> BoxShadow<T>(this Style<T> style, Avalonia.Media.BoxShadow first, Avalonia.Media.BoxShadow[] rest) where T : Avalonia.Controls.Border 
   => style._addSetter(Avalonia.Controls.Border.BoxShadowProperty, new Avalonia.Media.BoxShadows(first, rest));



}
