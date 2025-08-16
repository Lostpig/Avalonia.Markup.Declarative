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
public static partial class GeometryDrawing_MarkupExtensions
{
//================= Properties ======================//
 // Geometry

/*ValueSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Geometry(this Avalonia.Media.GeometryDrawing control, Avalonia.Media.Geometry value)  
=> control._set(() => control.Geometry = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Geometry(this Avalonia.Media.GeometryDrawing control, Func<Avalonia.Media.Geometry> func, Action<Avalonia.Media.Geometry>? onChanged = null)  
   => control._set(func, Avalonia.Media.GeometryDrawing.GeometryProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Geometry(this Avalonia.Media.GeometryDrawing control, ISignal<Avalonia.Media.Geometry> signal, Action<Avalonia.Media.Geometry>? onChanged = null)  
   => control._set(signal, Avalonia.Media.GeometryDrawing.GeometryProperty!, onChanged);


 // Brush

/*ValueSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Brush(this Avalonia.Media.GeometryDrawing control, Avalonia.Media.IBrush value)  
=> control._set(() => control.Brush = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Brush(this Avalonia.Media.GeometryDrawing control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null)  
   => control._set(func, Avalonia.Media.GeometryDrawing.BrushProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Brush(this Avalonia.Media.GeometryDrawing control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null)  
   => control._set(signal, Avalonia.Media.GeometryDrawing.BrushProperty!, onChanged);


 // Pen

/*ValueSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Pen(this Avalonia.Media.GeometryDrawing control, Avalonia.Media.IPen value)  
=> control._set(() => control.Pen = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Pen(this Avalonia.Media.GeometryDrawing control, Func<Avalonia.Media.IPen> func, Action<Avalonia.Media.IPen>? onChanged = null)  
   => control._set(func, Avalonia.Media.GeometryDrawing.PenProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.GeometryDrawing Pen(this Avalonia.Media.GeometryDrawing control, ISignal<Avalonia.Media.IPen> signal, Action<Avalonia.Media.IPen>? onChanged = null)  
   => control._set(signal, Avalonia.Media.GeometryDrawing.PenProperty!, onChanged);



}
