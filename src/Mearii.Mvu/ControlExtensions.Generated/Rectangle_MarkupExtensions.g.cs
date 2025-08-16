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
public static partial class Rectangle_MarkupExtensions
{
//================= Properties ======================//
 // RadiusX

/*ValueSetterGenerator*/
public static T RadiusX<T>(this T control, System.Double value) where T : Avalonia.Controls.Shapes.Rectangle 
=> control._set(() => control.RadiusX = value!);

/*BindFromFuncSetterGenerator*/
public static T RadiusX<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(func, Avalonia.Controls.Shapes.Rectangle.RadiusXProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T RadiusX<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(signal, Avalonia.Controls.Shapes.Rectangle.RadiusXProperty!, onChanged);


 // RadiusY

/*ValueSetterGenerator*/
public static T RadiusY<T>(this T control, System.Double value) where T : Avalonia.Controls.Shapes.Rectangle 
=> control._set(() => control.RadiusY = value!);

/*BindFromFuncSetterGenerator*/
public static T RadiusY<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(func, Avalonia.Controls.Shapes.Rectangle.RadiusYProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T RadiusY<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Shapes.Rectangle 
   => control._set(signal, Avalonia.Controls.Shapes.Rectangle.RadiusYProperty!, onChanged);



//================= Styles ======================//
 // RadiusX

/*ValueStyleSetterGenerator*/
public static Style<T> RadiusX<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Rectangle 
=> style._addSetter(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RadiusX<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Rectangle 
=> style._addSetter(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty, binding);


 // RadiusY

/*ValueStyleSetterGenerator*/
public static Style<T> RadiusY<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Rectangle 
=> style._addSetter(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RadiusY<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Rectangle 
=> style._addSetter(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty, binding);



}
