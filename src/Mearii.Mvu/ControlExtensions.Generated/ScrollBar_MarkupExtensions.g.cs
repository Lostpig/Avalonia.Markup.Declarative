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
public static partial class ScrollBar_MarkupExtensions
{
//================= Properties ======================//
 // ViewportSize

/*ValueSetterGenerator*/
public static T ViewportSize<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> control._set(() => control.ViewportSize = value!);

/*BindFromFuncSetterGenerator*/
public static T ViewportSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(func, Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ViewportSize<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(signal, Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty!, onChanged);


 // Visibility

/*ValueSetterGenerator*/
public static T Visibility<T>(this T control, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> control._set(() => control.Visibility = value!);

/*BindFromFuncSetterGenerator*/
public static T Visibility<T>(this T control, Func<Avalonia.Controls.Primitives.ScrollBarVisibility> func, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(func, Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Visibility<T>(this T control, ISignal<Avalonia.Controls.Primitives.ScrollBarVisibility> signal, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(signal, Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty!, onChanged);


 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> control._set(() => control.Orientation = value!);

/*BindFromFuncSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(func, Avalonia.Controls.Primitives.ScrollBar.OrientationProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Orientation<T>(this T control, ISignal<Avalonia.Layout.Orientation> signal, Action<Avalonia.Layout.Orientation>? onChanged = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(signal, Avalonia.Controls.Primitives.ScrollBar.OrientationProperty!, onChanged);


 // AllowAutoHide

/*ValueSetterGenerator*/
public static T AllowAutoHide<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> control._set(() => control.AllowAutoHide = value!);

/*BindFromFuncSetterGenerator*/
public static T AllowAutoHide<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(func, Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T AllowAutoHide<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(signal, Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty!, onChanged);


 // HideDelay

/*ValueSetterGenerator*/
public static T HideDelay<T>(this T control, System.TimeSpan value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> control._set(() => control.HideDelay = value!);

/*BindFromFuncSetterGenerator*/
public static T HideDelay<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(func, Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HideDelay<T>(this T control, ISignal<System.TimeSpan> signal, Action<System.TimeSpan>? onChanged = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(signal, Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty!, onChanged);


 // ShowDelay

/*ValueSetterGenerator*/
public static T ShowDelay<T>(this T control, System.TimeSpan value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> control._set(() => control.ShowDelay = value!);

/*BindFromFuncSetterGenerator*/
public static T ShowDelay<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(func, Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ShowDelay<T>(this T control, ISignal<System.TimeSpan> signal, Action<System.TimeSpan>? onChanged = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(signal, Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty!, onChanged);



//================= Events ======================//
 // Scroll

/*ActionToEventGenerator*/
public static T OnScroll<T>(this T control, Action<Avalonia.Controls.Primitives.ScrollEventArgs> action) where T : Avalonia.Controls.Primitives.ScrollBar  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.Primitives.ScrollEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Scroll += h);



//================= Styles ======================//
 // ViewportSize

/*ValueStyleSetterGenerator*/
public static Style<T> ViewportSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ViewportSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty, binding);


 // Visibility

/*ValueStyleSetterGenerator*/
public static Style<T> Visibility<T>(this Style<T> style, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Visibility<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty, binding);


 // AllowAutoHide

/*ValueStyleSetterGenerator*/
public static Style<T> AllowAutoHide<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AllowAutoHide<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty, binding);


 // HideDelay

/*ValueStyleSetterGenerator*/
public static Style<T> HideDelay<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HideDelay<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty, binding);


 // ShowDelay

/*ValueStyleSetterGenerator*/
public static Style<T> ShowDelay<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowDelay<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty, binding);



}
