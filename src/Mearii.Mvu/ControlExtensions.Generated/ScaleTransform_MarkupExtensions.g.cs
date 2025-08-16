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
public static partial class ScaleTransform_MarkupExtensions
{
//================= Properties ======================//
 // ScaleX

/*ValueSetterGenerator*/
public static Avalonia.Media.ScaleTransform ScaleX(this Avalonia.Media.ScaleTransform control, System.Double value)  
=> control._set(() => control.ScaleX = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.ScaleTransform ScaleX(this Avalonia.Media.ScaleTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.ScaleTransform.ScaleXProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.ScaleTransform ScaleX(this Avalonia.Media.ScaleTransform control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.ScaleTransform.ScaleXProperty!, onChanged);


 // ScaleY

/*ValueSetterGenerator*/
public static Avalonia.Media.ScaleTransform ScaleY(this Avalonia.Media.ScaleTransform control, System.Double value)  
=> control._set(() => control.ScaleY = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.ScaleTransform ScaleY(this Avalonia.Media.ScaleTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.ScaleTransform.ScaleYProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.ScaleTransform ScaleY(this Avalonia.Media.ScaleTransform control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.ScaleTransform.ScaleYProperty!, onChanged);



}
