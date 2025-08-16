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
public static partial class BlurEffect_MarkupExtensions
{
//================= Properties ======================//
 // Radius

/*ValueSetterGenerator*/
public static Avalonia.Media.BlurEffect Radius(this Avalonia.Media.BlurEffect control, System.Double value)  
=> control._set(() => control.Radius = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.BlurEffect Radius(this Avalonia.Media.BlurEffect control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.BlurEffect.RadiusProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.BlurEffect Radius(this Avalonia.Media.BlurEffect control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.BlurEffect.RadiusProperty!, onChanged);



}
