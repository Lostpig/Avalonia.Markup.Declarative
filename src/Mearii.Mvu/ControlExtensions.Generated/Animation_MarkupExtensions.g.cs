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
public static partial class Animation_MarkupExtensions
{
//================= Properties ======================//
 // Duration

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, System.TimeSpan value)  
=> control._set(() => control.Duration = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null)  
   => control._set(func, Avalonia.Animation.Animation.DurationProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, ISignal<System.TimeSpan> signal, Action<System.TimeSpan>? onChanged = null)  
   => control._set(signal, Avalonia.Animation.Animation.DurationProperty!, onChanged);


 // IterationCount

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, Avalonia.Animation.IterationCount value)  
=> control._set(() => control.IterationCount = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, Func<Avalonia.Animation.IterationCount> func, Action<Avalonia.Animation.IterationCount>? onChanged = null)  
   => control._set(func, Avalonia.Animation.Animation.IterationCountProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, ISignal<Avalonia.Animation.IterationCount> signal, Action<Avalonia.Animation.IterationCount>? onChanged = null)  
   => control._set(signal, Avalonia.Animation.Animation.IterationCountProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, System.UInt64 value = default!)  
   => control._set(() => control.IterationCount = new Avalonia.Animation.IterationCount(value));
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, System.UInt64 value = default!, Avalonia.Animation.IterationType type = default!)  
   => control._set(() => control.IterationCount = new Avalonia.Animation.IterationCount(value, type));


 // PlaybackDirection

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, Avalonia.Animation.PlaybackDirection value)  
=> control._set(() => control.PlaybackDirection = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, Func<Avalonia.Animation.PlaybackDirection> func, Action<Avalonia.Animation.PlaybackDirection>? onChanged = null)  
   => control._set(func, Avalonia.Animation.Animation.PlaybackDirectionProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, ISignal<Avalonia.Animation.PlaybackDirection> signal, Action<Avalonia.Animation.PlaybackDirection>? onChanged = null)  
   => control._set(signal, Avalonia.Animation.Animation.PlaybackDirectionProperty!, onChanged);


 // FillMode

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, Avalonia.Animation.FillMode value)  
=> control._set(() => control.FillMode = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, Func<Avalonia.Animation.FillMode> func, Action<Avalonia.Animation.FillMode>? onChanged = null)  
   => control._set(func, Avalonia.Animation.Animation.FillModeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, ISignal<Avalonia.Animation.FillMode> signal, Action<Avalonia.Animation.FillMode>? onChanged = null)  
   => control._set(signal, Avalonia.Animation.Animation.FillModeProperty!, onChanged);


 // Easing

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, Avalonia.Animation.Easings.Easing value)  
=> control._set(() => control.Easing = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, Func<Avalonia.Animation.Easings.Easing> func, Action<Avalonia.Animation.Easings.Easing>? onChanged = null)  
   => control._set(func, Avalonia.Animation.Animation.EasingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, ISignal<Avalonia.Animation.Easings.Easing> signal, Action<Avalonia.Animation.Easings.Easing>? onChanged = null)  
   => control._set(signal, Avalonia.Animation.Animation.EasingProperty!, onChanged);


 // Delay

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, System.TimeSpan value)  
=> control._set(() => control.Delay = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null)  
   => control._set(func, Avalonia.Animation.Animation.DelayProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, ISignal<System.TimeSpan> signal, Action<System.TimeSpan>? onChanged = null)  
   => control._set(signal, Avalonia.Animation.Animation.DelayProperty!, onChanged);


 // DelayBetweenIterations

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, System.TimeSpan value)  
=> control._set(() => control.DelayBetweenIterations = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null)  
   => control._set(func, Avalonia.Animation.Animation.DelayBetweenIterationsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, ISignal<System.TimeSpan> signal, Action<System.TimeSpan>? onChanged = null)  
   => control._set(signal, Avalonia.Animation.Animation.DelayBetweenIterationsProperty!, onChanged);


 // SpeedRatio

/*ValueSetterGenerator*/
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, System.Double value)  
=> control._set(() => control.SpeedRatio = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Animation.Animation.SpeedRatioProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Animation.Animation.SpeedRatioProperty!, onChanged);



}
