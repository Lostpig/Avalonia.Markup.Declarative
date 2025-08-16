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
public static partial class ExperimentalAcrylicMaterial_MarkupExtensions
{
//================= Properties ======================//
 // TintColor

/*ValueSetterGenerator*/
public static T TintColor<T>(this T control, Avalonia.Media.Color value) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
=> control._set(() => control.TintColor = value!);

/*BindFromFuncSetterGenerator*/
public static T TintColor<T>(this T control, Func<Avalonia.Media.Color> func, Action<Avalonia.Media.Color>? onChanged = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(func, Avalonia.Media.ExperimentalAcrylicMaterial.TintColorProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TintColor<T>(this T control, ISignal<Avalonia.Media.Color> signal, Action<Avalonia.Media.Color>? onChanged = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(signal, Avalonia.Media.ExperimentalAcrylicMaterial.TintColorProperty!, onChanged);


 // BackgroundSource

/*ValueSetterGenerator*/
public static T BackgroundSource<T>(this T control, Avalonia.Media.AcrylicBackgroundSource value) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
=> control._set(() => control.BackgroundSource = value!);

/*BindFromFuncSetterGenerator*/
public static T BackgroundSource<T>(this T control, Func<Avalonia.Media.AcrylicBackgroundSource> func, Action<Avalonia.Media.AcrylicBackgroundSource>? onChanged = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(func, Avalonia.Media.ExperimentalAcrylicMaterial.BackgroundSourceProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T BackgroundSource<T>(this T control, ISignal<Avalonia.Media.AcrylicBackgroundSource> signal, Action<Avalonia.Media.AcrylicBackgroundSource>? onChanged = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(signal, Avalonia.Media.ExperimentalAcrylicMaterial.BackgroundSourceProperty!, onChanged);


 // TintOpacity

/*ValueSetterGenerator*/
public static T TintOpacity<T>(this T control, System.Double value) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
=> control._set(() => control.TintOpacity = value!);

/*BindFromFuncSetterGenerator*/
public static T TintOpacity<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(func, Avalonia.Media.ExperimentalAcrylicMaterial.TintOpacityProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TintOpacity<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(signal, Avalonia.Media.ExperimentalAcrylicMaterial.TintOpacityProperty!, onChanged);


 // MaterialOpacity

/*ValueSetterGenerator*/
public static T MaterialOpacity<T>(this T control, System.Double value) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
=> control._set(() => control.MaterialOpacity = value!);

/*BindFromFuncSetterGenerator*/
public static T MaterialOpacity<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(func, Avalonia.Media.ExperimentalAcrylicMaterial.MaterialOpacityProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MaterialOpacity<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(signal, Avalonia.Media.ExperimentalAcrylicMaterial.MaterialOpacityProperty!, onChanged);


 // PlatformTransparencyCompensationLevel

/*ValueSetterGenerator*/
public static T PlatformTransparencyCompensationLevel<T>(this T control, System.Double value) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
=> control._set(() => control.PlatformTransparencyCompensationLevel = value!);

/*BindFromFuncSetterGenerator*/
public static T PlatformTransparencyCompensationLevel<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(func, Avalonia.Media.ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PlatformTransparencyCompensationLevel<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(signal, Avalonia.Media.ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty!, onChanged);


 // FallbackColor

/*ValueSetterGenerator*/
public static T FallbackColor<T>(this T control, Avalonia.Media.Color value) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
=> control._set(() => control.FallbackColor = value!);

/*BindFromFuncSetterGenerator*/
public static T FallbackColor<T>(this T control, Func<Avalonia.Media.Color> func, Action<Avalonia.Media.Color>? onChanged = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(func, Avalonia.Media.ExperimentalAcrylicMaterial.FallbackColorProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FallbackColor<T>(this T control, ISignal<Avalonia.Media.Color> signal, Action<Avalonia.Media.Color>? onChanged = null) where T : Avalonia.Media.ExperimentalAcrylicMaterial 
   => control._set(signal, Avalonia.Media.ExperimentalAcrylicMaterial.FallbackColorProperty!, onChanged);



//================= Events ======================//
 // Invalidated

/*ActionToEventGenerator*/
public static T OnInvalidated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Media.ExperimentalAcrylicMaterial  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Invalidated += h);



}
