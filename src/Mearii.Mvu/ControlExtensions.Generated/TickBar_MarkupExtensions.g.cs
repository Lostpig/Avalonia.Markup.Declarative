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
public static partial class TickBar_MarkupExtensions
{
//================= Properties ======================//
 // Fill

/*ValueSetterGenerator*/
public static T Fill<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TickBar 
=> control._set(() => control.Fill = value!);

/*BindFromFuncSetterGenerator*/
public static T Fill<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.TickBar 
   => control._set(func, Avalonia.Controls.TickBar.FillProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Fill<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.TickBar 
   => control._set(signal, Avalonia.Controls.TickBar.FillProperty!, onChanged);


 // Minimum

/*ValueSetterGenerator*/
public static T Minimum<T>(this T control, System.Double value) where T : Avalonia.Controls.TickBar 
=> control._set(() => control.Minimum = value!);

/*BindFromFuncSetterGenerator*/
public static T Minimum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.TickBar 
   => control._set(func, Avalonia.Controls.TickBar.MinimumProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Minimum<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.TickBar 
   => control._set(signal, Avalonia.Controls.TickBar.MinimumProperty!, onChanged);


 // Maximum

/*ValueSetterGenerator*/
public static T Maximum<T>(this T control, System.Double value) where T : Avalonia.Controls.TickBar 
=> control._set(() => control.Maximum = value!);

/*BindFromFuncSetterGenerator*/
public static T Maximum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.TickBar 
   => control._set(func, Avalonia.Controls.TickBar.MaximumProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Maximum<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.TickBar 
   => control._set(signal, Avalonia.Controls.TickBar.MaximumProperty!, onChanged);


 // TickFrequency

/*ValueSetterGenerator*/
public static T TickFrequency<T>(this T control, System.Double value) where T : Avalonia.Controls.TickBar 
=> control._set(() => control.TickFrequency = value!);

/*BindFromFuncSetterGenerator*/
public static T TickFrequency<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.TickBar 
   => control._set(func, Avalonia.Controls.TickBar.TickFrequencyProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TickFrequency<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.TickBar 
   => control._set(signal, Avalonia.Controls.TickBar.TickFrequencyProperty!, onChanged);


 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.TickBar 
=> control._set(() => control.Orientation = value!);

/*BindFromFuncSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null) where T : Avalonia.Controls.TickBar 
   => control._set(func, Avalonia.Controls.TickBar.OrientationProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Orientation<T>(this T control, ISignal<Avalonia.Layout.Orientation> signal, Action<Avalonia.Layout.Orientation>? onChanged = null) where T : Avalonia.Controls.TickBar 
   => control._set(signal, Avalonia.Controls.TickBar.OrientationProperty!, onChanged);


 // Ticks

/*ValueSetterGenerator*/
public static T Ticks<T>(this T control, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.TickBar 
=> control._set(() => control.Ticks = value!);

/*BindFromFuncSetterGenerator*/
public static T Ticks<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null) where T : Avalonia.Controls.TickBar 
   => control._set(func, Avalonia.Controls.TickBar.TicksProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Ticks<T>(this T control, ISignal<Avalonia.Collections.AvaloniaList<System.Double>> signal, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null) where T : Avalonia.Controls.TickBar 
   => control._set(signal, Avalonia.Controls.TickBar.TicksProperty!, onChanged);


 // IsDirectionReversed

/*ValueSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TickBar 
=> control._set(() => control.IsDirectionReversed = value!);

/*BindFromFuncSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TickBar 
   => control._set(func, Avalonia.Controls.TickBar.IsDirectionReversedProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TickBar 
   => control._set(signal, Avalonia.Controls.TickBar.IsDirectionReversedProperty!, onChanged);


 // Placement

/*ValueSetterGenerator*/
public static T Placement<T>(this T control, Avalonia.Controls.TickBarPlacement value) where T : Avalonia.Controls.TickBar 
=> control._set(() => control.Placement = value!);

/*BindFromFuncSetterGenerator*/
public static T Placement<T>(this T control, Func<Avalonia.Controls.TickBarPlacement> func, Action<Avalonia.Controls.TickBarPlacement>? onChanged = null) where T : Avalonia.Controls.TickBar 
   => control._set(func, Avalonia.Controls.TickBar.PlacementProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Placement<T>(this T control, ISignal<Avalonia.Controls.TickBarPlacement> signal, Action<Avalonia.Controls.TickBarPlacement>? onChanged = null) where T : Avalonia.Controls.TickBar 
   => control._set(signal, Avalonia.Controls.TickBar.PlacementProperty!, onChanged);


 // ReservedSpace

/*ValueSetterGenerator*/
public static T ReservedSpace<T>(this T control, Avalonia.Rect value) where T : Avalonia.Controls.TickBar 
=> control._set(() => control.ReservedSpace = value!);

/*BindFromFuncSetterGenerator*/
public static T ReservedSpace<T>(this T control, Func<Avalonia.Rect> func, Action<Avalonia.Rect>? onChanged = null) where T : Avalonia.Controls.TickBar 
   => control._set(func, Avalonia.Controls.TickBar.ReservedSpaceProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ReservedSpace<T>(this T control, ISignal<Avalonia.Rect> signal, Action<Avalonia.Rect>? onChanged = null) where T : Avalonia.Controls.TickBar 
   => control._set(signal, Avalonia.Controls.TickBar.ReservedSpaceProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T ReservedSpace<T>(this T control, System.Double x = default!, System.Double y = default!, System.Double width = default!, System.Double height = default!) where T : Avalonia.Controls.TickBar 
   => control._set(() => control.ReservedSpace = new Avalonia.Rect(x, y, width, height));
public static T ReservedSpace<T>(this T control, Avalonia.Size size = default!) where T : Avalonia.Controls.TickBar 
   => control._set(() => control.ReservedSpace = new Avalonia.Rect(size));
public static T ReservedSpace<T>(this T control, Avalonia.Point position = default!, Avalonia.Size size = default!) where T : Avalonia.Controls.TickBar 
   => control._set(() => control.ReservedSpace = new Avalonia.Rect(position, size));
public static T ReservedSpace<T>(this T control, Avalonia.Point topLeft = default!, Avalonia.Point bottomRight = default!) where T : Avalonia.Controls.TickBar 
   => control._set(() => control.ReservedSpace = new Avalonia.Rect(topLeft, bottomRight));



//================= Styles ======================//
 // Fill

/*ValueStyleSetterGenerator*/
public static Style<T> Fill<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.FillProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Fill<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.FillProperty, binding);


 // Minimum

/*ValueStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.MinimumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.MinimumProperty, binding);


 // Maximum

/*ValueStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.MaximumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.MaximumProperty, binding);


 // TickFrequency

/*ValueStyleSetterGenerator*/
public static Style<T> TickFrequency<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.TickFrequencyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TickFrequency<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.TickFrequencyProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.OrientationProperty, binding);


 // Ticks

/*ValueStyleSetterGenerator*/
public static Style<T> Ticks<T>(this Style<T> style, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.TicksProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Ticks<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.TicksProperty, binding);


 // IsDirectionReversed

/*ValueStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.IsDirectionReversedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.IsDirectionReversedProperty, binding);


 // Placement

/*ValueStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, Avalonia.Controls.TickBarPlacement value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.PlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.PlacementProperty, binding);


 // ReservedSpace

/*ValueStyleSetterGenerator*/
public static Style<T> ReservedSpace<T>(this Style<T> style, Avalonia.Rect value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ReservedSpace<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> ReservedSpace<T>(this Style<T> style, System.Double x, System.Double y, System.Double width, System.Double height) where T : Avalonia.Controls.TickBar 
   => style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, new Avalonia.Rect(x, y, width, height));public static Style<T> ReservedSpace<T>(this Style<T> style, Avalonia.Size size) where T : Avalonia.Controls.TickBar 
   => style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, new Avalonia.Rect(size));public static Style<T> ReservedSpace<T>(this Style<T> style, Avalonia.Point position, Avalonia.Size size) where T : Avalonia.Controls.TickBar 
   => style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, new Avalonia.Rect(position, size));public static Style<T> ReservedSpace<T>(this Style<T> style, Avalonia.Point topLeft, Avalonia.Point bottomRight) where T : Avalonia.Controls.TickBar 
   => style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, new Avalonia.Rect(topLeft, bottomRight));



}
