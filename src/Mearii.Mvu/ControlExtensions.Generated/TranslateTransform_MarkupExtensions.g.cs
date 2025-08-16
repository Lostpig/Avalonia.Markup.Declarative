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
public static partial class TranslateTransform_MarkupExtensions
{
//================= Properties ======================//
 // X

/*ValueSetterGenerator*/
public static Avalonia.Media.TranslateTransform X(this Avalonia.Media.TranslateTransform control, System.Double value)  
=> control._set(() => control.X = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.TranslateTransform X(this Avalonia.Media.TranslateTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.TranslateTransform.XProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.TranslateTransform X(this Avalonia.Media.TranslateTransform control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.TranslateTransform.XProperty!, onChanged);


 // Y

/*ValueSetterGenerator*/
public static Avalonia.Media.TranslateTransform Y(this Avalonia.Media.TranslateTransform control, System.Double value)  
=> control._set(() => control.Y = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.TranslateTransform Y(this Avalonia.Media.TranslateTransform control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.TranslateTransform.YProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.TranslateTransform Y(this Avalonia.Media.TranslateTransform control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.TranslateTransform.YProperty!, onChanged);



}
