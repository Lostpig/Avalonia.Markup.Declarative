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
public static partial class TextPresenter_MarkupExtensions
{
//================= Properties ======================//
 // ShowSelectionHighlight

/*ValueSetterGenerator*/
public static T ShowSelectionHighlight<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._set(() => control.ShowSelectionHighlight = value!);

/*BindFromFuncSetterGenerator*/
public static T ShowSelectionHighlight<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(func, Avalonia.Controls.Presenters.TextPresenter.ShowSelectionHighlightProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ShowSelectionHighlight<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.TextPresenter.ShowSelectionHighlightProperty!, onChanged);


 // CaretIndex

/*ValueSetterGenerator*/
public static T CaretIndex<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._set(() => control.CaretIndex = value!);

/*BindFromFuncSetterGenerator*/
public static T CaretIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(func, Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CaretIndex<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty!, onChanged);


 // RevealPassword

/*ValueSetterGenerator*/
public static T RevealPassword<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._set(() => control.RevealPassword = value!);

/*BindFromFuncSetterGenerator*/
public static T RevealPassword<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(func, Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T RevealPassword<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty!, onChanged);


 // PasswordChar

/*ValueSetterGenerator*/
public static T PasswordChar<T>(this T control, System.Char value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._set(() => control.PasswordChar = value!);

/*BindFromFuncSetterGenerator*/
public static T PasswordChar<T>(this T control, Func<System.Char> func, Action<System.Char>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(func, Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PasswordChar<T>(this T control, ISignal<System.Char> signal, Action<System.Char>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty!, onChanged);


 // SelectionBrush

/*ValueSetterGenerator*/
public static T SelectionBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._set(() => control.SelectionBrush = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectionBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(func, Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectionBrush<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty!, onChanged);


 // SelectionForegroundBrush

/*ValueSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._set(() => control.SelectionForegroundBrush = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(func, Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty!, onChanged);


 // CaretBrush

/*ValueSetterGenerator*/
public static T CaretBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._set(() => control.CaretBrush = value!);

/*BindFromFuncSetterGenerator*/
public static T CaretBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(func, Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CaretBrush<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty!, onChanged);


 // CaretBlinkInterval

/*ValueSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, System.TimeSpan value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._set(() => control.CaretBlinkInterval = value!);

/*BindFromFuncSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(func, Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, ISignal<System.TimeSpan> signal, Action<System.TimeSpan>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty!, onChanged);


 // SelectionStart

/*ValueSetterGenerator*/
public static T SelectionStart<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._set(() => control.SelectionStart = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectionStart<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(func, Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectionStart<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty!, onChanged);


 // SelectionEnd

/*ValueSetterGenerator*/
public static T SelectionEnd<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._set(() => control.SelectionEnd = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectionEnd<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(func, Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectionEnd<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty!, onChanged);


 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._set(() => control.Text = value!);

/*BindFromFuncSetterGenerator*/
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(func, Avalonia.Controls.Presenters.TextPresenter.TextProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Text<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.TextPresenter.TextProperty!, onChanged);


 // PreeditText

/*ValueSetterGenerator*/
public static T PreeditText<T>(this T control, System.String value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._set(() => control.PreeditText = value!);

/*BindFromFuncSetterGenerator*/
public static T PreeditText<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(func, Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PreeditText<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty!, onChanged);


 // PreeditTextCursorPosition

/*ValueSetterGenerator*/
public static T PreeditTextCursorPosition<T>(this T control, System.Nullable<System.Int32> value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._set(() => control.PreeditTextCursorPosition = value!);

/*BindFromFuncSetterGenerator*/
public static T PreeditTextCursorPosition<T>(this T control, Func<System.Nullable<System.Int32>> func, Action<System.Nullable<System.Int32>>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(func, Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PreeditTextCursorPosition<T>(this T control, ISignal<System.Nullable<System.Int32>> signal, Action<System.Nullable<System.Int32>>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty!, onChanged);


 // TextAlignment

/*ValueSetterGenerator*/
public static T TextAlignment<T>(this T control, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._set(() => control.TextAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func, Action<Avalonia.Media.TextAlignment>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(func, Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TextAlignment<T>(this T control, ISignal<Avalonia.Media.TextAlignment> signal, Action<Avalonia.Media.TextAlignment>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty!, onChanged);


 // TextWrapping

/*ValueSetterGenerator*/
public static T TextWrapping<T>(this T control, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._set(() => control.TextWrapping = value!);

/*BindFromFuncSetterGenerator*/
public static T TextWrapping<T>(this T control, Func<Avalonia.Media.TextWrapping> func, Action<Avalonia.Media.TextWrapping>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(func, Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TextWrapping<T>(this T control, ISignal<Avalonia.Media.TextWrapping> signal, Action<Avalonia.Media.TextWrapping>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty!, onChanged);


 // LineHeight

/*ValueSetterGenerator*/
public static T LineHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._set(() => control.LineHeight = value!);

/*BindFromFuncSetterGenerator*/
public static T LineHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(func, Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T LineHeight<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty!, onChanged);


 // LetterSpacing

/*ValueSetterGenerator*/
public static T LetterSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._set(() => control.LetterSpacing = value!);

/*BindFromFuncSetterGenerator*/
public static T LetterSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(func, Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T LetterSpacing<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty!, onChanged);


 // Background

/*ValueSetterGenerator*/
public static T Background<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> control._set(() => control.Background = value!);

/*BindFromFuncSetterGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(func, Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Background<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Presenters.TextPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty!, onChanged);



//================= Events ======================//
 // CaretBoundsChanged

/*ActionToEventGenerator*/
public static T OnCaretBoundsChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Presenters.TextPresenter  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.CaretBoundsChanged += h);



//================= Styles ======================//
 // ShowSelectionHighlight

/*ValueStyleSetterGenerator*/
public static Style<T> ShowSelectionHighlight<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.ShowSelectionHighlightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowSelectionHighlight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.ShowSelectionHighlightProperty, binding);


 // CaretIndex

/*ValueStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretIndexProperty, binding);


 // RevealPassword

/*ValueStyleSetterGenerator*/
public static Style<T> RevealPassword<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RevealPassword<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.RevealPasswordProperty, binding);


 // PasswordChar

/*ValueStyleSetterGenerator*/
public static Style<T> PasswordChar<T>(this Style<T> style, System.Char value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PasswordChar<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PasswordCharProperty, binding);


 // SelectionBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionBrushProperty, binding);


 // SelectionForegroundBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionForegroundBrushProperty, binding);


 // CaretBrush

/*ValueStyleSetterGenerator*/
public static Style<T> CaretBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretBrushProperty, binding);


 // CaretBlinkInterval

/*ValueStyleSetterGenerator*/
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.CaretBlinkIntervalProperty, binding);


 // SelectionStart

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionStartProperty, binding);


 // SelectionEnd

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.SelectionEndProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextProperty, binding);


 // PreeditText

/*ValueStyleSetterGenerator*/
public static Style<T> PreeditText<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PreeditText<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PreeditTextProperty, binding);


 // PreeditTextCursorPosition

/*ValueStyleSetterGenerator*/
public static Style<T> PreeditTextCursorPosition<T>(this Style<T> style, System.Nullable<System.Int32> value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PreeditTextCursorPosition<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.PreeditTextCursorPositionProperty, binding);


 // TextAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextAlignmentProperty, binding);


 // TextWrapping

/*ValueStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.TextWrappingProperty, binding);


 // LineHeight

/*ValueStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.LineHeightProperty, binding);


 // LetterSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.LetterSpacingProperty, binding);


 // Background

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.TextPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.TextPresenter.BackgroundProperty, binding);



}
