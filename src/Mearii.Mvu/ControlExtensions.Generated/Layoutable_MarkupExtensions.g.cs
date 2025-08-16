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
public static partial class Layoutable_MarkupExtensions
{
//================= Properties ======================//
 // Width

/*ValueSetterGenerator*/
public static T Width<T>(this T control, System.Double value) where T : Avalonia.Layout.Layoutable 
=> control._set(() => control.Width = value!);

/*BindFromFuncSetterGenerator*/
public static T Width<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Layout.Layoutable 
   => control._set(func, Avalonia.Layout.Layoutable.WidthProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Width<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Layout.Layoutable 
   => control._set(signal, Avalonia.Layout.Layoutable.WidthProperty!, onChanged);


 // Height

/*ValueSetterGenerator*/
public static T Height<T>(this T control, System.Double value) where T : Avalonia.Layout.Layoutable 
=> control._set(() => control.Height = value!);

/*BindFromFuncSetterGenerator*/
public static T Height<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Layout.Layoutable 
   => control._set(func, Avalonia.Layout.Layoutable.HeightProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Height<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Layout.Layoutable 
   => control._set(signal, Avalonia.Layout.Layoutable.HeightProperty!, onChanged);


 // MinWidth

/*ValueSetterGenerator*/
public static T MinWidth<T>(this T control, System.Double value) where T : Avalonia.Layout.Layoutable 
=> control._set(() => control.MinWidth = value!);

/*BindFromFuncSetterGenerator*/
public static T MinWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Layout.Layoutable 
   => control._set(func, Avalonia.Layout.Layoutable.MinWidthProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MinWidth<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Layout.Layoutable 
   => control._set(signal, Avalonia.Layout.Layoutable.MinWidthProperty!, onChanged);


 // MaxWidth

/*ValueSetterGenerator*/
public static T MaxWidth<T>(this T control, System.Double value) where T : Avalonia.Layout.Layoutable 
=> control._set(() => control.MaxWidth = value!);

/*BindFromFuncSetterGenerator*/
public static T MaxWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Layout.Layoutable 
   => control._set(func, Avalonia.Layout.Layoutable.MaxWidthProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MaxWidth<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Layout.Layoutable 
   => control._set(signal, Avalonia.Layout.Layoutable.MaxWidthProperty!, onChanged);


 // MinHeight

/*ValueSetterGenerator*/
public static T MinHeight<T>(this T control, System.Double value) where T : Avalonia.Layout.Layoutable 
=> control._set(() => control.MinHeight = value!);

/*BindFromFuncSetterGenerator*/
public static T MinHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Layout.Layoutable 
   => control._set(func, Avalonia.Layout.Layoutable.MinHeightProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MinHeight<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Layout.Layoutable 
   => control._set(signal, Avalonia.Layout.Layoutable.MinHeightProperty!, onChanged);


 // MaxHeight

/*ValueSetterGenerator*/
public static T MaxHeight<T>(this T control, System.Double value) where T : Avalonia.Layout.Layoutable 
=> control._set(() => control.MaxHeight = value!);

/*BindFromFuncSetterGenerator*/
public static T MaxHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Layout.Layoutable 
   => control._set(func, Avalonia.Layout.Layoutable.MaxHeightProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MaxHeight<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Layout.Layoutable 
   => control._set(signal, Avalonia.Layout.Layoutable.MaxHeightProperty!, onChanged);


 // Margin

/*ValueSetterGenerator*/
public static T Margin<T>(this T control, Avalonia.Thickness value) where T : Avalonia.Layout.Layoutable 
=> control._set(() => control.Margin = value!);

/*BindFromFuncSetterGenerator*/
public static T Margin<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null) where T : Avalonia.Layout.Layoutable 
   => control._set(func, Avalonia.Layout.Layoutable.MarginProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Margin<T>(this T control, ISignal<Avalonia.Thickness> signal, Action<Avalonia.Thickness>? onChanged = null) where T : Avalonia.Layout.Layoutable 
   => control._set(signal, Avalonia.Layout.Layoutable.MarginProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T Margin<T>(this T control, System.Double uniformLength = default!) where T : Avalonia.Layout.Layoutable 
   => control._set(() => control.Margin = new Avalonia.Thickness(uniformLength));
public static T Margin<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Avalonia.Layout.Layoutable 
   => control._set(() => control.Margin = new Avalonia.Thickness(horizontal, vertical));
public static T Margin<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Avalonia.Layout.Layoutable 
   => control._set(() => control.Margin = new Avalonia.Thickness(left, top, right, bottom));


 // HorizontalAlignment

/*ValueSetterGenerator*/
public static T HorizontalAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Layout.Layoutable 
=> control._set(() => control.HorizontalAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T HorizontalAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null) where T : Avalonia.Layout.Layoutable 
   => control._set(func, Avalonia.Layout.Layoutable.HorizontalAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HorizontalAlignment<T>(this T control, ISignal<Avalonia.Layout.HorizontalAlignment> signal, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null) where T : Avalonia.Layout.Layoutable 
   => control._set(signal, Avalonia.Layout.Layoutable.HorizontalAlignmentProperty!, onChanged);


 // VerticalAlignment

/*ValueSetterGenerator*/
public static T VerticalAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Layout.Layoutable 
=> control._set(() => control.VerticalAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T VerticalAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null) where T : Avalonia.Layout.Layoutable 
   => control._set(func, Avalonia.Layout.Layoutable.VerticalAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T VerticalAlignment<T>(this T control, ISignal<Avalonia.Layout.VerticalAlignment> signal, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null) where T : Avalonia.Layout.Layoutable 
   => control._set(signal, Avalonia.Layout.Layoutable.VerticalAlignmentProperty!, onChanged);


 // UseLayoutRounding

/*ValueSetterGenerator*/
public static T UseLayoutRounding<T>(this T control, System.Boolean value) where T : Avalonia.Layout.Layoutable 
=> control._set(() => control.UseLayoutRounding = value!);

/*BindFromFuncSetterGenerator*/
public static T UseLayoutRounding<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Layout.Layoutable 
   => control._set(func, Avalonia.Layout.Layoutable.UseLayoutRoundingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T UseLayoutRounding<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Layout.Layoutable 
   => control._set(signal, Avalonia.Layout.Layoutable.UseLayoutRoundingProperty!, onChanged);



//================= Events ======================//
 // EffectiveViewportChanged

/*ActionToEventGenerator*/
public static T OnEffectiveViewportChanged<T>(this T control, Action<Avalonia.Layout.EffectiveViewportChangedEventArgs> action) where T : Avalonia.Layout.Layoutable  => 
 control._setEvent((System.EventHandler<Avalonia.Layout.EffectiveViewportChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.EffectiveViewportChanged += h);


 // LayoutUpdated

/*ActionToEventGenerator*/
public static T OnLayoutUpdated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Layout.Layoutable  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.LayoutUpdated += h);



//================= Styles ======================//
 // Width

/*ValueStyleSetterGenerator*/
public static Style<T> Width<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.WidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Width<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.WidthProperty, binding);


 // Height

/*ValueStyleSetterGenerator*/
public static Style<T> Height<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.HeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Height<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.HeightProperty, binding);


 // MinWidth

/*ValueStyleSetterGenerator*/
public static Style<T> MinWidth<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MinWidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinWidth<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MinWidthProperty, binding);


 // MaxWidth

/*ValueStyleSetterGenerator*/
public static Style<T> MaxWidth<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MaxWidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxWidth<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MaxWidthProperty, binding);


 // MinHeight

/*ValueStyleSetterGenerator*/
public static Style<T> MinHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MinHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MinHeightProperty, binding);


 // MaxHeight

/*ValueStyleSetterGenerator*/
public static Style<T> MaxHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MaxHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MaxHeightProperty, binding);


 // Margin

/*ValueStyleSetterGenerator*/
public static Style<T> Margin<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MarginProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Margin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.MarginProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> Margin<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Layout.Layoutable 
   => style._addSetter(Avalonia.Layout.Layoutable.MarginProperty, new Avalonia.Thickness(uniformLength));public static Style<T> Margin<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Layout.Layoutable 
   => style._addSetter(Avalonia.Layout.Layoutable.MarginProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> Margin<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Layout.Layoutable 
   => style._addSetter(Avalonia.Layout.Layoutable.MarginProperty, new Avalonia.Thickness(left, top, right, bottom));


 // HorizontalAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty, binding);


 // VerticalAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.VerticalAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.VerticalAlignmentProperty, binding);


 // UseLayoutRounding

/*ValueStyleSetterGenerator*/
public static Style<T> UseLayoutRounding<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseLayoutRounding<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable 
=> style._addSetter(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty, binding);



}
