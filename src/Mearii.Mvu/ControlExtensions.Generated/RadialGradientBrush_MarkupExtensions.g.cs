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
public static partial class RadialGradientBrush_MarkupExtensions
{
//================= Properties ======================//
 // Center

/*ValueSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, Avalonia.RelativePoint value)  
=> control._set(() => control.Center = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null)  
   => control._set(func, Avalonia.Media.RadialGradientBrush.CenterProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, ISignal<Avalonia.RelativePoint> signal, Action<Avalonia.RelativePoint>? onChanged = null)  
   => control._set(signal, Avalonia.Media.RadialGradientBrush.CenterProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, System.Double x = default!, System.Double y = default!, Avalonia.RelativeUnit unit = default!)  
   => control._set(() => control.Center = new Avalonia.RelativePoint(x, y, unit));
public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush control, Avalonia.Point point = default!, Avalonia.RelativeUnit unit = default!)  
   => control._set(() => control.Center = new Avalonia.RelativePoint(point, unit));


 // GradientOrigin

/*ValueSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, Avalonia.RelativePoint value)  
=> control._set(() => control.GradientOrigin = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null)  
   => control._set(func, Avalonia.Media.RadialGradientBrush.GradientOriginProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, ISignal<Avalonia.RelativePoint> signal, Action<Avalonia.RelativePoint>? onChanged = null)  
   => control._set(signal, Avalonia.Media.RadialGradientBrush.GradientOriginProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, System.Double x = default!, System.Double y = default!, Avalonia.RelativeUnit unit = default!)  
   => control._set(() => control.GradientOrigin = new Avalonia.RelativePoint(x, y, unit));
public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush control, Avalonia.Point point = default!, Avalonia.RelativeUnit unit = default!)  
   => control._set(() => control.GradientOrigin = new Avalonia.RelativePoint(point, unit));


 // RadiusX

/*ValueSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusX(this Avalonia.Media.RadialGradientBrush control, Avalonia.RelativeScalar value)  
=> control._set(() => control.RadiusX = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusX(this Avalonia.Media.RadialGradientBrush control, Func<Avalonia.RelativeScalar> func, Action<Avalonia.RelativeScalar>? onChanged = null)  
   => control._set(func, Avalonia.Media.RadialGradientBrush.RadiusXProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusX(this Avalonia.Media.RadialGradientBrush control, ISignal<Avalonia.RelativeScalar> signal, Action<Avalonia.RelativeScalar>? onChanged = null)  
   => control._set(signal, Avalonia.Media.RadialGradientBrush.RadiusXProperty!, onChanged);


 // RadiusY

/*ValueSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusY(this Avalonia.Media.RadialGradientBrush control, Avalonia.RelativeScalar value)  
=> control._set(() => control.RadiusY = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusY(this Avalonia.Media.RadialGradientBrush control, Func<Avalonia.RelativeScalar> func, Action<Avalonia.RelativeScalar>? onChanged = null)  
   => control._set(func, Avalonia.Media.RadialGradientBrush.RadiusYProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.RadialGradientBrush RadiusY(this Avalonia.Media.RadialGradientBrush control, ISignal<Avalonia.RelativeScalar> signal, Action<Avalonia.RelativeScalar>? onChanged = null)  
   => control._set(signal, Avalonia.Media.RadialGradientBrush.RadiusYProperty!, onChanged);



}
