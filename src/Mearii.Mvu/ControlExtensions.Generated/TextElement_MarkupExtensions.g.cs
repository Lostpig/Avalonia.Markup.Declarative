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
public static partial class TextElement_MarkupExtensions
{
//================= Properties ======================//
 // Background

/*ValueSetterGenerator*/
public static T Background<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Documents.TextElement 
=> control._set(() => control.Background = value!);

/*BindFromFuncSetterGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(func, Avalonia.Controls.Documents.TextElement.BackgroundProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Background<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(signal, Avalonia.Controls.Documents.TextElement.BackgroundProperty!, onChanged);


 // FontFamily

/*ValueSetterGenerator*/
public static T FontFamily<T>(this T control, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Documents.TextElement 
=> control._set(() => control.FontFamily = value!);

/*BindFromFuncSetterGenerator*/
public static T FontFamily<T>(this T control, Func<Avalonia.Media.FontFamily> func, Action<Avalonia.Media.FontFamily>? onChanged = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(func, Avalonia.Controls.Documents.TextElement.FontFamilyProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontFamily<T>(this T control, ISignal<Avalonia.Media.FontFamily> signal, Action<Avalonia.Media.FontFamily>? onChanged = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(signal, Avalonia.Controls.Documents.TextElement.FontFamilyProperty!, onChanged);


 // FontFeatures

/*ValueSetterGenerator*/
public static T FontFeatures<T>(this T control, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.Documents.TextElement 
=> control._set(() => control.FontFeatures = value!);

/*BindFromFuncSetterGenerator*/
public static T FontFeatures<T>(this T control, Func<Avalonia.Media.FontFeatureCollection> func, Action<Avalonia.Media.FontFeatureCollection>? onChanged = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(func, Avalonia.Controls.Documents.TextElement.FontFeaturesProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontFeatures<T>(this T control, ISignal<Avalonia.Media.FontFeatureCollection> signal, Action<Avalonia.Media.FontFeatureCollection>? onChanged = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(signal, Avalonia.Controls.Documents.TextElement.FontFeaturesProperty!, onChanged);


 // FontSize

/*ValueSetterGenerator*/
public static T FontSize<T>(this T control, System.Double value) where T : Avalonia.Controls.Documents.TextElement 
=> control._set(() => control.FontSize = value!);

/*BindFromFuncSetterGenerator*/
public static T FontSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(func, Avalonia.Controls.Documents.TextElement.FontSizeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontSize<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(signal, Avalonia.Controls.Documents.TextElement.FontSizeProperty!, onChanged);


 // FontStyle

/*ValueSetterGenerator*/
public static T FontStyle<T>(this T control, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Documents.TextElement 
=> control._set(() => control.FontStyle = value!);

/*BindFromFuncSetterGenerator*/
public static T FontStyle<T>(this T control, Func<Avalonia.Media.FontStyle> func, Action<Avalonia.Media.FontStyle>? onChanged = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(func, Avalonia.Controls.Documents.TextElement.FontStyleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontStyle<T>(this T control, ISignal<Avalonia.Media.FontStyle> signal, Action<Avalonia.Media.FontStyle>? onChanged = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(signal, Avalonia.Controls.Documents.TextElement.FontStyleProperty!, onChanged);


 // FontWeight

/*ValueSetterGenerator*/
public static T FontWeight<T>(this T control, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Documents.TextElement 
=> control._set(() => control.FontWeight = value!);

/*BindFromFuncSetterGenerator*/
public static T FontWeight<T>(this T control, Func<Avalonia.Media.FontWeight> func, Action<Avalonia.Media.FontWeight>? onChanged = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(func, Avalonia.Controls.Documents.TextElement.FontWeightProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontWeight<T>(this T control, ISignal<Avalonia.Media.FontWeight> signal, Action<Avalonia.Media.FontWeight>? onChanged = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(signal, Avalonia.Controls.Documents.TextElement.FontWeightProperty!, onChanged);


 // FontStretch

/*ValueSetterGenerator*/
public static T FontStretch<T>(this T control, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.Documents.TextElement 
=> control._set(() => control.FontStretch = value!);

/*BindFromFuncSetterGenerator*/
public static T FontStretch<T>(this T control, Func<Avalonia.Media.FontStretch> func, Action<Avalonia.Media.FontStretch>? onChanged = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(func, Avalonia.Controls.Documents.TextElement.FontStretchProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontStretch<T>(this T control, ISignal<Avalonia.Media.FontStretch> signal, Action<Avalonia.Media.FontStretch>? onChanged = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(signal, Avalonia.Controls.Documents.TextElement.FontStretchProperty!, onChanged);


 // Foreground

/*ValueSetterGenerator*/
public static T Foreground<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Documents.TextElement 
=> control._set(() => control.Foreground = value!);

/*BindFromFuncSetterGenerator*/
public static T Foreground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(func, Avalonia.Controls.Documents.TextElement.ForegroundProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Foreground<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Documents.TextElement 
   => control._set(signal, Avalonia.Controls.Documents.TextElement.ForegroundProperty!, onChanged);



//================= Attached Properties ======================//
 // FontFamily

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T TextElement_FontFamily<T>(this T control, Func<Avalonia.Media.FontFamily> func, Action<Avalonia.Media.FontFamily>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.Documents.TextElement.FontFamilyProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T TextElement_FontFamily<T>(this T control, ISignal<Avalonia.Media.FontFamily> signal, Action<Avalonia.Media.FontFamily>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.Documents.TextElement.FontFamilyProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_FontFamily<T>(this T control, Avalonia.Media.FontFamily value, Action<Avalonia.Media.FontFamily>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.Documents.TextElement.FontFamilyProperty!, onChanged);


 // FontFeatures

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T TextElement_FontFeatures<T>(this T control, Func<Avalonia.Media.FontFeatureCollection> func, Action<Avalonia.Media.FontFeatureCollection>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.Documents.TextElement.FontFeaturesProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T TextElement_FontFeatures<T>(this T control, ISignal<Avalonia.Media.FontFeatureCollection> signal, Action<Avalonia.Media.FontFeatureCollection>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.Documents.TextElement.FontFeaturesProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_FontFeatures<T>(this T control, Avalonia.Media.FontFeatureCollection value, Action<Avalonia.Media.FontFeatureCollection>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.Documents.TextElement.FontFeaturesProperty!, onChanged);


 // FontSize

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T TextElement_FontSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.Documents.TextElement.FontSizeProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T TextElement_FontSize<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.Documents.TextElement.FontSizeProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_FontSize<T>(this T control, System.Double value, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.Documents.TextElement.FontSizeProperty!, onChanged);


 // FontStyle

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T TextElement_FontStyle<T>(this T control, Func<Avalonia.Media.FontStyle> func, Action<Avalonia.Media.FontStyle>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.Documents.TextElement.FontStyleProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T TextElement_FontStyle<T>(this T control, ISignal<Avalonia.Media.FontStyle> signal, Action<Avalonia.Media.FontStyle>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.Documents.TextElement.FontStyleProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_FontStyle<T>(this T control, Avalonia.Media.FontStyle value, Action<Avalonia.Media.FontStyle>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.Documents.TextElement.FontStyleProperty!, onChanged);


 // FontWeight

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T TextElement_FontWeight<T>(this T control, Func<Avalonia.Media.FontWeight> func, Action<Avalonia.Media.FontWeight>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.Documents.TextElement.FontWeightProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T TextElement_FontWeight<T>(this T control, ISignal<Avalonia.Media.FontWeight> signal, Action<Avalonia.Media.FontWeight>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.Documents.TextElement.FontWeightProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_FontWeight<T>(this T control, Avalonia.Media.FontWeight value, Action<Avalonia.Media.FontWeight>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.Documents.TextElement.FontWeightProperty!, onChanged);


 // FontStretch

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T TextElement_FontStretch<T>(this T control, Func<Avalonia.Media.FontStretch> func, Action<Avalonia.Media.FontStretch>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.Documents.TextElement.FontStretchProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T TextElement_FontStretch<T>(this T control, ISignal<Avalonia.Media.FontStretch> signal, Action<Avalonia.Media.FontStretch>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.Documents.TextElement.FontStretchProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_FontStretch<T>(this T control, Avalonia.Media.FontStretch value, Action<Avalonia.Media.FontStretch>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.Documents.TextElement.FontStretchProperty!, onChanged);


 // Foreground

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T TextElement_Foreground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.Documents.TextElement.ForegroundProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T TextElement_Foreground<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.Documents.TextElement.ForegroundProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextElement_Foreground<T>(this T control, Avalonia.Media.IBrush value, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.Documents.TextElement.ForegroundProperty!, onChanged);



//================= Styles ======================//
 // Background

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.BackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.BackgroundProperty, binding);


 // FontFamily

/*ValueStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontFamilyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontFamilyProperty, binding);


 // FontFeatures

/*ValueStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontFeaturesProperty, binding);


 // FontSize

/*ValueStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontSizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontSizeProperty, binding);


 // FontStyle

/*ValueStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontStyleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontStyleProperty, binding);


 // FontWeight

/*ValueStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontWeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontWeightProperty, binding);


 // FontStretch

/*ValueStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontStretchProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.FontStretchProperty, binding);


 // Foreground

/*ValueStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.ForegroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.TextElement 
=> style._addSetter(Avalonia.Controls.Documents.TextElement.ForegroundProperty, binding);



}
