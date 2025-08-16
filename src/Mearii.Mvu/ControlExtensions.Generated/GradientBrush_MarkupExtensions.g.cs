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
public static partial class GradientBrush_MarkupExtensions
{
//================= Properties ======================//
 // SpreadMethod

/*ValueSetterGenerator*/
public static T SpreadMethod<T>(this T control, Avalonia.Media.GradientSpreadMethod value) where T : Avalonia.Media.GradientBrush 
=> control._set(() => control.SpreadMethod = value!);

/*BindFromFuncSetterGenerator*/
public static T SpreadMethod<T>(this T control, Func<Avalonia.Media.GradientSpreadMethod> func, Action<Avalonia.Media.GradientSpreadMethod>? onChanged = null) where T : Avalonia.Media.GradientBrush 
   => control._set(func, Avalonia.Media.GradientBrush.SpreadMethodProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SpreadMethod<T>(this T control, ISignal<Avalonia.Media.GradientSpreadMethod> signal, Action<Avalonia.Media.GradientSpreadMethod>? onChanged = null) where T : Avalonia.Media.GradientBrush 
   => control._set(signal, Avalonia.Media.GradientBrush.SpreadMethodProperty!, onChanged);


 // GradientStops

/*ValueSetterGenerator*/
public static T GradientStops<T>(this T control, Avalonia.Media.GradientStops value) where T : Avalonia.Media.GradientBrush 
=> control._set(() => control.GradientStops = value!);

/*BindFromFuncSetterGenerator*/
public static T GradientStops<T>(this T control, Func<Avalonia.Media.GradientStops> func, Action<Avalonia.Media.GradientStops>? onChanged = null) where T : Avalonia.Media.GradientBrush 
   => control._set(func, Avalonia.Media.GradientBrush.GradientStopsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T GradientStops<T>(this T control, ISignal<Avalonia.Media.GradientStops> signal, Action<Avalonia.Media.GradientStops>? onChanged = null) where T : Avalonia.Media.GradientBrush 
   => control._set(signal, Avalonia.Media.GradientBrush.GradientStopsProperty!, onChanged);



}
