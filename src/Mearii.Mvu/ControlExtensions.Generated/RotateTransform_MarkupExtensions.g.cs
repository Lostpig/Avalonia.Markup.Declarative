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
public static partial class RotateTransform_MarkupExtensions
{
//================= Properties ======================//
 // Angle

/*ValueSetterGenerator*/
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control, System.Double value)  
=> control._set(() => control.Angle = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.RotateTransform.AngleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.RotateTransform.AngleProperty!, onChanged);


 // CenterX

/*ValueSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control, System.Double value)  
=> control._set(() => control.CenterX = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.RotateTransform.CenterXProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.RotateTransform.CenterXProperty!, onChanged);


 // CenterY

/*ValueSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control, System.Double value)  
=> control._set(() => control.CenterY = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.RotateTransform.CenterYProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.RotateTransform.CenterYProperty!, onChanged);



}
