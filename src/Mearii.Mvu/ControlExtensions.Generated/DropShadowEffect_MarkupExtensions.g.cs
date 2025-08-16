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
public static partial class DropShadowEffect_MarkupExtensions
{
//================= Properties ======================//
 // OffsetX

/*ValueSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control, System.Double value)  
=> control._set(() => control.OffsetX = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.DropShadowEffect.OffsetXProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.DropShadowEffect.OffsetXProperty!, onChanged);


 // OffsetY

/*ValueSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control, System.Double value)  
=> control._set(() => control.OffsetY = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.DropShadowEffect.OffsetYProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.DropShadowEffect.OffsetYProperty!, onChanged);



}
