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
public static partial class TextDecoration_MarkupExtensions
{
//================= Properties ======================//
 // Location

/*ValueSetterGenerator*/
public static T Location<T>(this T control, Avalonia.Media.TextDecorationLocation value) where T : Avalonia.Media.TextDecoration 
=> control._set(() => control.Location = value!);

/*BindFromFuncSetterGenerator*/
public static T Location<T>(this T control, Func<Avalonia.Media.TextDecorationLocation> func, Action<Avalonia.Media.TextDecorationLocation>? onChanged = null) where T : Avalonia.Media.TextDecoration 
   => control._set(func, Avalonia.Media.TextDecoration.LocationProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Location<T>(this T control, ISignal<Avalonia.Media.TextDecorationLocation> signal, Action<Avalonia.Media.TextDecorationLocation>? onChanged = null) where T : Avalonia.Media.TextDecoration 
   => control._set(signal, Avalonia.Media.TextDecoration.LocationProperty!, onChanged);


 // Stroke

/*ValueSetterGenerator*/
public static T Stroke<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Media.TextDecoration 
=> control._set(() => control.Stroke = value!);

/*BindFromFuncSetterGenerator*/
public static T Stroke<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Media.TextDecoration 
   => control._set(func, Avalonia.Media.TextDecoration.StrokeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Stroke<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Media.TextDecoration 
   => control._set(signal, Avalonia.Media.TextDecoration.StrokeProperty!, onChanged);


 // StrokeThicknessUnit

/*ValueSetterGenerator*/
public static T StrokeThicknessUnit<T>(this T control, Avalonia.Media.TextDecorationUnit value) where T : Avalonia.Media.TextDecoration 
=> control._set(() => control.StrokeThicknessUnit = value!);

/*BindFromFuncSetterGenerator*/
public static T StrokeThicknessUnit<T>(this T control, Func<Avalonia.Media.TextDecorationUnit> func, Action<Avalonia.Media.TextDecorationUnit>? onChanged = null) where T : Avalonia.Media.TextDecoration 
   => control._set(func, Avalonia.Media.TextDecoration.StrokeThicknessUnitProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T StrokeThicknessUnit<T>(this T control, ISignal<Avalonia.Media.TextDecorationUnit> signal, Action<Avalonia.Media.TextDecorationUnit>? onChanged = null) where T : Avalonia.Media.TextDecoration 
   => control._set(signal, Avalonia.Media.TextDecoration.StrokeThicknessUnitProperty!, onChanged);


 // StrokeDashArray

/*ValueSetterGenerator*/
public static T StrokeDashArray<T>(this T control, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Media.TextDecoration 
=> control._set(() => control.StrokeDashArray = value!);

/*BindFromFuncSetterGenerator*/
public static T StrokeDashArray<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null) where T : Avalonia.Media.TextDecoration 
   => control._set(func, Avalonia.Media.TextDecoration.StrokeDashArrayProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T StrokeDashArray<T>(this T control, ISignal<Avalonia.Collections.AvaloniaList<System.Double>> signal, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null) where T : Avalonia.Media.TextDecoration 
   => control._set(signal, Avalonia.Media.TextDecoration.StrokeDashArrayProperty!, onChanged);


 // StrokeDashOffset

/*ValueSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, System.Double value) where T : Avalonia.Media.TextDecoration 
=> control._set(() => control.StrokeDashOffset = value!);

/*BindFromFuncSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Media.TextDecoration 
   => control._set(func, Avalonia.Media.TextDecoration.StrokeDashOffsetProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T StrokeDashOffset<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Media.TextDecoration 
   => control._set(signal, Avalonia.Media.TextDecoration.StrokeDashOffsetProperty!, onChanged);


 // StrokeThickness

/*ValueSetterGenerator*/
public static T StrokeThickness<T>(this T control, System.Double value) where T : Avalonia.Media.TextDecoration 
=> control._set(() => control.StrokeThickness = value!);

/*BindFromFuncSetterGenerator*/
public static T StrokeThickness<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Media.TextDecoration 
   => control._set(func, Avalonia.Media.TextDecoration.StrokeThicknessProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T StrokeThickness<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Media.TextDecoration 
   => control._set(signal, Avalonia.Media.TextDecoration.StrokeThicknessProperty!, onChanged);


 // StrokeLineCap

/*ValueSetterGenerator*/
public static T StrokeLineCap<T>(this T control, Avalonia.Media.PenLineCap value) where T : Avalonia.Media.TextDecoration 
=> control._set(() => control.StrokeLineCap = value!);

/*BindFromFuncSetterGenerator*/
public static T StrokeLineCap<T>(this T control, Func<Avalonia.Media.PenLineCap> func, Action<Avalonia.Media.PenLineCap>? onChanged = null) where T : Avalonia.Media.TextDecoration 
   => control._set(func, Avalonia.Media.TextDecoration.StrokeLineCapProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T StrokeLineCap<T>(this T control, ISignal<Avalonia.Media.PenLineCap> signal, Action<Avalonia.Media.PenLineCap>? onChanged = null) where T : Avalonia.Media.TextDecoration 
   => control._set(signal, Avalonia.Media.TextDecoration.StrokeLineCapProperty!, onChanged);


 // StrokeOffset

/*ValueSetterGenerator*/
public static T StrokeOffset<T>(this T control, System.Double value) where T : Avalonia.Media.TextDecoration 
=> control._set(() => control.StrokeOffset = value!);

/*BindFromFuncSetterGenerator*/
public static T StrokeOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Media.TextDecoration 
   => control._set(func, Avalonia.Media.TextDecoration.StrokeOffsetProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T StrokeOffset<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Media.TextDecoration 
   => control._set(signal, Avalonia.Media.TextDecoration.StrokeOffsetProperty!, onChanged);


 // StrokeOffsetUnit

/*ValueSetterGenerator*/
public static T StrokeOffsetUnit<T>(this T control, Avalonia.Media.TextDecorationUnit value) where T : Avalonia.Media.TextDecoration 
=> control._set(() => control.StrokeOffsetUnit = value!);

/*BindFromFuncSetterGenerator*/
public static T StrokeOffsetUnit<T>(this T control, Func<Avalonia.Media.TextDecorationUnit> func, Action<Avalonia.Media.TextDecorationUnit>? onChanged = null) where T : Avalonia.Media.TextDecoration 
   => control._set(func, Avalonia.Media.TextDecoration.StrokeOffsetUnitProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T StrokeOffsetUnit<T>(this T control, ISignal<Avalonia.Media.TextDecorationUnit> signal, Action<Avalonia.Media.TextDecorationUnit>? onChanged = null) where T : Avalonia.Media.TextDecoration 
   => control._set(signal, Avalonia.Media.TextDecoration.StrokeOffsetUnitProperty!, onChanged);



}
