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
public static partial class Brush_MarkupExtensions
{
//================= Properties ======================//
 // Opacity

/*ValueSetterGenerator*/
public static T Opacity<T>(this T control, System.Double value) where T : Avalonia.Media.Brush 
=> control._set(() => control.Opacity = value!);

/*BindFromFuncSetterGenerator*/
public static T Opacity<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Media.Brush 
   => control._set(func, Avalonia.Media.Brush.OpacityProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Opacity<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Media.Brush 
   => control._set(signal, Avalonia.Media.Brush.OpacityProperty!, onChanged);


 // Transform

/*ValueSetterGenerator*/
public static T Transform<T>(this T control, Avalonia.Media.ITransform value) where T : Avalonia.Media.Brush 
=> control._set(() => control.Transform = value!);

/*BindFromFuncSetterGenerator*/
public static T Transform<T>(this T control, Func<Avalonia.Media.ITransform> func, Action<Avalonia.Media.ITransform>? onChanged = null) where T : Avalonia.Media.Brush 
   => control._set(func, Avalonia.Media.Brush.TransformProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Transform<T>(this T control, ISignal<Avalonia.Media.ITransform> signal, Action<Avalonia.Media.ITransform>? onChanged = null) where T : Avalonia.Media.Brush 
   => control._set(signal, Avalonia.Media.Brush.TransformProperty!, onChanged);


 // TransformOrigin

/*ValueSetterGenerator*/
public static T TransformOrigin<T>(this T control, Avalonia.RelativePoint value) where T : Avalonia.Media.Brush 
=> control._set(() => control.TransformOrigin = value!);

/*BindFromFuncSetterGenerator*/
public static T TransformOrigin<T>(this T control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null) where T : Avalonia.Media.Brush 
   => control._set(func, Avalonia.Media.Brush.TransformOriginProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TransformOrigin<T>(this T control, ISignal<Avalonia.RelativePoint> signal, Action<Avalonia.RelativePoint>? onChanged = null) where T : Avalonia.Media.Brush 
   => control._set(signal, Avalonia.Media.Brush.TransformOriginProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T TransformOrigin<T>(this T control, System.Double x = default!, System.Double y = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.Brush 
   => control._set(() => control.TransformOrigin = new Avalonia.RelativePoint(x, y, unit));
public static T TransformOrigin<T>(this T control, Avalonia.Point point = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.Brush 
   => control._set(() => control.TransformOrigin = new Avalonia.RelativePoint(point, unit));



}
