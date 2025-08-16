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
public static partial class Geometry_MarkupExtensions
{
//================= Properties ======================//
 // Transform

/*ValueSetterGenerator*/
public static T Transform<T>(this T control, Avalonia.Media.Transform value) where T : Avalonia.Media.Geometry 
=> control._set(() => control.Transform = value!);

/*BindFromFuncSetterGenerator*/
public static T Transform<T>(this T control, Func<Avalonia.Media.Transform> func, Action<Avalonia.Media.Transform>? onChanged = null) where T : Avalonia.Media.Geometry 
   => control._set(func, Avalonia.Media.Geometry.TransformProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Transform<T>(this T control, ISignal<Avalonia.Media.Transform> signal, Action<Avalonia.Media.Transform>? onChanged = null) where T : Avalonia.Media.Geometry 
   => control._set(signal, Avalonia.Media.Geometry.TransformProperty!, onChanged);



//================= Events ======================//
 // Changed

/*ActionToEventGenerator*/
public static T OnChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Media.Geometry  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Changed += h);



}
