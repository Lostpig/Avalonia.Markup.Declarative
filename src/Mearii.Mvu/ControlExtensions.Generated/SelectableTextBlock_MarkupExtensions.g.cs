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
public static partial class SelectableTextBlock_MarkupExtensions
{
//================= Properties ======================//
 // SelectionStart

/*ValueSetterGenerator*/
public static T SelectionStart<T>(this T control, System.Int32 value) where T : Avalonia.Controls.SelectableTextBlock 
=> control._set(() => control.SelectionStart = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectionStart<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(func, Avalonia.Controls.SelectableTextBlock.SelectionStartProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectionStart<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(signal, Avalonia.Controls.SelectableTextBlock.SelectionStartProperty!, onChanged);


 // SelectionEnd

/*ValueSetterGenerator*/
public static T SelectionEnd<T>(this T control, System.Int32 value) where T : Avalonia.Controls.SelectableTextBlock 
=> control._set(() => control.SelectionEnd = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectionEnd<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(func, Avalonia.Controls.SelectableTextBlock.SelectionEndProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectionEnd<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(signal, Avalonia.Controls.SelectableTextBlock.SelectionEndProperty!, onChanged);


 // SelectionBrush

/*ValueSetterGenerator*/
public static T SelectionBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.SelectableTextBlock 
=> control._set(() => control.SelectionBrush = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectionBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(func, Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectionBrush<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(signal, Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty!, onChanged);


 // SelectionForegroundBrush

/*ValueSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.SelectableTextBlock 
=> control._set(() => control.SelectionForegroundBrush = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(func, Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(signal, Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty!, onChanged);



//================= Events ======================//
 // CopyingToClipboard

/*ActionToEventGenerator*/
public static T OnCopyingToClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SelectableTextBlock 
{
  control.AddHandler(Avalonia.Controls.SelectableTextBlock.CopyingToClipboardEvent, (_, args) => action(args), routes ?? Avalonia.Controls.SelectableTextBlock.CopyingToClipboardEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // SelectionStart

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty, binding);


 // SelectionEnd

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty, binding);


 // SelectionBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty, binding);


 // SelectionForegroundBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty, binding);



}
