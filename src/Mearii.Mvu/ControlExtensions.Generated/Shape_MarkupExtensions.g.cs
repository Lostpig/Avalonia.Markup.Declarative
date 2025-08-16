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
public static partial class Shape_MarkupExtensions
{
//================= Properties ======================//
 // Fill

/*ValueSetterGenerator*/
public static T Fill<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Shapes.Shape 
=> control._set(() => control.Fill = value!);

/*BindFromFuncSetterGenerator*/
public static T Fill<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(func, Avalonia.Controls.Shapes.Shape.FillProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Fill<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(signal, Avalonia.Controls.Shapes.Shape.FillProperty!, onChanged);


 // Stretch

/*ValueSetterGenerator*/
public static T Stretch<T>(this T control, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Shapes.Shape 
=> control._set(() => control.Stretch = value!);

/*BindFromFuncSetterGenerator*/
public static T Stretch<T>(this T control, Func<Avalonia.Media.Stretch> func, Action<Avalonia.Media.Stretch>? onChanged = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(func, Avalonia.Controls.Shapes.Shape.StretchProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Stretch<T>(this T control, ISignal<Avalonia.Media.Stretch> signal, Action<Avalonia.Media.Stretch>? onChanged = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(signal, Avalonia.Controls.Shapes.Shape.StretchProperty!, onChanged);


 // Stroke

/*ValueSetterGenerator*/
public static T Stroke<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Shapes.Shape 
=> control._set(() => control.Stroke = value!);

/*BindFromFuncSetterGenerator*/
public static T Stroke<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(func, Avalonia.Controls.Shapes.Shape.StrokeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Stroke<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(signal, Avalonia.Controls.Shapes.Shape.StrokeProperty!, onChanged);


 // StrokeDashArray

/*ValueSetterGenerator*/
public static T StrokeDashArray<T>(this T control, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.Shapes.Shape 
=> control._set(() => control.StrokeDashArray = value!);

/*BindFromFuncSetterGenerator*/
public static T StrokeDashArray<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(func, Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T StrokeDashArray<T>(this T control, ISignal<Avalonia.Collections.AvaloniaList<System.Double>> signal, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(signal, Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty!, onChanged);


 // StrokeDashOffset

/*ValueSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.Shapes.Shape 
=> control._set(() => control.StrokeDashOffset = value!);

/*BindFromFuncSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(func, Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(signal, Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty!, onChanged);


 // StrokeThickness

/*ValueSetterGenerator*/
public static T StrokeThickness<T>(this T control, System.Double value) where T : Avalonia.Controls.Shapes.Shape 
=> control._set(() => control.StrokeThickness = value!);

/*BindFromFuncSetterGenerator*/
public static T StrokeThickness<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(func, Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T StrokeThickness<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(signal, Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty!, onChanged);


 // StrokeLineCap

/*ValueSetterGenerator*/
public static T StrokeLineCap<T>(this T control, Avalonia.Media.PenLineCap value) where T : Avalonia.Controls.Shapes.Shape 
=> control._set(() => control.StrokeLineCap = value!);

/*BindFromFuncSetterGenerator*/
public static T StrokeLineCap<T>(this T control, Func<Avalonia.Media.PenLineCap> func, Action<Avalonia.Media.PenLineCap>? onChanged = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(func, Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T StrokeLineCap<T>(this T control, ISignal<Avalonia.Media.PenLineCap> signal, Action<Avalonia.Media.PenLineCap>? onChanged = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(signal, Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty!, onChanged);


 // StrokeJoin

/*ValueSetterGenerator*/
public static T StrokeJoin<T>(this T control, Avalonia.Media.PenLineJoin value) where T : Avalonia.Controls.Shapes.Shape 
=> control._set(() => control.StrokeJoin = value!);

/*BindFromFuncSetterGenerator*/
public static T StrokeJoin<T>(this T control, Func<Avalonia.Media.PenLineJoin> func, Action<Avalonia.Media.PenLineJoin>? onChanged = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(func, Avalonia.Controls.Shapes.Shape.StrokeJoinProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T StrokeJoin<T>(this T control, ISignal<Avalonia.Media.PenLineJoin> signal, Action<Avalonia.Media.PenLineJoin>? onChanged = null) where T : Avalonia.Controls.Shapes.Shape 
   => control._set(signal, Avalonia.Controls.Shapes.Shape.StrokeJoinProperty!, onChanged);



//================= Styles ======================//
 // Fill

/*ValueStyleSetterGenerator*/
public static Style<T> Fill<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.FillProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Fill<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.FillProperty, binding);


 // Stretch

/*ValueStyleSetterGenerator*/
public static Style<T> Stretch<T>(this Style<T> style, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StretchProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Stretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StretchProperty, binding);


 // Stroke

/*ValueStyleSetterGenerator*/
public static Style<T> Stroke<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Stroke<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeProperty, binding);


 // StrokeDashArray

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeDashArray<T>(this Style<T> style, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeDashArray<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty, binding);


 // StrokeDashOffset

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeDashOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeDashOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty, binding);


 // StrokeThickness

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeThickness<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeThickness<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty, binding);


 // StrokeLineCap

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeLineCap<T>(this Style<T> style, Avalonia.Media.PenLineCap value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeLineCap<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty, binding);


 // StrokeJoin

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeJoin<T>(this Style<T> style, Avalonia.Media.PenLineJoin value) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeJoin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape 
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty, binding);



}
