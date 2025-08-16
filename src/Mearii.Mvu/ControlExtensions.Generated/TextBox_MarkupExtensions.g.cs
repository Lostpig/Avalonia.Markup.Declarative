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
public static partial class TextBox_MarkupExtensions
{
//================= Properties ======================//
 // IsInactiveSelectionHighlightEnabled

/*ValueSetterGenerator*/
public static T IsInactiveSelectionHighlightEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.IsInactiveSelectionHighlightEnabled = value!);

/*BindFromFuncSetterGenerator*/
public static T IsInactiveSelectionHighlightEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsInactiveSelectionHighlightEnabled<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty!, onChanged);


 // ClearSelectionOnLostFocus

/*ValueSetterGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.ClearSelectionOnLostFocus = value!);

/*BindFromFuncSetterGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ClearSelectionOnLostFocus<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty!, onChanged);


 // AcceptsReturn

/*ValueSetterGenerator*/
public static T AcceptsReturn<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.AcceptsReturn = value!);

/*BindFromFuncSetterGenerator*/
public static T AcceptsReturn<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.AcceptsReturnProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T AcceptsReturn<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.AcceptsReturnProperty!, onChanged);


 // AcceptsTab

/*ValueSetterGenerator*/
public static T AcceptsTab<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.AcceptsTab = value!);

/*BindFromFuncSetterGenerator*/
public static T AcceptsTab<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.AcceptsTabProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T AcceptsTab<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.AcceptsTabProperty!, onChanged);


 // CaretIndex

/*ValueSetterGenerator*/
public static T CaretIndex<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.CaretIndex = value!);

/*BindFromFuncSetterGenerator*/
public static T CaretIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.CaretIndexProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CaretIndex<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.CaretIndexProperty!, onChanged);


 // IsReadOnly

/*ValueSetterGenerator*/
public static T IsReadOnly<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.IsReadOnly = value!);

/*BindFromFuncSetterGenerator*/
public static T IsReadOnly<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.IsReadOnlyProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsReadOnly<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.IsReadOnlyProperty!, onChanged);


 // PasswordChar

/*ValueSetterGenerator*/
public static T PasswordChar<T>(this T control, System.Char value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.PasswordChar = value!);

/*BindFromFuncSetterGenerator*/
public static T PasswordChar<T>(this T control, Func<System.Char> func, Action<System.Char>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.PasswordCharProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PasswordChar<T>(this T control, ISignal<System.Char> signal, Action<System.Char>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.PasswordCharProperty!, onChanged);


 // SelectionBrush

/*ValueSetterGenerator*/
public static T SelectionBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.SelectionBrush = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectionBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.SelectionBrushProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectionBrush<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.SelectionBrushProperty!, onChanged);


 // SelectionForegroundBrush

/*ValueSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.SelectionForegroundBrush = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.SelectionForegroundBrushProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.SelectionForegroundBrushProperty!, onChanged);


 // CaretBrush

/*ValueSetterGenerator*/
public static T CaretBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.CaretBrush = value!);

/*BindFromFuncSetterGenerator*/
public static T CaretBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.CaretBrushProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CaretBrush<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.CaretBrushProperty!, onChanged);


 // CaretBlinkInterval

/*ValueSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, System.TimeSpan value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.CaretBlinkInterval = value!);

/*BindFromFuncSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.CaretBlinkIntervalProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CaretBlinkInterval<T>(this T control, ISignal<System.TimeSpan> signal, Action<System.TimeSpan>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.CaretBlinkIntervalProperty!, onChanged);


 // SelectionStart

/*ValueSetterGenerator*/
public static T SelectionStart<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.SelectionStart = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectionStart<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.SelectionStartProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectionStart<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.SelectionStartProperty!, onChanged);


 // SelectionEnd

/*ValueSetterGenerator*/
public static T SelectionEnd<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.SelectionEnd = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectionEnd<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.SelectionEndProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectionEnd<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.SelectionEndProperty!, onChanged);


 // MaxLength

/*ValueSetterGenerator*/
public static T MaxLength<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.MaxLength = value!);

/*BindFromFuncSetterGenerator*/
public static T MaxLength<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.MaxLengthProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MaxLength<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.MaxLengthProperty!, onChanged);


 // MaxLines

/*ValueSetterGenerator*/
public static T MaxLines<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.MaxLines = value!);

/*BindFromFuncSetterGenerator*/
public static T MaxLines<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.MaxLinesProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MaxLines<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.MaxLinesProperty!, onChanged);


 // MinLines

/*ValueSetterGenerator*/
public static T MinLines<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.MinLines = value!);

/*BindFromFuncSetterGenerator*/
public static T MinLines<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.MinLinesProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MinLines<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.MinLinesProperty!, onChanged);


 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.Text = value!);

/*BindFromFuncSetterGenerator*/
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.TextProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Text<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.TextProperty!, onChanged);


 // TextAlignment

/*ValueSetterGenerator*/
public static T TextAlignment<T>(this T control, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.TextAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func, Action<Avalonia.Media.TextAlignment>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.TextAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TextAlignment<T>(this T control, ISignal<Avalonia.Media.TextAlignment> signal, Action<Avalonia.Media.TextAlignment>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.TextAlignmentProperty!, onChanged);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.HorizontalContentAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, ISignal<Avalonia.Layout.HorizontalAlignment> signal, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty!, onChanged);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.VerticalContentAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.VerticalContentAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, ISignal<Avalonia.Layout.VerticalAlignment> signal, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.VerticalContentAlignmentProperty!, onChanged);


 // TextWrapping

/*ValueSetterGenerator*/
public static T TextWrapping<T>(this T control, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.TextWrapping = value!);

/*BindFromFuncSetterGenerator*/
public static T TextWrapping<T>(this T control, Func<Avalonia.Media.TextWrapping> func, Action<Avalonia.Media.TextWrapping>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.TextWrappingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TextWrapping<T>(this T control, ISignal<Avalonia.Media.TextWrapping> signal, Action<Avalonia.Media.TextWrapping>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.TextWrappingProperty!, onChanged);


 // LineHeight

/*ValueSetterGenerator*/
public static T LineHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.LineHeight = value!);

/*BindFromFuncSetterGenerator*/
public static T LineHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.LineHeightProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T LineHeight<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.LineHeightProperty!, onChanged);


 // LetterSpacing

/*ValueSetterGenerator*/
public static T LetterSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.LetterSpacing = value!);

/*BindFromFuncSetterGenerator*/
public static T LetterSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.LetterSpacingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T LetterSpacing<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.LetterSpacingProperty!, onChanged);


 // Watermark

/*ValueSetterGenerator*/
public static T Watermark<T>(this T control, System.String value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.Watermark = value!);

/*BindFromFuncSetterGenerator*/
public static T Watermark<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.WatermarkProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Watermark<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.WatermarkProperty!, onChanged);


 // UseFloatingWatermark

/*ValueSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.UseFloatingWatermark = value!);

/*BindFromFuncSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.UseFloatingWatermarkProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.UseFloatingWatermarkProperty!, onChanged);


 // NewLine

/*ValueSetterGenerator*/
public static T NewLine<T>(this T control, System.String value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.NewLine = value!);

/*BindFromFuncSetterGenerator*/
public static T NewLine<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.NewLineProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T NewLine<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.NewLineProperty!, onChanged);


 // InnerLeftContent

/*ValueSetterGenerator*/
public static T InnerLeftContent<T>(this T control, System.Object value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.InnerLeftContent = value!);

/*BindFromFuncSetterGenerator*/
public static T InnerLeftContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.InnerLeftContentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T InnerLeftContent<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.InnerLeftContentProperty!, onChanged);


 // InnerRightContent

/*ValueSetterGenerator*/
public static T InnerRightContent<T>(this T control, System.Object value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.InnerRightContent = value!);

/*BindFromFuncSetterGenerator*/
public static T InnerRightContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.InnerRightContentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T InnerRightContent<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.InnerRightContentProperty!, onChanged);


 // RevealPassword

/*ValueSetterGenerator*/
public static T RevealPassword<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.RevealPassword = value!);

/*BindFromFuncSetterGenerator*/
public static T RevealPassword<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.RevealPasswordProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T RevealPassword<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.RevealPasswordProperty!, onChanged);


 // IsUndoEnabled

/*ValueSetterGenerator*/
public static T IsUndoEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.IsUndoEnabled = value!);

/*BindFromFuncSetterGenerator*/
public static T IsUndoEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.IsUndoEnabledProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsUndoEnabled<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.IsUndoEnabledProperty!, onChanged);


 // UndoLimit

/*ValueSetterGenerator*/
public static T UndoLimit<T>(this T control, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> control._set(() => control.UndoLimit = value!);

/*BindFromFuncSetterGenerator*/
public static T UndoLimit<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(func, Avalonia.Controls.TextBox.UndoLimitProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T UndoLimit<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.TextBox 
   => control._set(signal, Avalonia.Controls.TextBox.UndoLimitProperty!, onChanged);



//================= Events ======================//
 // CopyingToClipboard

/*ActionToEventGenerator*/
public static T OnCopyingToClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.CopyingToClipboardEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TextBox.CopyingToClipboardEvent.RoutingStrategies);
  return control;
}



 // CuttingToClipboard

/*ActionToEventGenerator*/
public static T OnCuttingToClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.CuttingToClipboardEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TextBox.CuttingToClipboardEvent.RoutingStrategies);
  return control;
}



 // PastingFromClipboard

/*ActionToEventGenerator*/
public static T OnPastingFromClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.PastingFromClipboardEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TextBox.PastingFromClipboardEvent.RoutingStrategies);
  return control;
}



 // TextChanged

/*ActionToEventGenerator*/
public static T OnTextChanged<T>(this T control, Action<Avalonia.Controls.TextChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.TextChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TextBox.TextChangedEvent.RoutingStrategies);
  return control;
}



 // TextChanging

/*ActionToEventGenerator*/
public static T OnTextChanging<T>(this T control, Action<Avalonia.Controls.TextChangingEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TextBox 
{
  control.AddHandler(Avalonia.Controls.TextBox.TextChangingEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TextBox.TextChangingEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // IsInactiveSelectionHighlightEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsInactiveSelectionHighlightEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsInactiveSelectionHighlightEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty, binding);


 // ClearSelectionOnLostFocus

/*ValueStyleSetterGenerator*/
public static Style<T> ClearSelectionOnLostFocus<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClearSelectionOnLostFocus<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.ClearSelectionOnLostFocusProperty, binding);


 // AcceptsReturn

/*ValueStyleSetterGenerator*/
public static Style<T> AcceptsReturn<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsReturnProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AcceptsReturn<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsReturnProperty, binding);


 // AcceptsTab

/*ValueStyleSetterGenerator*/
public static Style<T> AcceptsTab<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsTabProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AcceptsTab<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.AcceptsTabProperty, binding);


 // CaretIndex

/*ValueStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretIndexProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretIndexProperty, binding);


 // IsReadOnly

/*ValueStyleSetterGenerator*/
public static Style<T> IsReadOnly<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsReadOnlyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsReadOnly<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsReadOnlyProperty, binding);


 // PasswordChar

/*ValueStyleSetterGenerator*/
public static Style<T> PasswordChar<T>(this Style<T> style, System.Char value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.PasswordCharProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PasswordChar<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.PasswordCharProperty, binding);


 // SelectionBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionBrushProperty, binding);


 // SelectionForegroundBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionForegroundBrushProperty, binding);


 // CaretBrush

/*ValueStyleSetterGenerator*/
public static Style<T> CaretBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretBrushProperty, binding);


 // CaretBlinkInterval

/*ValueStyleSetterGenerator*/
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretBlinkInterval<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.CaretBlinkIntervalProperty, binding);


 // SelectionStart

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionStartProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionStartProperty, binding);


 // SelectionEnd

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionEndProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.SelectionEndProperty, binding);


 // MaxLength

/*ValueStyleSetterGenerator*/
public static Style<T> MaxLength<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MaxLengthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MaxLengthProperty, binding);


 // MaxLines

/*ValueStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MaxLinesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MaxLinesProperty, binding);


 // MinLines

/*ValueStyleSetterGenerator*/
public static Style<T> MinLines<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MinLinesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.MinLinesProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextProperty, binding);


 // TextAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextAlignmentProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.VerticalContentAlignmentProperty, binding);


 // TextWrapping

/*ValueStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextWrappingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextWrapping<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.TextWrappingProperty, binding);


 // LineHeight

/*ValueStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.LineHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LineHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.LineHeightProperty, binding);


 // LetterSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.LetterSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LetterSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.LetterSpacingProperty, binding);


 // Watermark

/*ValueStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.WatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.WatermarkProperty, binding);


 // UseFloatingWatermark

/*ValueStyleSetterGenerator*/
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.UseFloatingWatermarkProperty, binding);


 // NewLine

/*ValueStyleSetterGenerator*/
public static Style<T> NewLine<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.NewLineProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> NewLine<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.NewLineProperty, binding);


 // InnerLeftContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.InnerLeftContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.InnerLeftContentProperty, binding);


 // InnerRightContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.InnerRightContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.InnerRightContentProperty, binding);


 // RevealPassword

/*ValueStyleSetterGenerator*/
public static Style<T> RevealPassword<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.RevealPasswordProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RevealPassword<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.RevealPasswordProperty, binding);


 // IsUndoEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsUndoEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsUndoEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsUndoEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.IsUndoEnabledProperty, binding);


 // UndoLimit

/*ValueStyleSetterGenerator*/
public static Style<T> UndoLimit<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.UndoLimitProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UndoLimit<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TextBox 
=> style._addSetter(Avalonia.Controls.TextBox.UndoLimitProperty, binding);



}
