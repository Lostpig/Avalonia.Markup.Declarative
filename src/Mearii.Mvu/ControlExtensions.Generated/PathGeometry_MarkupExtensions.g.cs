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
public static partial class PathGeometry_MarkupExtensions
{
//================= Properties ======================//
 // Figures

/*ValueSetterGenerator*/
public static T Figures<T>(this T control, Avalonia.Media.PathFigures value) where T : Avalonia.Media.PathGeometry 
=> control._set(() => control.Figures = value!);

/*BindFromFuncSetterGenerator*/
public static T Figures<T>(this T control, Func<Avalonia.Media.PathFigures> func, Action<Avalonia.Media.PathFigures>? onChanged = null) where T : Avalonia.Media.PathGeometry 
   => control._set(func, Avalonia.Media.PathGeometry.FiguresProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Figures<T>(this T control, ISignal<Avalonia.Media.PathFigures> signal, Action<Avalonia.Media.PathFigures>? onChanged = null) where T : Avalonia.Media.PathGeometry 
   => control._set(signal, Avalonia.Media.PathGeometry.FiguresProperty!, onChanged);


 // FillRule

/*ValueSetterGenerator*/
public static T FillRule<T>(this T control, Avalonia.Media.FillRule value) where T : Avalonia.Media.PathGeometry 
=> control._set(() => control.FillRule = value!);

/*BindFromFuncSetterGenerator*/
public static T FillRule<T>(this T control, Func<Avalonia.Media.FillRule> func, Action<Avalonia.Media.FillRule>? onChanged = null) where T : Avalonia.Media.PathGeometry 
   => control._set(func, Avalonia.Media.PathGeometry.FillRuleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FillRule<T>(this T control, ISignal<Avalonia.Media.FillRule> signal, Action<Avalonia.Media.FillRule>? onChanged = null) where T : Avalonia.Media.PathGeometry 
   => control._set(signal, Avalonia.Media.PathGeometry.FillRuleProperty!, onChanged);



}
