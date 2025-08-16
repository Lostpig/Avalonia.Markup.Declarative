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
public static partial class DropShadowEffectBase_MarkupExtensions
{
//================= Properties ======================//
 // BlurRadius

/*ValueSetterGenerator*/
public static T BlurRadius<T>(this T control, System.Double value) where T : Avalonia.Media.DropShadowEffectBase 
=> control._set(() => control.BlurRadius = value!);

/*BindFromFuncSetterGenerator*/
public static T BlurRadius<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(func, Avalonia.Media.DropShadowEffectBase.BlurRadiusProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T BlurRadius<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(signal, Avalonia.Media.DropShadowEffectBase.BlurRadiusProperty!, onChanged);


 // Color

/*ValueSetterGenerator*/
public static T Color<T>(this T control, Avalonia.Media.Color value) where T : Avalonia.Media.DropShadowEffectBase 
=> control._set(() => control.Color = value!);

/*BindFromFuncSetterGenerator*/
public static T Color<T>(this T control, Func<Avalonia.Media.Color> func, Action<Avalonia.Media.Color>? onChanged = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(func, Avalonia.Media.DropShadowEffectBase.ColorProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Color<T>(this T control, ISignal<Avalonia.Media.Color> signal, Action<Avalonia.Media.Color>? onChanged = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(signal, Avalonia.Media.DropShadowEffectBase.ColorProperty!, onChanged);


 // Opacity

/*ValueSetterGenerator*/
public static T Opacity<T>(this T control, System.Double value) where T : Avalonia.Media.DropShadowEffectBase 
=> control._set(() => control.Opacity = value!);

/*BindFromFuncSetterGenerator*/
public static T Opacity<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(func, Avalonia.Media.DropShadowEffectBase.OpacityProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Opacity<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(signal, Avalonia.Media.DropShadowEffectBase.OpacityProperty!, onChanged);



}
