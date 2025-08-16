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
public static partial class ArcSegment_MarkupExtensions
{
//================= Properties ======================//
 // IsLargeArc

/*ValueSetterGenerator*/
public static Avalonia.Media.ArcSegment IsLargeArc(this Avalonia.Media.ArcSegment control, System.Boolean value)  
=> control._set(() => control.IsLargeArc = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.ArcSegment IsLargeArc(this Avalonia.Media.ArcSegment control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null)  
   => control._set(func, Avalonia.Media.ArcSegment.IsLargeArcProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.ArcSegment IsLargeArc(this Avalonia.Media.ArcSegment control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null)  
   => control._set(signal, Avalonia.Media.ArcSegment.IsLargeArcProperty!, onChanged);


 // Point

/*ValueSetterGenerator*/
public static Avalonia.Media.ArcSegment Point(this Avalonia.Media.ArcSegment control, Avalonia.Point value)  
=> control._set(() => control.Point = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.ArcSegment Point(this Avalonia.Media.ArcSegment control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null)  
   => control._set(func, Avalonia.Media.ArcSegment.PointProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.ArcSegment Point(this Avalonia.Media.ArcSegment control, ISignal<Avalonia.Point> signal, Action<Avalonia.Point>? onChanged = null)  
   => control._set(signal, Avalonia.Media.ArcSegment.PointProperty!, onChanged);


 // RotationAngle

/*ValueSetterGenerator*/
public static Avalonia.Media.ArcSegment RotationAngle(this Avalonia.Media.ArcSegment control, System.Double value)  
=> control._set(() => control.RotationAngle = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.ArcSegment RotationAngle(this Avalonia.Media.ArcSegment control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.ArcSegment.RotationAngleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.ArcSegment RotationAngle(this Avalonia.Media.ArcSegment control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.ArcSegment.RotationAngleProperty!, onChanged);


 // Size

/*ValueSetterGenerator*/
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, Avalonia.Size value)  
=> control._set(() => control.Size = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, Func<Avalonia.Size> func, Action<Avalonia.Size>? onChanged = null)  
   => control._set(func, Avalonia.Media.ArcSegment.SizeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, ISignal<Avalonia.Size> signal, Action<Avalonia.Size>? onChanged = null)  
   => control._set(signal, Avalonia.Media.ArcSegment.SizeProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, System.Double width = default!, System.Double height = default!)  
   => control._set(() => control.Size = new Avalonia.Size(width, height));
public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment control, System.Numerics.Vector2 vector2 = default!)  
   => control._set(() => control.Size = new Avalonia.Size(vector2));


 // SweepDirection

/*ValueSetterGenerator*/
public static Avalonia.Media.ArcSegment SweepDirection(this Avalonia.Media.ArcSegment control, Avalonia.Media.SweepDirection value)  
=> control._set(() => control.SweepDirection = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.ArcSegment SweepDirection(this Avalonia.Media.ArcSegment control, Func<Avalonia.Media.SweepDirection> func, Action<Avalonia.Media.SweepDirection>? onChanged = null)  
   => control._set(func, Avalonia.Media.ArcSegment.SweepDirectionProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.ArcSegment SweepDirection(this Avalonia.Media.ArcSegment control, ISignal<Avalonia.Media.SweepDirection> signal, Action<Avalonia.Media.SweepDirection>? onChanged = null)  
   => control._set(signal, Avalonia.Media.ArcSegment.SweepDirectionProperty!, onChanged);



}
