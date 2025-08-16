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
public static partial class Polyline_MarkupExtensions
{
//================= Properties ======================//
 // Points

/*ValueSetterGenerator*/
public static T Points<T>(this T control, System.Collections.Generic.IList<Avalonia.Point> value) where T : Avalonia.Controls.Shapes.Polyline 
=> control._set(() => control.Points = value!);

/*BindFromFuncSetterGenerator*/
public static T Points<T>(this T control, Func<System.Collections.Generic.IList<Avalonia.Point>> func, Action<System.Collections.Generic.IList<Avalonia.Point>>? onChanged = null) where T : Avalonia.Controls.Shapes.Polyline 
   => control._set(func, Avalonia.Controls.Shapes.Polyline.PointsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Points<T>(this T control, ISignal<System.Collections.Generic.IList<Avalonia.Point>> signal, Action<System.Collections.Generic.IList<Avalonia.Point>>? onChanged = null) where T : Avalonia.Controls.Shapes.Polyline 
   => control._set(signal, Avalonia.Controls.Shapes.Polyline.PointsProperty!, onChanged);



//================= Styles ======================//
 // Points

/*ValueStyleSetterGenerator*/
public static Style<T> Points<T>(this Style<T> style, System.Collections.Generic.IList<Avalonia.Point> value) where T : Avalonia.Controls.Shapes.Polyline 
=> style._addSetter(Avalonia.Controls.Shapes.Polyline.PointsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Points<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Polyline 
=> style._addSetter(Avalonia.Controls.Shapes.Polyline.PointsProperty, binding);



}
