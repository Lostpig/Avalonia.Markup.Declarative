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
public static partial class PolyLineSegment_MarkupExtensions
{
//================= Properties ======================//
 // Points

/*ValueSetterGenerator*/
public static Avalonia.Media.PolyLineSegment Points(this Avalonia.Media.PolyLineSegment control, System.Collections.Generic.IList<Avalonia.Point> value)  
=> control._set(() => control.Points = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.PolyLineSegment Points(this Avalonia.Media.PolyLineSegment control, Func<System.Collections.Generic.IList<Avalonia.Point>> func, Action<System.Collections.Generic.IList<Avalonia.Point>>? onChanged = null)  
   => control._set(func, Avalonia.Media.PolyLineSegment.PointsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.PolyLineSegment Points(this Avalonia.Media.PolyLineSegment control, ISignal<System.Collections.Generic.IList<Avalonia.Point>> signal, Action<System.Collections.Generic.IList<Avalonia.Point>>? onChanged = null)  
   => control._set(signal, Avalonia.Media.PolyLineSegment.PointsProperty!, onChanged);



}
