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
public static partial class LinearGradientBrush_MarkupExtensions
{
//================= Properties ======================//
 // StartPoint

/*ValueSetterGenerator*/
public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, Avalonia.RelativePoint value)  
=> control._set(() => control.StartPoint = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null)  
   => control._set(func, Avalonia.Media.LinearGradientBrush.StartPointProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, ISignal<Avalonia.RelativePoint> signal, Action<Avalonia.RelativePoint>? onChanged = null)  
   => control._set(signal, Avalonia.Media.LinearGradientBrush.StartPointProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, System.Double x = default!, System.Double y = default!, Avalonia.RelativeUnit unit = default!)  
   => control._set(() => control.StartPoint = new Avalonia.RelativePoint(x, y, unit));
public static Avalonia.Media.LinearGradientBrush StartPoint(this Avalonia.Media.LinearGradientBrush control, Avalonia.Point point = default!, Avalonia.RelativeUnit unit = default!)  
   => control._set(() => control.StartPoint = new Avalonia.RelativePoint(point, unit));


 // EndPoint

/*ValueSetterGenerator*/
public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, Avalonia.RelativePoint value)  
=> control._set(() => control.EndPoint = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null)  
   => control._set(func, Avalonia.Media.LinearGradientBrush.EndPointProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, ISignal<Avalonia.RelativePoint> signal, Action<Avalonia.RelativePoint>? onChanged = null)  
   => control._set(signal, Avalonia.Media.LinearGradientBrush.EndPointProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, System.Double x = default!, System.Double y = default!, Avalonia.RelativeUnit unit = default!)  
   => control._set(() => control.EndPoint = new Avalonia.RelativePoint(x, y, unit));
public static Avalonia.Media.LinearGradientBrush EndPoint(this Avalonia.Media.LinearGradientBrush control, Avalonia.Point point = default!, Avalonia.RelativeUnit unit = default!)  
   => control._set(() => control.EndPoint = new Avalonia.RelativePoint(point, unit));



}
