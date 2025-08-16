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
public static partial class ContextMenu_MarkupExtensions
{
//================= Properties ======================//
 // HorizontalOffset

/*ValueSetterGenerator*/
public static T HorizontalOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.ContextMenu 
=> control._set(() => control.HorizontalOffset = value!);

/*BindFromFuncSetterGenerator*/
public static T HorizontalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(func, Avalonia.Controls.ContextMenu.HorizontalOffsetProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HorizontalOffset<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(signal, Avalonia.Controls.ContextMenu.HorizontalOffsetProperty!, onChanged);


 // VerticalOffset

/*ValueSetterGenerator*/
public static T VerticalOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.ContextMenu 
=> control._set(() => control.VerticalOffset = value!);

/*BindFromFuncSetterGenerator*/
public static T VerticalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(func, Avalonia.Controls.ContextMenu.VerticalOffsetProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T VerticalOffset<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(signal, Avalonia.Controls.ContextMenu.VerticalOffsetProperty!, onChanged);


 // PlacementAnchor

/*ValueSetterGenerator*/
public static T PlacementAnchor<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value) where T : Avalonia.Controls.ContextMenu 
=> control._set(() => control.PlacementAnchor = value!);

/*BindFromFuncSetterGenerator*/
public static T PlacementAnchor<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor>? onChanged = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(func, Avalonia.Controls.ContextMenu.PlacementAnchorProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PlacementAnchor<T>(this T control, ISignal<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> signal, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor>? onChanged = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(signal, Avalonia.Controls.ContextMenu.PlacementAnchorProperty!, onChanged);


 // PlacementConstraintAdjustment

/*ValueSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value) where T : Avalonia.Controls.ContextMenu 
=> control._set(() => control.PlacementConstraintAdjustment = value!);

/*BindFromFuncSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment>? onChanged = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(func, Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, ISignal<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> signal, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment>? onChanged = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(signal, Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty!, onChanged);


 // PlacementGravity

/*ValueSetterGenerator*/
public static T PlacementGravity<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value) where T : Avalonia.Controls.ContextMenu 
=> control._set(() => control.PlacementGravity = value!);

/*BindFromFuncSetterGenerator*/
public static T PlacementGravity<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity>? onChanged = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(func, Avalonia.Controls.ContextMenu.PlacementGravityProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PlacementGravity<T>(this T control, ISignal<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> signal, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity>? onChanged = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(signal, Avalonia.Controls.ContextMenu.PlacementGravityProperty!, onChanged);


 // Placement

/*ValueSetterGenerator*/
public static T Placement<T>(this T control, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.ContextMenu 
=> control._set(() => control.Placement = value!);

/*BindFromFuncSetterGenerator*/
public static T Placement<T>(this T control, Func<Avalonia.Controls.PlacementMode> func, Action<Avalonia.Controls.PlacementMode>? onChanged = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(func, Avalonia.Controls.ContextMenu.PlacementProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Placement<T>(this T control, ISignal<Avalonia.Controls.PlacementMode> signal, Action<Avalonia.Controls.PlacementMode>? onChanged = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(signal, Avalonia.Controls.ContextMenu.PlacementProperty!, onChanged);


 // PlacementRect

/*ValueSetterGenerator*/
public static T PlacementRect<T>(this T control, System.Nullable<Avalonia.Rect> value) where T : Avalonia.Controls.ContextMenu 
=> control._set(() => control.PlacementRect = value!);

/*BindFromFuncSetterGenerator*/
public static T PlacementRect<T>(this T control, Func<System.Nullable<Avalonia.Rect>> func, Action<System.Nullable<Avalonia.Rect>>? onChanged = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(func, Avalonia.Controls.ContextMenu.PlacementRectProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PlacementRect<T>(this T control, ISignal<System.Nullable<Avalonia.Rect>> signal, Action<System.Nullable<Avalonia.Rect>>? onChanged = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(signal, Avalonia.Controls.ContextMenu.PlacementRectProperty!, onChanged);


 // WindowManagerAddShadowHint

/*ValueSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ContextMenu 
=> control._set(() => control.WindowManagerAddShadowHint = value!);

/*BindFromFuncSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(func, Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(signal, Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty!, onChanged);


 // PlacementTarget

/*ValueSetterGenerator*/
public static T PlacementTarget<T>(this T control, Avalonia.Controls.Control value) where T : Avalonia.Controls.ContextMenu 
=> control._set(() => control.PlacementTarget = value!);

/*BindFromFuncSetterGenerator*/
public static T PlacementTarget<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(func, Avalonia.Controls.ContextMenu.PlacementTargetProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PlacementTarget<T>(this T control, ISignal<Avalonia.Controls.Control> signal, Action<Avalonia.Controls.Control>? onChanged = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(signal, Avalonia.Controls.ContextMenu.PlacementTargetProperty!, onChanged);


 // CustomPopupPlacementCallback

/*ValueSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback value) where T : Avalonia.Controls.ContextMenu 
=> control._set(() => control.CustomPopupPlacementCallback = value!);

/*BindFromFuncSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> func, Action<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback>? onChanged = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(func, Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, ISignal<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> signal, Action<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback>? onChanged = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(signal, Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty!, onChanged);



//================= Events ======================//
 // Opening

/*ActionToEventGenerator*/
public static T OnOpening<T>(this T control, Action<System.ComponentModel.CancelEventArgs> action) where T : Avalonia.Controls.ContextMenu  => 
 control._setEvent((System.ComponentModel.CancelEventHandler) ((arg0, arg1) => action(arg1)), h => control.Opening += h);


 // Closing

/*ActionToEventGenerator*/
public static T OnClosing<T>(this T control, Action<System.ComponentModel.CancelEventArgs> action) where T : Avalonia.Controls.ContextMenu  => 
 control._setEvent((System.ComponentModel.CancelEventHandler) ((arg0, arg1) => action(arg1)), h => control.Closing += h);



//================= Styles ======================//
 // HorizontalOffset

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, binding);


 // VerticalOffset

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.VerticalOffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, binding);


 // PlacementAnchor

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementAnchor<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementAnchorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementAnchor<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, binding);


 // PlacementConstraintAdjustment

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, binding);


 // PlacementGravity

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementGravity<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementGravityProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementGravity<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementGravityProperty, binding);


 // Placement

/*ValueStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementProperty, binding);


 // PlacementRect

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementRect<T>(this Style<T> style, System.Nullable<Avalonia.Rect> value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementRectProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementRect<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementRectProperty, binding);


 // WindowManagerAddShadowHint

/*ValueStyleSetterGenerator*/
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, binding);


 // PlacementTarget

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementTarget<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementTargetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementTarget<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementTargetProperty, binding);


 // CustomPopupPlacementCallback

/*ValueStyleSetterGenerator*/
public static Style<T> CustomPopupPlacementCallback<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CustomPopupPlacementCallback<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty, binding);



}
