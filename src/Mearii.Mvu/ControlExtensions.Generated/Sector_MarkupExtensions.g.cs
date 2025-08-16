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
public static partial class Sector_MarkupExtensions
{
//================= Properties ======================//
 // StartAngle

/*ValueSetterGenerator*/
public static T StartAngle<T>(this T control, System.Double value) where T : Avalonia.Controls.Shapes.Sector 
=> control._set(() => control.StartAngle = value!);

/*BindFromFuncSetterGenerator*/
public static T StartAngle<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Shapes.Sector 
   => control._set(func, Avalonia.Controls.Shapes.Sector.StartAngleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T StartAngle<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Shapes.Sector 
   => control._set(signal, Avalonia.Controls.Shapes.Sector.StartAngleProperty!, onChanged);


 // SweepAngle

/*ValueSetterGenerator*/
public static T SweepAngle<T>(this T control, System.Double value) where T : Avalonia.Controls.Shapes.Sector 
=> control._set(() => control.SweepAngle = value!);

/*BindFromFuncSetterGenerator*/
public static T SweepAngle<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Shapes.Sector 
   => control._set(func, Avalonia.Controls.Shapes.Sector.SweepAngleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SweepAngle<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Shapes.Sector 
   => control._set(signal, Avalonia.Controls.Shapes.Sector.SweepAngleProperty!, onChanged);



//================= Styles ======================//
 // StartAngle

/*ValueStyleSetterGenerator*/
public static Style<T> StartAngle<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Sector 
=> style._addSetter(Avalonia.Controls.Shapes.Sector.StartAngleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StartAngle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Sector 
=> style._addSetter(Avalonia.Controls.Shapes.Sector.StartAngleProperty, binding);


 // SweepAngle

/*ValueStyleSetterGenerator*/
public static Style<T> SweepAngle<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Sector 
=> style._addSetter(Avalonia.Controls.Shapes.Sector.SweepAngleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SweepAngle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Sector 
=> style._addSetter(Avalonia.Controls.Shapes.Sector.SweepAngleProperty, binding);



}
