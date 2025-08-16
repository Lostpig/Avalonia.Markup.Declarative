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
public static partial class Track_MarkupExtensions
{
//================= Properties ======================//
 // Minimum

/*ValueSetterGenerator*/
public static T Minimum<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.Minimum = value!);

/*BindFromFuncSetterGenerator*/
public static T Minimum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(func, Avalonia.Controls.Primitives.Track.MinimumProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Minimum<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(signal, Avalonia.Controls.Primitives.Track.MinimumProperty!, onChanged);


 // Maximum

/*ValueSetterGenerator*/
public static T Maximum<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.Maximum = value!);

/*BindFromFuncSetterGenerator*/
public static T Maximum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(func, Avalonia.Controls.Primitives.Track.MaximumProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Maximum<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(signal, Avalonia.Controls.Primitives.Track.MaximumProperty!, onChanged);


 // Value

/*ValueSetterGenerator*/
public static T Value<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.Value = value!);

/*BindFromFuncSetterGenerator*/
public static T Value<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(func, Avalonia.Controls.Primitives.Track.ValueProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Value<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(signal, Avalonia.Controls.Primitives.Track.ValueProperty!, onChanged);


 // ViewportSize

/*ValueSetterGenerator*/
public static T ViewportSize<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.ViewportSize = value!);

/*BindFromFuncSetterGenerator*/
public static T ViewportSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(func, Avalonia.Controls.Primitives.Track.ViewportSizeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ViewportSize<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(signal, Avalonia.Controls.Primitives.Track.ViewportSizeProperty!, onChanged);


 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.Orientation = value!);

/*BindFromFuncSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(func, Avalonia.Controls.Primitives.Track.OrientationProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Orientation<T>(this T control, ISignal<Avalonia.Layout.Orientation> signal, Action<Avalonia.Layout.Orientation>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(signal, Avalonia.Controls.Primitives.Track.OrientationProperty!, onChanged);


 // Thumb

/*ValueSetterGenerator*/
public static T Thumb<T>(this T control, Avalonia.Controls.Primitives.Thumb value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.Thumb = value!);

/*BindFromFuncSetterGenerator*/
public static T Thumb<T>(this T control, Func<Avalonia.Controls.Primitives.Thumb> func, Action<Avalonia.Controls.Primitives.Thumb>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(func, Avalonia.Controls.Primitives.Track.ThumbProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Thumb<T>(this T control, ISignal<Avalonia.Controls.Primitives.Thumb> signal, Action<Avalonia.Controls.Primitives.Thumb>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(signal, Avalonia.Controls.Primitives.Track.ThumbProperty!, onChanged);


 // IncreaseButton

/*ValueSetterGenerator*/
public static T IncreaseButton<T>(this T control, Avalonia.Controls.Button value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.IncreaseButton = value!);

/*BindFromFuncSetterGenerator*/
public static T IncreaseButton<T>(this T control, Func<Avalonia.Controls.Button> func, Action<Avalonia.Controls.Button>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(func, Avalonia.Controls.Primitives.Track.IncreaseButtonProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IncreaseButton<T>(this T control, ISignal<Avalonia.Controls.Button> signal, Action<Avalonia.Controls.Button>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(signal, Avalonia.Controls.Primitives.Track.IncreaseButtonProperty!, onChanged);


 // DecreaseButton

/*ValueSetterGenerator*/
public static T DecreaseButton<T>(this T control, Avalonia.Controls.Button value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.DecreaseButton = value!);

/*BindFromFuncSetterGenerator*/
public static T DecreaseButton<T>(this T control, Func<Avalonia.Controls.Button> func, Action<Avalonia.Controls.Button>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(func, Avalonia.Controls.Primitives.Track.DecreaseButtonProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T DecreaseButton<T>(this T control, ISignal<Avalonia.Controls.Button> signal, Action<Avalonia.Controls.Button>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(signal, Avalonia.Controls.Primitives.Track.DecreaseButtonProperty!, onChanged);


 // IsDirectionReversed

/*ValueSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.IsDirectionReversed = value!);

/*BindFromFuncSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(func, Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(signal, Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty!, onChanged);


 // IgnoreThumbDrag

/*ValueSetterGenerator*/
public static T IgnoreThumbDrag<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.IgnoreThumbDrag = value!);

/*BindFromFuncSetterGenerator*/
public static T IgnoreThumbDrag<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(func, Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IgnoreThumbDrag<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(signal, Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty!, onChanged);


 // DeferThumbDrag

/*ValueSetterGenerator*/
public static T DeferThumbDrag<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
=> control._set(() => control.DeferThumbDrag = value!);

/*BindFromFuncSetterGenerator*/
public static T DeferThumbDrag<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(func, Avalonia.Controls.Primitives.Track.DeferThumbDragProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T DeferThumbDrag<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(signal, Avalonia.Controls.Primitives.Track.DeferThumbDragProperty!, onChanged);



//================= Styles ======================//
 // Minimum

/*ValueStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.MinimumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.MinimumProperty, binding);


 // Maximum

/*ValueStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.MaximumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.MaximumProperty, binding);


 // Value

/*ValueStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ValueProperty, binding);


 // ViewportSize

/*ValueStyleSetterGenerator*/
public static Style<T> ViewportSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ViewportSizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ViewportSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ViewportSizeProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.OrientationProperty, binding);


 // Thumb

/*ValueStyleSetterGenerator*/
public static Style<T> Thumb<T>(this Style<T> style, Avalonia.Controls.Primitives.Thumb value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ThumbProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Thumb<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ThumbProperty, binding);


 // IncreaseButton

/*ValueStyleSetterGenerator*/
public static Style<T> IncreaseButton<T>(this Style<T> style, Avalonia.Controls.Button value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IncreaseButton<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty, binding);


 // DecreaseButton

/*ValueStyleSetterGenerator*/
public static Style<T> DecreaseButton<T>(this Style<T> style, Avalonia.Controls.Button value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DecreaseButton<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty, binding);


 // IsDirectionReversed

/*ValueStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty, binding);


 // IgnoreThumbDrag

/*ValueStyleSetterGenerator*/
public static Style<T> IgnoreThumbDrag<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IgnoreThumbDrag<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty, binding);


 // DeferThumbDrag

/*ValueStyleSetterGenerator*/
public static Style<T> DeferThumbDrag<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DeferThumbDrag<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty, binding);



}
