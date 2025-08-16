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
public static partial class Pen_MarkupExtensions
{
//================= Properties ======================//
 // Brush

/*ValueSetterGenerator*/
public static Avalonia.Media.Pen Brush(this Avalonia.Media.Pen control, Avalonia.Media.IBrush value)  
=> control._set(() => control.Brush = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.Pen Brush(this Avalonia.Media.Pen control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null)  
   => control._set(func, Avalonia.Media.Pen.BrushProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.Pen Brush(this Avalonia.Media.Pen control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null)  
   => control._set(signal, Avalonia.Media.Pen.BrushProperty!, onChanged);


 // Thickness

/*ValueSetterGenerator*/
public static Avalonia.Media.Pen Thickness(this Avalonia.Media.Pen control, System.Double value)  
=> control._set(() => control.Thickness = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.Pen Thickness(this Avalonia.Media.Pen control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.Pen.ThicknessProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.Pen Thickness(this Avalonia.Media.Pen control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.Pen.ThicknessProperty!, onChanged);


 // DashStyle

/*ValueSetterGenerator*/
public static Avalonia.Media.Pen DashStyle(this Avalonia.Media.Pen control, Avalonia.Media.IDashStyle value)  
=> control._set(() => control.DashStyle = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.Pen DashStyle(this Avalonia.Media.Pen control, Func<Avalonia.Media.IDashStyle> func, Action<Avalonia.Media.IDashStyle>? onChanged = null)  
   => control._set(func, Avalonia.Media.Pen.DashStyleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.Pen DashStyle(this Avalonia.Media.Pen control, ISignal<Avalonia.Media.IDashStyle> signal, Action<Avalonia.Media.IDashStyle>? onChanged = null)  
   => control._set(signal, Avalonia.Media.Pen.DashStyleProperty!, onChanged);


 // LineCap

/*ValueSetterGenerator*/
public static Avalonia.Media.Pen LineCap(this Avalonia.Media.Pen control, Avalonia.Media.PenLineCap value)  
=> control._set(() => control.LineCap = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.Pen LineCap(this Avalonia.Media.Pen control, Func<Avalonia.Media.PenLineCap> func, Action<Avalonia.Media.PenLineCap>? onChanged = null)  
   => control._set(func, Avalonia.Media.Pen.LineCapProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.Pen LineCap(this Avalonia.Media.Pen control, ISignal<Avalonia.Media.PenLineCap> signal, Action<Avalonia.Media.PenLineCap>? onChanged = null)  
   => control._set(signal, Avalonia.Media.Pen.LineCapProperty!, onChanged);


 // LineJoin

/*ValueSetterGenerator*/
public static Avalonia.Media.Pen LineJoin(this Avalonia.Media.Pen control, Avalonia.Media.PenLineJoin value)  
=> control._set(() => control.LineJoin = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.Pen LineJoin(this Avalonia.Media.Pen control, Func<Avalonia.Media.PenLineJoin> func, Action<Avalonia.Media.PenLineJoin>? onChanged = null)  
   => control._set(func, Avalonia.Media.Pen.LineJoinProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.Pen LineJoin(this Avalonia.Media.Pen control, ISignal<Avalonia.Media.PenLineJoin> signal, Action<Avalonia.Media.PenLineJoin>? onChanged = null)  
   => control._set(signal, Avalonia.Media.Pen.LineJoinProperty!, onChanged);


 // MiterLimit

/*ValueSetterGenerator*/
public static Avalonia.Media.Pen MiterLimit(this Avalonia.Media.Pen control, System.Double value)  
=> control._set(() => control.MiterLimit = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.Pen MiterLimit(this Avalonia.Media.Pen control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.Pen.MiterLimitProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.Pen MiterLimit(this Avalonia.Media.Pen control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.Pen.MiterLimitProperty!, onChanged);



}
