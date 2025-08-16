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
public static partial class ScrollContentPresenter_MarkupExtensions
{
//================= Properties ======================//
 // CanHorizontallyScroll

/*ValueSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._set(() => control.CanHorizontallyScroll = value!);

/*BindFromFuncSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty!, onChanged);


 // CanVerticallyScroll

/*ValueSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._set(() => control.CanVerticallyScroll = value!);

/*BindFromFuncSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty!, onChanged);


 // Offset

/*ValueSetterGenerator*/
public static T Offset<T>(this T control, Avalonia.Vector value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._set(() => control.Offset = value!);

/*BindFromFuncSetterGenerator*/
public static T Offset<T>(this T control, Func<Avalonia.Vector> func, Action<Avalonia.Vector>? onChanged = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Offset<T>(this T control, ISignal<Avalonia.Vector> signal, Action<Avalonia.Vector>? onChanged = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty!, onChanged);


 // HorizontalSnapPointsType

/*ValueSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._set(() => control.HorizontalSnapPointsType = value!);

/*BindFromFuncSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, ISignal<Avalonia.Controls.Primitives.SnapPointsType> signal, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty!, onChanged);


 // VerticalSnapPointsType

/*ValueSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._set(() => control.VerticalSnapPointsType = value!);

/*BindFromFuncSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, ISignal<Avalonia.Controls.Primitives.SnapPointsType> signal, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty!, onChanged);


 // HorizontalSnapPointsAlignment

/*ValueSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._set(() => control.HorizontalSnapPointsAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, ISignal<Avalonia.Controls.Primitives.SnapPointsAlignment> signal, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty!, onChanged);


 // VerticalSnapPointsAlignment

/*ValueSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._set(() => control.VerticalSnapPointsAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, ISignal<Avalonia.Controls.Primitives.SnapPointsAlignment> signal, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty!, onChanged);


 // IsScrollChainingEnabled

/*ValueSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._set(() => control.IsScrollChainingEnabled = value!);

/*BindFromFuncSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty!, onChanged);



//================= Styles ======================//
 // CanHorizontallyScroll

/*ValueStyleSetterGenerator*/
public static Style<T> CanHorizontallyScroll<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanHorizontallyScroll<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty, binding);


 // CanVerticallyScroll

/*ValueStyleSetterGenerator*/
public static Style<T> CanVerticallyScroll<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanVerticallyScroll<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty, binding);


 // Offset

/*ValueStyleSetterGenerator*/
public static Style<T> Offset<T>(this Style<T> style, Avalonia.Vector value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Offset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty, binding);


 // HorizontalSnapPointsType

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty, binding);


 // VerticalSnapPointsType

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty, binding);


 // HorizontalSnapPointsAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, binding);


 // VerticalSnapPointsAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, binding);


 // IsScrollChainingEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty, binding);



}
