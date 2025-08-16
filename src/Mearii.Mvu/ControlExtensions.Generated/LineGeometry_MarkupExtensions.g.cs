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
public static partial class LineGeometry_MarkupExtensions
{
//================= Properties ======================//
 // StartPoint

/*ValueSetterGenerator*/
public static T StartPoint<T>(this T control, Avalonia.Point value) where T : Avalonia.Media.LineGeometry 
=> control._set(() => control.StartPoint = value!);

/*BindFromFuncSetterGenerator*/
public static T StartPoint<T>(this T control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null) where T : Avalonia.Media.LineGeometry 
   => control._set(func, Avalonia.Media.LineGeometry.StartPointProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T StartPoint<T>(this T control, ISignal<Avalonia.Point> signal, Action<Avalonia.Point>? onChanged = null) where T : Avalonia.Media.LineGeometry 
   => control._set(signal, Avalonia.Media.LineGeometry.StartPointProperty!, onChanged);


 // EndPoint

/*ValueSetterGenerator*/
public static T EndPoint<T>(this T control, Avalonia.Point value) where T : Avalonia.Media.LineGeometry 
=> control._set(() => control.EndPoint = value!);

/*BindFromFuncSetterGenerator*/
public static T EndPoint<T>(this T control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null) where T : Avalonia.Media.LineGeometry 
   => control._set(func, Avalonia.Media.LineGeometry.EndPointProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T EndPoint<T>(this T control, ISignal<Avalonia.Point> signal, Action<Avalonia.Point>? onChanged = null) where T : Avalonia.Media.LineGeometry 
   => control._set(signal, Avalonia.Media.LineGeometry.EndPointProperty!, onChanged);



}
