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
public static partial class RectangleGeometry_MarkupExtensions
{
//================= Properties ======================//
 // RadiusX

/*ValueSetterGenerator*/
public static T RadiusX<T>(this T control, System.Double value) where T : Avalonia.Media.RectangleGeometry 
=> control._set(() => control.RadiusX = value!);

/*BindFromFuncSetterGenerator*/
public static T RadiusX<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Media.RectangleGeometry 
   => control._set(func, Avalonia.Media.RectangleGeometry.RadiusXProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T RadiusX<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Media.RectangleGeometry 
   => control._set(signal, Avalonia.Media.RectangleGeometry.RadiusXProperty!, onChanged);


 // RadiusY

/*ValueSetterGenerator*/
public static T RadiusY<T>(this T control, System.Double value) where T : Avalonia.Media.RectangleGeometry 
=> control._set(() => control.RadiusY = value!);

/*BindFromFuncSetterGenerator*/
public static T RadiusY<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Media.RectangleGeometry 
   => control._set(func, Avalonia.Media.RectangleGeometry.RadiusYProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T RadiusY<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Media.RectangleGeometry 
   => control._set(signal, Avalonia.Media.RectangleGeometry.RadiusYProperty!, onChanged);


 // Rect

/*ValueSetterGenerator*/
public static T Rect<T>(this T control, Avalonia.Rect value) where T : Avalonia.Media.RectangleGeometry 
=> control._set(() => control.Rect = value!);

/*BindFromFuncSetterGenerator*/
public static T Rect<T>(this T control, Func<Avalonia.Rect> func, Action<Avalonia.Rect>? onChanged = null) where T : Avalonia.Media.RectangleGeometry 
   => control._set(func, Avalonia.Media.RectangleGeometry.RectProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Rect<T>(this T control, ISignal<Avalonia.Rect> signal, Action<Avalonia.Rect>? onChanged = null) where T : Avalonia.Media.RectangleGeometry 
   => control._set(signal, Avalonia.Media.RectangleGeometry.RectProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T Rect<T>(this T control, System.Double x = default!, System.Double y = default!, System.Double width = default!, System.Double height = default!) where T : Avalonia.Media.RectangleGeometry 
   => control._set(() => control.Rect = new Avalonia.Rect(x, y, width, height));
public static T Rect<T>(this T control, Avalonia.Size size = default!) where T : Avalonia.Media.RectangleGeometry 
   => control._set(() => control.Rect = new Avalonia.Rect(size));
public static T Rect<T>(this T control, Avalonia.Point position = default!, Avalonia.Size size = default!) where T : Avalonia.Media.RectangleGeometry 
   => control._set(() => control.Rect = new Avalonia.Rect(position, size));
public static T Rect<T>(this T control, Avalonia.Point topLeft = default!, Avalonia.Point bottomRight = default!) where T : Avalonia.Media.RectangleGeometry 
   => control._set(() => control.Rect = new Avalonia.Rect(topLeft, bottomRight));



}
