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
public static partial class PathFigure_MarkupExtensions
{
//================= Properties ======================//
 // IsClosed

/*ValueSetterGenerator*/
public static Avalonia.Media.PathFigure IsClosed(this Avalonia.Media.PathFigure control, System.Boolean value)  
=> control._set(() => control.IsClosed = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.PathFigure IsClosed(this Avalonia.Media.PathFigure control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null)  
   => control._set(func, Avalonia.Media.PathFigure.IsClosedProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.PathFigure IsClosed(this Avalonia.Media.PathFigure control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null)  
   => control._set(signal, Avalonia.Media.PathFigure.IsClosedProperty!, onChanged);


 // IsFilled

/*ValueSetterGenerator*/
public static Avalonia.Media.PathFigure IsFilled(this Avalonia.Media.PathFigure control, System.Boolean value)  
=> control._set(() => control.IsFilled = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.PathFigure IsFilled(this Avalonia.Media.PathFigure control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null)  
   => control._set(func, Avalonia.Media.PathFigure.IsFilledProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.PathFigure IsFilled(this Avalonia.Media.PathFigure control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null)  
   => control._set(signal, Avalonia.Media.PathFigure.IsFilledProperty!, onChanged);


 // Segments

/*ValueSetterGenerator*/
public static Avalonia.Media.PathFigure Segments(this Avalonia.Media.PathFigure control, Avalonia.Media.PathSegments value)  
=> control._set(() => control.Segments = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.PathFigure Segments(this Avalonia.Media.PathFigure control, Func<Avalonia.Media.PathSegments> func, Action<Avalonia.Media.PathSegments>? onChanged = null)  
   => control._set(func, Avalonia.Media.PathFigure.SegmentsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.PathFigure Segments(this Avalonia.Media.PathFigure control, ISignal<Avalonia.Media.PathSegments> signal, Action<Avalonia.Media.PathSegments>? onChanged = null)  
   => control._set(signal, Avalonia.Media.PathFigure.SegmentsProperty!, onChanged);


 // StartPoint

/*ValueSetterGenerator*/
public static Avalonia.Media.PathFigure StartPoint(this Avalonia.Media.PathFigure control, Avalonia.Point value)  
=> control._set(() => control.StartPoint = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.PathFigure StartPoint(this Avalonia.Media.PathFigure control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null)  
   => control._set(func, Avalonia.Media.PathFigure.StartPointProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.PathFigure StartPoint(this Avalonia.Media.PathFigure control, ISignal<Avalonia.Point> signal, Action<Avalonia.Point>? onChanged = null)  
   => control._set(signal, Avalonia.Media.PathFigure.StartPointProperty!, onChanged);



}
