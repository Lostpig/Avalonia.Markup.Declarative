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
public static partial class LineSegment_MarkupExtensions
{
//================= Properties ======================//
 // Point

/*ValueSetterGenerator*/
public static Avalonia.Media.LineSegment Point(this Avalonia.Media.LineSegment control, Avalonia.Point value)  
=> control._set(() => control.Point = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.LineSegment Point(this Avalonia.Media.LineSegment control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null)  
   => control._set(func, Avalonia.Media.LineSegment.PointProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.LineSegment Point(this Avalonia.Media.LineSegment control, ISignal<Avalonia.Point> signal, Action<Avalonia.Point>? onChanged = null)  
   => control._set(signal, Avalonia.Media.LineSegment.PointProperty!, onChanged);



}
