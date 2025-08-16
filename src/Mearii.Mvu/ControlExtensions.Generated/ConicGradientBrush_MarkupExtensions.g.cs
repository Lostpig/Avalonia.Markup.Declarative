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
public static partial class ConicGradientBrush_MarkupExtensions
{
//================= Properties ======================//
 // Center

/*ValueSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, Avalonia.RelativePoint value)  
=> control._set(() => control.Center = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null)  
   => control._set(func, Avalonia.Media.ConicGradientBrush.CenterProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, ISignal<Avalonia.RelativePoint> signal, Action<Avalonia.RelativePoint>? onChanged = null)  
   => control._set(signal, Avalonia.Media.ConicGradientBrush.CenterProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, System.Double x = default!, System.Double y = default!, Avalonia.RelativeUnit unit = default!)  
   => control._set(() => control.Center = new Avalonia.RelativePoint(x, y, unit));
public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush control, Avalonia.Point point = default!, Avalonia.RelativeUnit unit = default!)  
   => control._set(() => control.Center = new Avalonia.RelativePoint(point, unit));


 // Angle

/*ValueSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control, System.Double value)  
=> control._set(() => control.Angle = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.ConicGradientBrush.AngleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.ConicGradientBrush.AngleProperty!, onChanged);



}
