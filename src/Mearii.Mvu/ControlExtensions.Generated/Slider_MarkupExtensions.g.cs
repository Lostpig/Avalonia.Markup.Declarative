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
public static partial class Slider_MarkupExtensions
{
//================= Properties ======================//
 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Slider 
=> control._set(() => control.Orientation = value!);

/*BindFromFuncSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null) where T : Avalonia.Controls.Slider 
   => control._set(func, Avalonia.Controls.Slider.OrientationProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Orientation<T>(this T control, ISignal<Avalonia.Layout.Orientation> signal, Action<Avalonia.Layout.Orientation>? onChanged = null) where T : Avalonia.Controls.Slider 
   => control._set(signal, Avalonia.Controls.Slider.OrientationProperty!, onChanged);


 // IsDirectionReversed

/*ValueSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Slider 
=> control._set(() => control.IsDirectionReversed = value!);

/*BindFromFuncSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Slider 
   => control._set(func, Avalonia.Controls.Slider.IsDirectionReversedProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Slider 
   => control._set(signal, Avalonia.Controls.Slider.IsDirectionReversedProperty!, onChanged);


 // IsSnapToTickEnabled

/*ValueSetterGenerator*/
public static T IsSnapToTickEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Slider 
=> control._set(() => control.IsSnapToTickEnabled = value!);

/*BindFromFuncSetterGenerator*/
public static T IsSnapToTickEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Slider 
   => control._set(func, Avalonia.Controls.Slider.IsSnapToTickEnabledProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsSnapToTickEnabled<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Slider 
   => control._set(signal, Avalonia.Controls.Slider.IsSnapToTickEnabledProperty!, onChanged);


 // TickFrequency

/*ValueSetterGenerator*/
public static T TickFrequency<T>(this T control, System.Double value) where T : Avalonia.Controls.Slider 
=> control._set(() => control.TickFrequency = value!);

/*BindFromFuncSetterGenerator*/
public static T TickFrequency<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Slider 
   => control._set(func, Avalonia.Controls.Slider.TickFrequencyProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TickFrequency<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Slider 
   => control._set(signal, Avalonia.Controls.Slider.TickFrequencyProperty!, onChanged);


 // TickPlacement

/*ValueSetterGenerator*/
public static T TickPlacement<T>(this T control, Avalonia.Controls.TickPlacement value) where T : Avalonia.Controls.Slider 
=> control._set(() => control.TickPlacement = value!);

/*BindFromFuncSetterGenerator*/
public static T TickPlacement<T>(this T control, Func<Avalonia.Controls.TickPlacement> func, Action<Avalonia.Controls.TickPlacement>? onChanged = null) where T : Avalonia.Controls.Slider 
   => control._set(func, Avalonia.Controls.Slider.TickPlacementProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TickPlacement<T>(this T control, ISignal<Avalonia.Controls.TickPlacement> signal, Action<Avalonia.Controls.TickPlacement>? onChanged = null) where T : Avalonia.Controls.Slider 
   => control._set(signal, Avalonia.Controls.Slider.TickPlacementProperty!, onChanged);


 // Ticks

/*ValueSetterGenerator*/
public static T Ticks<T>(this T control, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.Slider 
=> control._set(() => control.Ticks = value!);

/*BindFromFuncSetterGenerator*/
public static T Ticks<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null) where T : Avalonia.Controls.Slider 
   => control._set(func, Avalonia.Controls.Slider.TicksProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Ticks<T>(this T control, ISignal<Avalonia.Collections.AvaloniaList<System.Double>> signal, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null) where T : Avalonia.Controls.Slider 
   => control._set(signal, Avalonia.Controls.Slider.TicksProperty!, onChanged);



//================= Styles ======================//
 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.OrientationProperty, binding);


 // IsDirectionReversed

/*ValueStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.IsDirectionReversedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.IsDirectionReversedProperty, binding);


 // IsSnapToTickEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsSnapToTickEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSnapToTickEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty, binding);


 // TickFrequency

/*ValueStyleSetterGenerator*/
public static Style<T> TickFrequency<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TickFrequencyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TickFrequency<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TickFrequencyProperty, binding);


 // TickPlacement

/*ValueStyleSetterGenerator*/
public static Style<T> TickPlacement<T>(this Style<T> style, Avalonia.Controls.TickPlacement value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TickPlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TickPlacement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TickPlacementProperty, binding);


 // Ticks

/*ValueStyleSetterGenerator*/
public static Style<T> Ticks<T>(this Style<T> style, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TicksProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Ticks<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TicksProperty, binding);



}
