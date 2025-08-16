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
public static partial class SkewTransform_MarkupExtensions
{
//================= Properties ======================//
 // AngleX

/*ValueSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleX(this Avalonia.Media.SkewTransform control, System.Double value)  
=> control._set(() => control.AngleX = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleX(this Avalonia.Media.SkewTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.SkewTransform.AngleXProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleX(this Avalonia.Media.SkewTransform control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.SkewTransform.AngleXProperty!, onChanged);


 // AngleY

/*ValueSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleY(this Avalonia.Media.SkewTransform control, System.Double value)  
=> control._set(() => control.AngleY = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleY(this Avalonia.Media.SkewTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.SkewTransform.AngleYProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.SkewTransform AngleY(this Avalonia.Media.SkewTransform control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.SkewTransform.AngleYProperty!, onChanged);



}
