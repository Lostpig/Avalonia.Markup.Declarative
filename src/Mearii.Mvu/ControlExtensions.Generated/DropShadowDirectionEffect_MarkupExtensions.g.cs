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
public static partial class DropShadowDirectionEffect_MarkupExtensions
{
//================= Properties ======================//
 // ShadowDepth

/*ValueSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect ShadowDepth(this Avalonia.Media.DropShadowDirectionEffect control, System.Double value)  
=> control._set(() => control.ShadowDepth = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect ShadowDepth(this Avalonia.Media.DropShadowDirectionEffect control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.DropShadowDirectionEffect.ShadowDepthProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect ShadowDepth(this Avalonia.Media.DropShadowDirectionEffect control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.DropShadowDirectionEffect.ShadowDepthProperty!, onChanged);


 // Direction

/*ValueSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect Direction(this Avalonia.Media.DropShadowDirectionEffect control, System.Double value)  
=> control._set(() => control.Direction = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect Direction(this Avalonia.Media.DropShadowDirectionEffect control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.DropShadowDirectionEffect.DirectionProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect Direction(this Avalonia.Media.DropShadowDirectionEffect control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.DropShadowDirectionEffect.DirectionProperty!, onChanged);



}
