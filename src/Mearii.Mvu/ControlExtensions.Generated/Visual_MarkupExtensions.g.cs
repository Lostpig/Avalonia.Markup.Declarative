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
public static partial class Visual_MarkupExtensions
{
//================= Properties ======================//
 // ClipToBounds

/*ValueSetterGenerator*/
public static T ClipToBounds<T>(this T control, System.Boolean value) where T : Avalonia.Visual 
=> control._set(() => control.ClipToBounds = value!);

/*BindFromFuncSetterGenerator*/
public static T ClipToBounds<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Visual 
   => control._set(func, Avalonia.Visual.ClipToBoundsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ClipToBounds<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Visual 
   => control._set(signal, Avalonia.Visual.ClipToBoundsProperty!, onChanged);


 // Clip

/*ValueSetterGenerator*/
public static T Clip<T>(this T control, Avalonia.Media.Geometry value) where T : Avalonia.Visual 
=> control._set(() => control.Clip = value!);

/*BindFromFuncSetterGenerator*/
public static T Clip<T>(this T control, Func<Avalonia.Media.Geometry> func, Action<Avalonia.Media.Geometry>? onChanged = null) where T : Avalonia.Visual 
   => control._set(func, Avalonia.Visual.ClipProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Clip<T>(this T control, ISignal<Avalonia.Media.Geometry> signal, Action<Avalonia.Media.Geometry>? onChanged = null) where T : Avalonia.Visual 
   => control._set(signal, Avalonia.Visual.ClipProperty!, onChanged);


 // IsVisible

/*ValueSetterGenerator*/
public static T IsVisible<T>(this T control, System.Boolean value) where T : Avalonia.Visual 
=> control._set(() => control.IsVisible = value!);

/*BindFromFuncSetterGenerator*/
public static T IsVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Visual 
   => control._set(func, Avalonia.Visual.IsVisibleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsVisible<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Visual 
   => control._set(signal, Avalonia.Visual.IsVisibleProperty!, onChanged);


 // Opacity

/*ValueSetterGenerator*/
public static T Opacity<T>(this T control, System.Double value) where T : Avalonia.Visual 
=> control._set(() => control.Opacity = value!);

/*BindFromFuncSetterGenerator*/
public static T Opacity<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Visual 
   => control._set(func, Avalonia.Visual.OpacityProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Opacity<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Visual 
   => control._set(signal, Avalonia.Visual.OpacityProperty!, onChanged);


 // OpacityMask

/*ValueSetterGenerator*/
public static T OpacityMask<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Visual 
=> control._set(() => control.OpacityMask = value!);

/*BindFromFuncSetterGenerator*/
public static T OpacityMask<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Visual 
   => control._set(func, Avalonia.Visual.OpacityMaskProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T OpacityMask<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Visual 
   => control._set(signal, Avalonia.Visual.OpacityMaskProperty!, onChanged);


 // Effect

/*ValueSetterGenerator*/
public static T Effect<T>(this T control, Avalonia.Media.IEffect value) where T : Avalonia.Visual 
=> control._set(() => control.Effect = value!);

/*BindFromFuncSetterGenerator*/
public static T Effect<T>(this T control, Func<Avalonia.Media.IEffect> func, Action<Avalonia.Media.IEffect>? onChanged = null) where T : Avalonia.Visual 
   => control._set(func, Avalonia.Visual.EffectProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Effect<T>(this T control, ISignal<Avalonia.Media.IEffect> signal, Action<Avalonia.Media.IEffect>? onChanged = null) where T : Avalonia.Visual 
   => control._set(signal, Avalonia.Visual.EffectProperty!, onChanged);


 // RenderTransform

/*ValueSetterGenerator*/
public static T RenderTransform<T>(this T control, Avalonia.Media.ITransform value) where T : Avalonia.Visual 
=> control._set(() => control.RenderTransform = value!);

/*BindFromFuncSetterGenerator*/
public static T RenderTransform<T>(this T control, Func<Avalonia.Media.ITransform> func, Action<Avalonia.Media.ITransform>? onChanged = null) where T : Avalonia.Visual 
   => control._set(func, Avalonia.Visual.RenderTransformProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T RenderTransform<T>(this T control, ISignal<Avalonia.Media.ITransform> signal, Action<Avalonia.Media.ITransform>? onChanged = null) where T : Avalonia.Visual 
   => control._set(signal, Avalonia.Visual.RenderTransformProperty!, onChanged);


 // RenderTransformOrigin

/*ValueSetterGenerator*/
public static T RenderTransformOrigin<T>(this T control, Avalonia.RelativePoint value) where T : Avalonia.Visual 
=> control._set(() => control.RenderTransformOrigin = value!);

/*BindFromFuncSetterGenerator*/
public static T RenderTransformOrigin<T>(this T control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null) where T : Avalonia.Visual 
   => control._set(func, Avalonia.Visual.RenderTransformOriginProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T RenderTransformOrigin<T>(this T control, ISignal<Avalonia.RelativePoint> signal, Action<Avalonia.RelativePoint>? onChanged = null) where T : Avalonia.Visual 
   => control._set(signal, Avalonia.Visual.RenderTransformOriginProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T RenderTransformOrigin<T>(this T control, System.Double x = default!, System.Double y = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Visual 
   => control._set(() => control.RenderTransformOrigin = new Avalonia.RelativePoint(x, y, unit));
public static T RenderTransformOrigin<T>(this T control, Avalonia.Point point = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Visual 
   => control._set(() => control.RenderTransformOrigin = new Avalonia.RelativePoint(point, unit));


 // FlowDirection

/*ValueSetterGenerator*/
public static T FlowDirection<T>(this T control, Avalonia.Media.FlowDirection value) where T : Avalonia.Visual 
=> control._set(() => control.FlowDirection = value!);

/*BindFromFuncSetterGenerator*/
public static T FlowDirection<T>(this T control, Func<Avalonia.Media.FlowDirection> func, Action<Avalonia.Media.FlowDirection>? onChanged = null) where T : Avalonia.Visual 
   => control._set(func, Avalonia.Visual.FlowDirectionProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FlowDirection<T>(this T control, ISignal<Avalonia.Media.FlowDirection> signal, Action<Avalonia.Media.FlowDirection>? onChanged = null) where T : Avalonia.Visual 
   => control._set(signal, Avalonia.Visual.FlowDirectionProperty!, onChanged);


 // ZIndex

/*ValueSetterGenerator*/
public static T ZIndex<T>(this T control, System.Int32 value) where T : Avalonia.Visual 
=> control._set(() => control.ZIndex = value!);

/*BindFromFuncSetterGenerator*/
public static T ZIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Visual 
   => control._set(func, Avalonia.Visual.ZIndexProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ZIndex<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Visual 
   => control._set(signal, Avalonia.Visual.ZIndexProperty!, onChanged);



//================= Attached Properties ======================//
 // FlowDirection

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T Visual_FlowDirection<T>(this T control, Func<Avalonia.Media.FlowDirection> func, Action<Avalonia.Media.FlowDirection>? onChanged = null) where T : Avalonia.Visual 
   => control._set(func, Avalonia.Visual.FlowDirectionProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T Visual_FlowDirection<T>(this T control, ISignal<Avalonia.Media.FlowDirection> signal, Action<Avalonia.Media.FlowDirection>? onChanged = null) where T : Avalonia.Visual 
   => control._set(signal, Avalonia.Visual.FlowDirectionProperty!, onChanged);



//================= Events ======================//
 // AttachedToVisualTree

/*ActionToEventGenerator*/
public static T OnAttachedToVisualTree<T>(this T control, Action<Avalonia.VisualTreeAttachmentEventArgs> action) where T : Avalonia.Visual  => 
 control._setEvent((System.EventHandler<Avalonia.VisualTreeAttachmentEventArgs>) ((arg0, arg1) => action(arg1)), h => control.AttachedToVisualTree += h);


 // DetachedFromVisualTree

/*ActionToEventGenerator*/
public static T OnDetachedFromVisualTree<T>(this T control, Action<Avalonia.VisualTreeAttachmentEventArgs> action) where T : Avalonia.Visual  => 
 control._setEvent((System.EventHandler<Avalonia.VisualTreeAttachmentEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DetachedFromVisualTree += h);



//================= Styles ======================//
 // ClipToBounds

/*ValueStyleSetterGenerator*/
public static Style<T> ClipToBounds<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ClipToBoundsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClipToBounds<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ClipToBoundsProperty, binding);


 // Clip

/*ValueStyleSetterGenerator*/
public static Style<T> Clip<T>(this Style<T> style, Avalonia.Media.Geometry value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ClipProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Clip<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ClipProperty, binding);


 // IsVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.IsVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.IsVisibleProperty, binding);


 // Opacity

/*ValueStyleSetterGenerator*/
public static Style<T> Opacity<T>(this Style<T> style, System.Double value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.OpacityProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Opacity<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.OpacityProperty, binding);


 // OpacityMask

/*ValueStyleSetterGenerator*/
public static Style<T> OpacityMask<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.OpacityMaskProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OpacityMask<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.OpacityMaskProperty, binding);


 // Effect

/*ValueStyleSetterGenerator*/
public static Style<T> Effect<T>(this Style<T> style, Avalonia.Media.IEffect value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.EffectProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Effect<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.EffectProperty, binding);


 // RenderTransform

/*ValueStyleSetterGenerator*/
public static Style<T> RenderTransform<T>(this Style<T> style, Avalonia.Media.ITransform value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.RenderTransformProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RenderTransform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.RenderTransformProperty, binding);


 // RenderTransformOrigin

/*ValueStyleSetterGenerator*/
public static Style<T> RenderTransformOrigin<T>(this Style<T> style, Avalonia.RelativePoint value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.RenderTransformOriginProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RenderTransformOrigin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.RenderTransformOriginProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> RenderTransformOrigin<T>(this Style<T> style, System.Double x, System.Double y, Avalonia.RelativeUnit unit) where T : Avalonia.Visual 
   => style._addSetter(Avalonia.Visual.RenderTransformOriginProperty, new Avalonia.RelativePoint(x, y, unit));public static Style<T> RenderTransformOrigin<T>(this Style<T> style, Avalonia.Point point, Avalonia.RelativeUnit unit) where T : Avalonia.Visual 
   => style._addSetter(Avalonia.Visual.RenderTransformOriginProperty, new Avalonia.RelativePoint(point, unit));


 // FlowDirection

/*ValueStyleSetterGenerator*/
public static Style<T> FlowDirection<T>(this Style<T> style, Avalonia.Media.FlowDirection value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.FlowDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FlowDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.FlowDirectionProperty, binding);


 // ZIndex

/*ValueStyleSetterGenerator*/
public static Style<T> ZIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ZIndexProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ZIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ZIndexProperty, binding);



}
