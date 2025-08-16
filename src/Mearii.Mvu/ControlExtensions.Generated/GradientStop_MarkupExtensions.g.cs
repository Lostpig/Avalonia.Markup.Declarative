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
public static partial class GradientStop_MarkupExtensions
{
//================= Properties ======================//
 // Offset

/*ValueSetterGenerator*/
public static Avalonia.Media.GradientStop Offset(this Avalonia.Media.GradientStop control, System.Double value)  
=> control._set(() => control.Offset = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.GradientStop Offset(this Avalonia.Media.GradientStop control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.GradientStop.OffsetProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.GradientStop Offset(this Avalonia.Media.GradientStop control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.GradientStop.OffsetProperty!, onChanged);


 // Color

/*ValueSetterGenerator*/
public static Avalonia.Media.GradientStop Color(this Avalonia.Media.GradientStop control, Avalonia.Media.Color value)  
=> control._set(() => control.Color = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.GradientStop Color(this Avalonia.Media.GradientStop control, Func<Avalonia.Media.Color> func, Action<Avalonia.Media.Color>? onChanged = null)  
   => control._set(func, Avalonia.Media.GradientStop.ColorProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.GradientStop Color(this Avalonia.Media.GradientStop control, ISignal<Avalonia.Media.Color> signal, Action<Avalonia.Media.Color>? onChanged = null)  
   => control._set(signal, Avalonia.Media.GradientStop.ColorProperty!, onChanged);



}
