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
public static partial class GridSplitter_MarkupExtensions
{
//================= Properties ======================//
 // ResizeDirection

/*ValueSetterGenerator*/
public static T ResizeDirection<T>(this T control, Avalonia.Controls.GridResizeDirection value) where T : Avalonia.Controls.GridSplitter 
=> control._set(() => control.ResizeDirection = value!);

/*BindFromFuncSetterGenerator*/
public static T ResizeDirection<T>(this T control, Func<Avalonia.Controls.GridResizeDirection> func, Action<Avalonia.Controls.GridResizeDirection>? onChanged = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(func, Avalonia.Controls.GridSplitter.ResizeDirectionProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ResizeDirection<T>(this T control, ISignal<Avalonia.Controls.GridResizeDirection> signal, Action<Avalonia.Controls.GridResizeDirection>? onChanged = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(signal, Avalonia.Controls.GridSplitter.ResizeDirectionProperty!, onChanged);


 // ResizeBehavior

/*ValueSetterGenerator*/
public static T ResizeBehavior<T>(this T control, Avalonia.Controls.GridResizeBehavior value) where T : Avalonia.Controls.GridSplitter 
=> control._set(() => control.ResizeBehavior = value!);

/*BindFromFuncSetterGenerator*/
public static T ResizeBehavior<T>(this T control, Func<Avalonia.Controls.GridResizeBehavior> func, Action<Avalonia.Controls.GridResizeBehavior>? onChanged = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(func, Avalonia.Controls.GridSplitter.ResizeBehaviorProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ResizeBehavior<T>(this T control, ISignal<Avalonia.Controls.GridResizeBehavior> signal, Action<Avalonia.Controls.GridResizeBehavior>? onChanged = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(signal, Avalonia.Controls.GridSplitter.ResizeBehaviorProperty!, onChanged);


 // ShowsPreview

/*ValueSetterGenerator*/
public static T ShowsPreview<T>(this T control, System.Boolean value) where T : Avalonia.Controls.GridSplitter 
=> control._set(() => control.ShowsPreview = value!);

/*BindFromFuncSetterGenerator*/
public static T ShowsPreview<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(func, Avalonia.Controls.GridSplitter.ShowsPreviewProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ShowsPreview<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(signal, Avalonia.Controls.GridSplitter.ShowsPreviewProperty!, onChanged);


 // KeyboardIncrement

/*ValueSetterGenerator*/
public static T KeyboardIncrement<T>(this T control, System.Double value) where T : Avalonia.Controls.GridSplitter 
=> control._set(() => control.KeyboardIncrement = value!);

/*BindFromFuncSetterGenerator*/
public static T KeyboardIncrement<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(func, Avalonia.Controls.GridSplitter.KeyboardIncrementProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T KeyboardIncrement<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(signal, Avalonia.Controls.GridSplitter.KeyboardIncrementProperty!, onChanged);


 // DragIncrement

/*ValueSetterGenerator*/
public static T DragIncrement<T>(this T control, System.Double value) where T : Avalonia.Controls.GridSplitter 
=> control._set(() => control.DragIncrement = value!);

/*BindFromFuncSetterGenerator*/
public static T DragIncrement<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(func, Avalonia.Controls.GridSplitter.DragIncrementProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T DragIncrement<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(signal, Avalonia.Controls.GridSplitter.DragIncrementProperty!, onChanged);


 // PreviewContent

/*ValueSetterGenerator*/
public static T PreviewContent<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.GridSplitter 
=> control._set(() => control.PreviewContent = value!);

/*BindFromFuncSetterGenerator*/
public static T PreviewContent<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>? onChanged = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(func, Avalonia.Controls.GridSplitter.PreviewContentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PreviewContent<T>(this T control, ISignal<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> signal, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>? onChanged = null) where T : Avalonia.Controls.GridSplitter 
   => control._set(signal, Avalonia.Controls.GridSplitter.PreviewContentProperty!, onChanged);



//================= Styles ======================//
 // ResizeDirection

/*ValueStyleSetterGenerator*/
public static Style<T> ResizeDirection<T>(this Style<T> style, Avalonia.Controls.GridResizeDirection value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ResizeDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ResizeDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ResizeDirectionProperty, binding);


 // ResizeBehavior

/*ValueStyleSetterGenerator*/
public static Style<T> ResizeBehavior<T>(this Style<T> style, Avalonia.Controls.GridResizeBehavior value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ResizeBehavior<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty, binding);


 // ShowsPreview

/*ValueStyleSetterGenerator*/
public static Style<T> ShowsPreview<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ShowsPreviewProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowsPreview<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.ShowsPreviewProperty, binding);


 // KeyboardIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> KeyboardIncrement<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> KeyboardIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty, binding);


 // DragIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> DragIncrement<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.DragIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DragIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.DragIncrementProperty, binding);


 // PreviewContent

/*ValueStyleSetterGenerator*/
public static Style<T> PreviewContent<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.PreviewContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PreviewContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.GridSplitter 
=> style._addSetter(Avalonia.Controls.GridSplitter.PreviewContentProperty, binding);



}
