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
public static partial class TransitionBase_MarkupExtensions
{
//================= Properties ======================//
 // Duration

/*ValueSetterGenerator*/
public static T Duration<T>(this T control, System.TimeSpan value) where T : Avalonia.Animation.TransitionBase 
=> control._set(() => control.Duration = value!);

/*BindFromFuncSetterGenerator*/
public static T Duration<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null) where T : Avalonia.Animation.TransitionBase 
   => control._set(func, Avalonia.Animation.TransitionBase.DurationProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Duration<T>(this T control, ISignal<System.TimeSpan> signal, Action<System.TimeSpan>? onChanged = null) where T : Avalonia.Animation.TransitionBase 
   => control._set(signal, Avalonia.Animation.TransitionBase.DurationProperty!, onChanged);


 // Delay

/*ValueSetterGenerator*/
public static T Delay<T>(this T control, System.TimeSpan value) where T : Avalonia.Animation.TransitionBase 
=> control._set(() => control.Delay = value!);

/*BindFromFuncSetterGenerator*/
public static T Delay<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null) where T : Avalonia.Animation.TransitionBase 
   => control._set(func, Avalonia.Animation.TransitionBase.DelayProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Delay<T>(this T control, ISignal<System.TimeSpan> signal, Action<System.TimeSpan>? onChanged = null) where T : Avalonia.Animation.TransitionBase 
   => control._set(signal, Avalonia.Animation.TransitionBase.DelayProperty!, onChanged);


 // Easing

/*ValueSetterGenerator*/
public static T Easing<T>(this T control, Avalonia.Animation.Easings.Easing value) where T : Avalonia.Animation.TransitionBase 
=> control._set(() => control.Easing = value!);

/*BindFromFuncSetterGenerator*/
public static T Easing<T>(this T control, Func<Avalonia.Animation.Easings.Easing> func, Action<Avalonia.Animation.Easings.Easing>? onChanged = null) where T : Avalonia.Animation.TransitionBase 
   => control._set(func, Avalonia.Animation.TransitionBase.EasingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Easing<T>(this T control, ISignal<Avalonia.Animation.Easings.Easing> signal, Action<Avalonia.Animation.Easings.Easing>? onChanged = null) where T : Avalonia.Animation.TransitionBase 
   => control._set(signal, Avalonia.Animation.TransitionBase.EasingProperty!, onChanged);



}
