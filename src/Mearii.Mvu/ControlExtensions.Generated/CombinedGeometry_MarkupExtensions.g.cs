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
public static partial class CombinedGeometry_MarkupExtensions
{
//================= Properties ======================//
 // Geometry1

/*ValueSetterGenerator*/
public static T Geometry1<T>(this T control, Avalonia.Media.Geometry value) where T : Avalonia.Media.CombinedGeometry 
=> control._set(() => control.Geometry1 = value!);

/*BindFromFuncSetterGenerator*/
public static T Geometry1<T>(this T control, Func<Avalonia.Media.Geometry> func, Action<Avalonia.Media.Geometry>? onChanged = null) where T : Avalonia.Media.CombinedGeometry 
   => control._set(func, Avalonia.Media.CombinedGeometry.Geometry1Property!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Geometry1<T>(this T control, ISignal<Avalonia.Media.Geometry> signal, Action<Avalonia.Media.Geometry>? onChanged = null) where T : Avalonia.Media.CombinedGeometry 
   => control._set(signal, Avalonia.Media.CombinedGeometry.Geometry1Property!, onChanged);


 // Geometry2

/*ValueSetterGenerator*/
public static T Geometry2<T>(this T control, Avalonia.Media.Geometry value) where T : Avalonia.Media.CombinedGeometry 
=> control._set(() => control.Geometry2 = value!);

/*BindFromFuncSetterGenerator*/
public static T Geometry2<T>(this T control, Func<Avalonia.Media.Geometry> func, Action<Avalonia.Media.Geometry>? onChanged = null) where T : Avalonia.Media.CombinedGeometry 
   => control._set(func, Avalonia.Media.CombinedGeometry.Geometry2Property!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Geometry2<T>(this T control, ISignal<Avalonia.Media.Geometry> signal, Action<Avalonia.Media.Geometry>? onChanged = null) where T : Avalonia.Media.CombinedGeometry 
   => control._set(signal, Avalonia.Media.CombinedGeometry.Geometry2Property!, onChanged);


 // GeometryCombineMode

/*ValueSetterGenerator*/
public static T GeometryCombineMode<T>(this T control, Avalonia.Media.GeometryCombineMode value) where T : Avalonia.Media.CombinedGeometry 
=> control._set(() => control.GeometryCombineMode = value!);

/*BindFromFuncSetterGenerator*/
public static T GeometryCombineMode<T>(this T control, Func<Avalonia.Media.GeometryCombineMode> func, Action<Avalonia.Media.GeometryCombineMode>? onChanged = null) where T : Avalonia.Media.CombinedGeometry 
   => control._set(func, Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T GeometryCombineMode<T>(this T control, ISignal<Avalonia.Media.GeometryCombineMode> signal, Action<Avalonia.Media.GeometryCombineMode>? onChanged = null) where T : Avalonia.Media.CombinedGeometry 
   => control._set(signal, Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty!, onChanged);



}
