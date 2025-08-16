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
public static partial class PolylineGeometry_MarkupExtensions
{
//================= Properties ======================//
 // Points

/*ValueSetterGenerator*/
public static T Points<T>(this T control, System.Collections.Generic.IList<Avalonia.Point> value) where T : Avalonia.Media.PolylineGeometry 
=> control._set(() => control.Points = value!);

/*BindFromFuncSetterGenerator*/
public static T Points<T>(this T control, Func<System.Collections.Generic.IList<Avalonia.Point>> func, Action<System.Collections.Generic.IList<Avalonia.Point>>? onChanged = null) where T : Avalonia.Media.PolylineGeometry 
   => control._set(func, Avalonia.Media.PolylineGeometry.PointsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Points<T>(this T control, ISignal<System.Collections.Generic.IList<Avalonia.Point>> signal, Action<System.Collections.Generic.IList<Avalonia.Point>>? onChanged = null) where T : Avalonia.Media.PolylineGeometry 
   => control._set(signal, Avalonia.Media.PolylineGeometry.PointsProperty!, onChanged);


 // IsFilled

/*ValueSetterGenerator*/
public static T IsFilled<T>(this T control, System.Boolean value) where T : Avalonia.Media.PolylineGeometry 
=> control._set(() => control.IsFilled = value!);

/*BindFromFuncSetterGenerator*/
public static T IsFilled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Media.PolylineGeometry 
   => control._set(func, Avalonia.Media.PolylineGeometry.IsFilledProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsFilled<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Media.PolylineGeometry 
   => control._set(signal, Avalonia.Media.PolylineGeometry.IsFilledProperty!, onChanged);



}
