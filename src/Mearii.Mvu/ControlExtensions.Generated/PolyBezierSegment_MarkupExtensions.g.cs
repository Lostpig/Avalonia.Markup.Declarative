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
public static partial class PolyBezierSegment_MarkupExtensions
{
//================= Properties ======================//
 // Points

/*ValueSetterGenerator*/
public static Avalonia.Media.PolyBezierSegment Points(this Avalonia.Media.PolyBezierSegment control, Avalonia.Points value)  
=> control._set(() => control.Points = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.PolyBezierSegment Points(this Avalonia.Media.PolyBezierSegment control, Func<Avalonia.Points> func, Action<Avalonia.Points>? onChanged = null)  
   => control._set(func, Avalonia.Media.PolyBezierSegment.PointsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.PolyBezierSegment Points(this Avalonia.Media.PolyBezierSegment control, ISignal<Avalonia.Points> signal, Action<Avalonia.Points>? onChanged = null)  
   => control._set(signal, Avalonia.Media.PolyBezierSegment.PointsProperty!, onChanged);



}
