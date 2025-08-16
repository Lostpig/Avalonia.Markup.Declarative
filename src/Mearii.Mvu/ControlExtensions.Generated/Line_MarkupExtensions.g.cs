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
public static partial class Line_MarkupExtensions
{
//================= Properties ======================//
 // StartPoint

/*ValueSetterGenerator*/
public static T StartPoint<T>(this T control, Avalonia.Point value) where T : Avalonia.Controls.Shapes.Line 
=> control._set(() => control.StartPoint = value!);

/*BindFromFuncSetterGenerator*/
public static T StartPoint<T>(this T control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null) where T : Avalonia.Controls.Shapes.Line 
   => control._set(func, Avalonia.Controls.Shapes.Line.StartPointProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T StartPoint<T>(this T control, ISignal<Avalonia.Point> signal, Action<Avalonia.Point>? onChanged = null) where T : Avalonia.Controls.Shapes.Line 
   => control._set(signal, Avalonia.Controls.Shapes.Line.StartPointProperty!, onChanged);


 // EndPoint

/*ValueSetterGenerator*/
public static T EndPoint<T>(this T control, Avalonia.Point value) where T : Avalonia.Controls.Shapes.Line 
=> control._set(() => control.EndPoint = value!);

/*BindFromFuncSetterGenerator*/
public static T EndPoint<T>(this T control, Func<Avalonia.Point> func, Action<Avalonia.Point>? onChanged = null) where T : Avalonia.Controls.Shapes.Line 
   => control._set(func, Avalonia.Controls.Shapes.Line.EndPointProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T EndPoint<T>(this T control, ISignal<Avalonia.Point> signal, Action<Avalonia.Point>? onChanged = null) where T : Avalonia.Controls.Shapes.Line 
   => control._set(signal, Avalonia.Controls.Shapes.Line.EndPointProperty!, onChanged);



//================= Styles ======================//
 // StartPoint

/*ValueStyleSetterGenerator*/
public static Style<T> StartPoint<T>(this Style<T> style, Avalonia.Point value) where T : Avalonia.Controls.Shapes.Line 
=> style._addSetter(Avalonia.Controls.Shapes.Line.StartPointProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StartPoint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Line 
=> style._addSetter(Avalonia.Controls.Shapes.Line.StartPointProperty, binding);


 // EndPoint

/*ValueStyleSetterGenerator*/
public static Style<T> EndPoint<T>(this Style<T> style, Avalonia.Point value) where T : Avalonia.Controls.Shapes.Line 
=> style._addSetter(Avalonia.Controls.Shapes.Line.EndPointProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> EndPoint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Line 
=> style._addSetter(Avalonia.Controls.Shapes.Line.EndPointProperty, binding);



}
