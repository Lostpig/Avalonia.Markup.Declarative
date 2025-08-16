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
public static partial class GeometryGroup_MarkupExtensions
{
//================= Properties ======================//
 // Children

/*ValueSetterGenerator*/
public static T Children<T>(this T control, Avalonia.Media.GeometryCollection value) where T : Avalonia.Media.GeometryGroup 
=> control._set(() => control.Children = value!);

/*BindFromFuncSetterGenerator*/
public static T Children<T>(this T control, Func<Avalonia.Media.GeometryCollection> func, Action<Avalonia.Media.GeometryCollection>? onChanged = null) where T : Avalonia.Media.GeometryGroup 
   => control._set(func, Avalonia.Media.GeometryGroup.ChildrenProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Children<T>(this T control, ISignal<Avalonia.Media.GeometryCollection> signal, Action<Avalonia.Media.GeometryCollection>? onChanged = null) where T : Avalonia.Media.GeometryGroup 
   => control._set(signal, Avalonia.Media.GeometryGroup.ChildrenProperty!, onChanged);


 // FillRule

/*ValueSetterGenerator*/
public static T FillRule<T>(this T control, Avalonia.Media.FillRule value) where T : Avalonia.Media.GeometryGroup 
=> control._set(() => control.FillRule = value!);

/*BindFromFuncSetterGenerator*/
public static T FillRule<T>(this T control, Func<Avalonia.Media.FillRule> func, Action<Avalonia.Media.FillRule>? onChanged = null) where T : Avalonia.Media.GeometryGroup 
   => control._set(func, Avalonia.Media.GeometryGroup.FillRuleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FillRule<T>(this T control, ISignal<Avalonia.Media.FillRule> signal, Action<Avalonia.Media.FillRule>? onChanged = null) where T : Avalonia.Media.GeometryGroup 
   => control._set(signal, Avalonia.Media.GeometryGroup.FillRuleProperty!, onChanged);



}
