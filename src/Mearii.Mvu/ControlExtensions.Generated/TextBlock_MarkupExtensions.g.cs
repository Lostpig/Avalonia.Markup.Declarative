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
public static partial class TextBlock_MarkupExtensions
{
//================= Properties ======================//
 // Background

/*ValueSetterGenerator*/
public static T Background<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBlock 
=> control._set(() => control.Background = value!);

/*BindFromFuncSetterGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(func, Avalonia.Controls.TextBlock.BackgroundProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Background<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(signal, Avalonia.Controls.TextBlock.BackgroundProperty!, onChanged);


 // Padding

/*ValueSetterGenerator*/
public static T Padding<T>(this T control, Avalonia.Thickness value) where T : Avalonia.Controls.TextBlock 
=> control._set(() => control.Padding = value!);

/*BindFromFuncSetterGenerator*/
public static T Padding<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(func, Avalonia.Controls.TextBlock.PaddingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Padding<T>(this T control, ISignal<Avalonia.Thickness> signal, Action<Avalonia.Thickness>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(signal, Avalonia.Controls.TextBlock.PaddingProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T Padding<T>(this T control, System.Double uniformLength = default!) where T : Avalonia.Controls.TextBlock 
   => control._set(() => control.Padding = new Avalonia.Thickness(uniformLength));
public static T Padding<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Avalonia.Controls.TextBlock 
   => control._set(() => control.Padding = new Avalonia.Thickness(horizontal, vertical));
public static T Padding<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Avalonia.Controls.TextBlock 
   => control._set(() => control.Padding = new Avalonia.Thickness(left, top, right, bottom));


 // FontFamily

/*ValueSetterGenerator*/
public static T FontFamily<T>(this T control, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.TextBlock 
=> control._set(() => control.FontFamily = value!);

/*BindFromFuncSetterGenerator*/
public static T FontFamily<T>(this T control, Func<Avalonia.Media.FontFamily> func, Action<Avalonia.Media.FontFamily>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(func, Avalonia.Controls.TextBlock.FontFamilyProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontFamily<T>(this T control, ISignal<Avalonia.Media.FontFamily> signal, Action<Avalonia.Media.FontFamily>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(signal, Avalonia.Controls.TextBlock.FontFamilyProperty!, onChanged);


 // FontSize

/*ValueSetterGenerator*/
public static T FontSize<T>(this T control, System.Double value) where T : Avalonia.Controls.TextBlock 
=> control._set(() => control.FontSize = value!);

/*BindFromFuncSetterGenerator*/
public static T FontSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(func, Avalonia.Controls.TextBlock.FontSizeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontSize<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(signal, Avalonia.Controls.TextBlock.FontSizeProperty!, onChanged);


 // FontStyle

/*ValueSetterGenerator*/
public static T FontStyle<T>(this T control, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.TextBlock 
=> control._set(() => control.FontStyle = value!);

/*BindFromFuncSetterGenerator*/
public static T FontStyle<T>(this T control, Func<Avalonia.Media.FontStyle> func, Action<Avalonia.Media.FontStyle>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(func, Avalonia.Controls.TextBlock.FontStyleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontStyle<T>(this T control, ISignal<Avalonia.Media.FontStyle> signal, Action<Avalonia.Media.FontStyle>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(signal, Avalonia.Controls.TextBlock.FontStyleProperty!, onChanged);


 // FontWeight

/*ValueSetterGenerator*/
public static T FontWeight<T>(this T control, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.TextBlock 
=> control._set(() => control.FontWeight = value!);

/*BindFromFuncSetterGenerator*/
public static T FontWeight<T>(this T control, Func<Avalonia.Media.FontWeight> func, Action<Avalonia.Media.FontWeight>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(func, Avalonia.Controls.TextBlock.FontWeightProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontWeight<T>(this T control, ISignal<Avalonia.Media.FontWeight> signal, Action<Avalonia.Media.FontWeight>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(signal, Avalonia.Controls.TextBlock.FontWeightProperty!, onChanged);


 // FontStretch

/*ValueSetterGenerator*/
public static T FontStretch<T>(this T control, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.TextBlock 
=> control._set(() => control.FontStretch = value!);

/*BindFromFuncSetterGenerator*/
public static T FontStretch<T>(this T control, Func<Avalonia.Media.FontStretch> func, Action<Avalonia.Media.FontStretch>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(func, Avalonia.Controls.TextBlock.FontStretchProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontStretch<T>(this T control, ISignal<Avalonia.Media.FontStretch> signal, Action<Avalonia.Media.FontStretch>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(signal, Avalonia.Controls.TextBlock.FontStretchProperty!, onChanged);


 // Foreground

/*ValueSetterGenerator*/
public static T Foreground<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBlock 
=> control._set(() => control.Foreground = value!);

/*BindFromFuncSetterGenerator*/
public static T Foreground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(func, Avalonia.Controls.TextBlock.ForegroundProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Foreground<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(signal, Avalonia.Controls.TextBlock.ForegroundProperty!, onChanged);


 // BaselineOffset

/*ValueSetterGenerator*/
public static T BaselineOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.TextBlock 
=> control._set(() => control.BaselineOffset = value!);

/*BindFromFuncSetterGenerator*/
public static T BaselineOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(func, Avalonia.Controls.TextBlock.BaselineOffsetProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T BaselineOffset<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(signal, Avalonia.Controls.TextBlock.BaselineOffsetProperty!, onChanged);


 // LineHeight

/*ValueSetterGenerator*/
public static T LineHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.TextBlock 
=> control._set(() => control.LineHeight = value!);

/*BindFromFuncSetterGenerator*/
public static T LineHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(func, Avalonia.Controls.TextBlock.LineHeightProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T LineHeight<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(signal, Avalonia.Controls.TextBlock.LineHeightProperty!, onChanged);


 // LineSpacing

/*ValueSetterGenerator*/
public static T LineSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.TextBlock 
=> control._set(() => control.LineSpacing = value!);

/*BindFromFuncSetterGenerator*/
public static T LineSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(func, Avalonia.Controls.TextBlock.LineSpacingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T LineSpacing<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(signal, Avalonia.Controls.TextBlock.LineSpacingProperty!, onChanged);


 // LetterSpacing

/*ValueSetterGenerator*/
public static T LetterSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.TextBlock 
=> control._set(() => control.LetterSpacing = value!);

/*BindFromFuncSetterGenerator*/
public static T LetterSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(func, Avalonia.Controls.TextBlock.LetterSpacingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T LetterSpacing<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(signal, Avalonia.Controls.TextBlock.LetterSpacingProperty!, onChanged);


 // MaxLines

/*ValueSetterGenerator*/
public static T MaxLines<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBlock 
=> control._set(() => control.MaxLines = value!);

/*BindFromFuncSetterGenerator*/
public static T MaxLines<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(func, Avalonia.Controls.TextBlock.MaxLinesProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MaxLines<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(signal, Avalonia.Controls.TextBlock.MaxLinesProperty!, onChanged);


 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String value) where T : Avalonia.Controls.TextBlock 
=> control._set(() => control.Text = value!);

/*BindFromFuncSetterGenerator*/
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(func, Avalonia.Controls.TextBlock.TextProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Text<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(signal, Avalonia.Controls.TextBlock.TextProperty!, onChanged);


 // TextAlignment

/*ValueSetterGenerator*/
public static T TextAlignment<T>(this T control, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.TextBlock 
=> control._set(() => control.TextAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func, Action<Avalonia.Media.TextAlignment>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(func, Avalonia.Controls.TextBlock.TextAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TextAlignment<T>(this T control, ISignal<Avalonia.Media.TextAlignment> signal, Action<Avalonia.Media.TextAlignment>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(signal, Avalonia.Controls.TextBlock.TextAlignmentProperty!, onChanged);


 // TextWrapping

/*ValueSetterGenerator*/
public static T TextWrapping<T>(this T control, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.TextBlock 
=> control._set(() => control.TextWrapping = value!);

/*BindFromFuncSetterGenerator*/
public static T TextWrapping<T>(this T control, Func<Avalonia.Media.TextWrapping> func, Action<Avalonia.Media.TextWrapping>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(func, Avalonia.Controls.TextBlock.TextWrappingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TextWrapping<T>(this T control, ISignal<Avalonia.Media.TextWrapping> signal, Action<Avalonia.Media.TextWrapping>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(signal, Avalonia.Controls.TextBlock.TextWrappingProperty!, onChanged);


 // TextTrimming

/*ValueSetterGenerator*/
public static T TextTrimming<T>(this T control, Avalonia.Media.TextTrimming value) where T : Avalonia.Controls.TextBlock 
=> control._set(() => control.TextTrimming = value!);

/*BindFromFuncSetterGenerator*/
public static T TextTrimming<T>(this T control, Func<Avalonia.Media.TextTrimming> func, Action<Avalonia.Media.TextTrimming>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(func, Avalonia.Controls.TextBlock.TextTrimmingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TextTrimming<T>(this T control, ISignal<Avalonia.Media.TextTrimming> signal, Action<Avalonia.Media.TextTrimming>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(signal, Avalonia.Controls.TextBlock.TextTrimmingProperty!, onChanged);


 // TextDecorations

/*ValueSetterGenerator*/
public static T TextDecorations<T>(this T control, Avalonia.Media.TextDecorationCollection value) where T : Avalonia.Controls.TextBlock 
=> control._set(() => control.TextDecorations = value!);

/*BindFromFuncSetterGenerator*/
public static T TextDecorations<T>(this T control, Func<Avalonia.Media.TextDecorationCollection> func, Action<Avalonia.Media.TextDecorationCollection>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(func, Avalonia.Controls.TextBlock.TextDecorationsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TextDecorations<T>(this T control, ISignal<Avalonia.Media.TextDecorationCollection> signal, Action<Avalonia.Media.TextDecorationCollection>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(signal, Avalonia.Controls.TextBlock.TextDecorationsProperty!, onChanged);


 // FontFeatures

/*ValueSetterGenerator*/
public static T FontFeatures<T>(this T control, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.TextBlock 
=> control._set(() => control.FontFeatures = value!);

/*BindFromFuncSetterGenerator*/
public static T FontFeatures<T>(this T control, Func<Avalonia.Media.FontFeatureCollection> func, Action<Avalonia.Media.FontFeatureCollection>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(func, Avalonia.Controls.TextBlock.FontFeaturesProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FontFeatures<T>(this T control, ISignal<Avalonia.Media.FontFeatureCollection> signal, Action<Avalonia.Media.FontFeatureCollection>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(signal, Avalonia.Controls.TextBlock.FontFeaturesProperty!, onChanged);


 // Inlines

/*ValueSetterGenerator*/
public static T Inlines<T>(this T control, Avalonia.Controls.Documents.InlineCollection value) where T : Avalonia.Controls.TextBlock 
=> control._set(() => control.Inlines = value!);

/*BindFromFuncSetterGenerator*/
public static T Inlines<T>(this T control, Func<Avalonia.Controls.Documents.InlineCollection> func, Action<Avalonia.Controls.Documents.InlineCollection>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(func, Avalonia.Controls.TextBlock.InlinesProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Inlines<T>(this T control, ISignal<Avalonia.Controls.Documents.InlineCollection> signal, Action<Avalonia.Controls.Documents.InlineCollection>? onChanged = null) where T : Avalonia.Controls.TextBlock 
   => control._set(signal, Avalonia.Controls.TextBlock.InlinesProperty!, onChanged);



//================= Attached Properties ======================//
 // BaselineOffset

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T TextBlock_BaselineOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.TextBlock.BaselineOffsetProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T TextBlock_BaselineOffset<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.TextBlock.BaselineOffsetProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_BaselineOffset<T>(this T control, System.Double value, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.TextBlock.BaselineOffsetProperty!, onChanged);


 // LineHeight

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T TextBlock_LineHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.TextBlock.LineHeightProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T TextBlock_LineHeight<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.TextBlock.LineHeightProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_LineHeight<T>(this T control, System.Double value, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.TextBlock.LineHeightProperty!, onChanged);


 // LetterSpacing

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T TextBlock_LetterSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.TextBlock.LetterSpacingProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T TextBlock_LetterSpacing<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.TextBlock.LetterSpacingProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_LetterSpacing<T>(this T control, System.Double value, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.TextBlock.LetterSpacingProperty!, onChanged);


 // MaxLines

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T TextBlock_MaxLines<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.TextBlock.MaxLinesProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T TextBlock_MaxLines<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.TextBlock.MaxLinesProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_MaxLines<T>(this T control, System.Int32 value, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.TextBlock.MaxLinesProperty!, onChanged);


 // TextAlignment

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T TextBlock_TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func, Action<Avalonia.Media.TextAlignment>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.TextBlock.TextAlignmentProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T TextBlock_TextAlignment<T>(this T control, ISignal<Avalonia.Media.TextAlignment> signal, Action<Avalonia.Media.TextAlignment>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.TextBlock.TextAlignmentProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_TextAlignment<T>(this T control, Avalonia.Media.TextAlignment value, Action<Avalonia.Media.TextAlignment>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.TextBlock.TextAlignmentProperty!, onChanged);


 // TextWrapping

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T TextBlock_TextWrapping<T>(this T control, Func<Avalonia.Media.TextWrapping> func, Action<Avalonia.Media.TextWrapping>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.TextBlock.TextWrappingProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T TextBlock_TextWrapping<T>(this T control, ISignal<Avalonia.Media.TextWrapping> signal, Action<Avalonia.Media.TextWrapping>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.TextBlock.TextWrappingProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_TextWrapping<T>(this T control, Avalonia.Media.TextWrapping value, Action<Avalonia.Media.TextWrapping>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.TextBlock.TextWrappingProperty!, onChanged);


 // TextTrimming

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T TextBlock_TextTrimming<T>(this T control, Func<Avalonia.Media.TextTrimming> func, Action<Avalonia.Media.TextTrimming>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.TextBlock.TextTrimmingProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T TextBlock_TextTrimming<T>(this T control, ISignal<Avalonia.Media.TextTrimming> signal, Action<Avalonia.Media.TextTrimming>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.TextBlock.TextTrimmingProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T TextBlock_TextTrimming<T>(this T control, Avalonia.Media.TextTrimming value, Action<Avalonia.Media.TextTrimming>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.TextBlock.TextTrimmingProperty!, onChanged);



//================= Styles ======================//
 // Background

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.BackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.BackgroundProperty, binding);


 // Padding

/*ValueStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.PaddingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.PaddingProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.TextBlock 
   => style._addSetter(Avalonia.Controls.TextBlock.PaddingProperty, new Avalonia.Thickness(uniformLength));public static Style<T> Padding<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.TextBlock 
   => style._addSetter(Avalonia.Controls.TextBlock.PaddingProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> Padding<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.TextBlock 
   => style._addSetter(Avalonia.Controls.TextBlock.PaddingProperty, new Avalonia.Thickness(left, top, right, bottom));


 // FontFamily

/*ValueStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontFamilyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFamily<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontFamilyProperty, binding);


 // FontSize

/*ValueStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontSizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontSizeProperty, binding);


 // FontStyle

/*ValueStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontStyleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontStyleProperty, binding);


 // FontWeight

/*ValueStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontWeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontWeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontWeightProperty, binding);


 // FontStretch

/*ValueStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, Avalonia.Media.FontStretch value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontStretchProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontStretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontStretchProperty, binding);


 // Foreground

/*ValueStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.ForegroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Foreground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.ForegroundProperty, binding);


 // BaselineOffset

/*ValueStyleSetterGenerator*/
public static Style<T> BaselineOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.BaselineOffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BaselineOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.BaselineOffsetProperty, binding);


 // LineHeight

/*ValueStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.LineHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.LineHeightProperty, binding);


 // LineSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> LineSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.LineSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LineSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.LineSpacingProperty, binding);


 // LetterSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.LetterSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.LetterSpacingProperty, binding);


 // MaxLines

/*ValueStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.MaxLinesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.MaxLinesProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextProperty, binding);


 // TextAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextAlignmentProperty, binding);


 // TextWrapping

/*ValueStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextWrappingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextWrappingProperty, binding);


 // TextTrimming

/*ValueStyleSetterGenerator*/
public static Style<T> TextTrimming<T>(this Style<T> style, Avalonia.Media.TextTrimming value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextTrimmingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextTrimming<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextTrimmingProperty, binding);


 // TextDecorations

/*ValueStyleSetterGenerator*/
public static Style<T> TextDecorations<T>(this Style<T> style, Avalonia.Media.TextDecorationCollection value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextDecorationsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextDecorations<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.TextDecorationsProperty, binding);


 // FontFeatures

/*ValueStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, Avalonia.Media.FontFeatureCollection value) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontFeaturesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FontFeatures<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBlock 
=> style._addSetter(Avalonia.Controls.TextBlock.FontFeaturesProperty, binding);



}
