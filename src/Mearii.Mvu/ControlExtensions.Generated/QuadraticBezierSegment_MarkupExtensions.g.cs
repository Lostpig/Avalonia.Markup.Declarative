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
public static partial class QuadraticBezierSegment_MarkupExtensions
{
//================= Properties ======================//
 // Point1

/*ValueSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point1(this Avalonia.Media.QuadraticBezierSegment control, Avalonia.Point value)  
=> control._set(() => control.Point1 = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point1(this Avalonia.Media.QuadraticBezierSegment control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null)  
   => control._set(func, Avalonia.Media.QuadraticBezierSegment.Point1Property!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point1(this Avalonia.Media.QuadraticBezierSegment control, ISignal<Avalonia.Point> signal, Action<Avalonia.Point>? onChanged = null)  
   => control._set(signal, Avalonia.Media.QuadraticBezierSegment.Point1Property!, onChanged);


 // Point2

/*ValueSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point2(this Avalonia.Media.QuadraticBezierSegment control, Avalonia.Point value)  
=> control._set(() => control.Point2 = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point2(this Avalonia.Media.QuadraticBezierSegment control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null)  
   => control._set(func, Avalonia.Media.QuadraticBezierSegment.Point2Property!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.QuadraticBezierSegment Point2(this Avalonia.Media.QuadraticBezierSegment control, ISignal<Avalonia.Point> signal, Action<Avalonia.Point>? onChanged = null)  
   => control._set(signal, Avalonia.Media.QuadraticBezierSegment.Point2Property!, onChanged);



}
