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
public static partial class Popup_MarkupExtensions
{
//================= Properties ======================//
 // WindowManagerAddShadowHint

/*ValueSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.WindowManagerAddShadowHint = value!);

/*BindFromFuncSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(func, Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(signal, Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty!, onChanged);


 // Child

/*ValueSetterGenerator*/
public static T Child<T>(this T control, Avalonia.Controls.Control value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.Child = value!);

/*BindFromFuncSetterGenerator*/
public static T Child<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(func, Avalonia.Controls.Primitives.Popup.ChildProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Child<T>(this T control, ISignal<Avalonia.Controls.Control> signal, Action<Avalonia.Controls.Control>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(signal, Avalonia.Controls.Primitives.Popup.ChildProperty!, onChanged);


 // InheritsTransform

/*ValueSetterGenerator*/
public static T InheritsTransform<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.InheritsTransform = value!);

/*BindFromFuncSetterGenerator*/
public static T InheritsTransform<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(func, Avalonia.Controls.Primitives.Popup.InheritsTransformProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T InheritsTransform<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(signal, Avalonia.Controls.Primitives.Popup.InheritsTransformProperty!, onChanged);


 // IsOpen

/*ValueSetterGenerator*/
public static T IsOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.IsOpen = value!);

/*BindFromFuncSetterGenerator*/
public static T IsOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(func, Avalonia.Controls.Primitives.Popup.IsOpenProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsOpen<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(signal, Avalonia.Controls.Primitives.Popup.IsOpenProperty!, onChanged);


 // PlacementAnchor

/*ValueSetterGenerator*/
public static T PlacementAnchor<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.PlacementAnchor = value!);

/*BindFromFuncSetterGenerator*/
public static T PlacementAnchor<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(func, Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PlacementAnchor<T>(this T control, ISignal<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> signal, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(signal, Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty!, onChanged);


 // PlacementConstraintAdjustment

/*ValueSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.PlacementConstraintAdjustment = value!);

/*BindFromFuncSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(func, Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, ISignal<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> signal, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(signal, Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty!, onChanged);


 // PlacementGravity

/*ValueSetterGenerator*/
public static T PlacementGravity<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.PlacementGravity = value!);

/*BindFromFuncSetterGenerator*/
public static T PlacementGravity<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(func, Avalonia.Controls.Primitives.Popup.PlacementGravityProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PlacementGravity<T>(this T control, ISignal<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> signal, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(signal, Avalonia.Controls.Primitives.Popup.PlacementGravityProperty!, onChanged);


 // Placement

/*ValueSetterGenerator*/
public static T Placement<T>(this T control, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.Placement = value!);

/*BindFromFuncSetterGenerator*/
public static T Placement<T>(this T control, Func<Avalonia.Controls.PlacementMode> func, Action<Avalonia.Controls.PlacementMode>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(func, Avalonia.Controls.Primitives.Popup.PlacementProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Placement<T>(this T control, ISignal<Avalonia.Controls.PlacementMode> signal, Action<Avalonia.Controls.PlacementMode>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(signal, Avalonia.Controls.Primitives.Popup.PlacementProperty!, onChanged);


 // PlacementRect

/*ValueSetterGenerator*/
public static T PlacementRect<T>(this T control, System.Nullable<Avalonia.Rect> value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.PlacementRect = value!);

/*BindFromFuncSetterGenerator*/
public static T PlacementRect<T>(this T control, Func<System.Nullable<Avalonia.Rect>> func, Action<System.Nullable<Avalonia.Rect>>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(func, Avalonia.Controls.Primitives.Popup.PlacementRectProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PlacementRect<T>(this T control, ISignal<System.Nullable<Avalonia.Rect>> signal, Action<System.Nullable<Avalonia.Rect>>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(signal, Avalonia.Controls.Primitives.Popup.PlacementRectProperty!, onChanged);


 // PlacementTarget

/*ValueSetterGenerator*/
public static T PlacementTarget<T>(this T control, Avalonia.Controls.Control value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.PlacementTarget = value!);

/*BindFromFuncSetterGenerator*/
public static T PlacementTarget<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(func, Avalonia.Controls.Primitives.Popup.PlacementTargetProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PlacementTarget<T>(this T control, ISignal<Avalonia.Controls.Control> signal, Action<Avalonia.Controls.Control>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(signal, Avalonia.Controls.Primitives.Popup.PlacementTargetProperty!, onChanged);


 // CustomPopupPlacementCallback

/*ValueSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.CustomPopupPlacementCallback = value!);

/*BindFromFuncSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> func, Action<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(func, Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, ISignal<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> signal, Action<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(signal, Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty!, onChanged);


 // OverlayDismissEventPassThrough

/*ValueSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.OverlayDismissEventPassThrough = value!);

/*BindFromFuncSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(func, Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(signal, Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty!, onChanged);


 // OverlayInputPassThroughElement

/*ValueSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, Avalonia.Input.IInputElement value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.OverlayInputPassThroughElement = value!);

/*BindFromFuncSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, Func<Avalonia.Input.IInputElement> func, Action<Avalonia.Input.IInputElement>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(func, Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, ISignal<Avalonia.Input.IInputElement> signal, Action<Avalonia.Input.IInputElement>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(signal, Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty!, onChanged);


 // HorizontalOffset

/*ValueSetterGenerator*/
public static T HorizontalOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.HorizontalOffset = value!);

/*BindFromFuncSetterGenerator*/
public static T HorizontalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(func, Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HorizontalOffset<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(signal, Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty!, onChanged);


 // IsLightDismissEnabled

/*ValueSetterGenerator*/
public static T IsLightDismissEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.IsLightDismissEnabled = value!);

/*BindFromFuncSetterGenerator*/
public static T IsLightDismissEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(func, Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsLightDismissEnabled<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(signal, Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty!, onChanged);


 // VerticalOffset

/*ValueSetterGenerator*/
public static T VerticalOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.VerticalOffset = value!);

/*BindFromFuncSetterGenerator*/
public static T VerticalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(func, Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T VerticalOffset<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(signal, Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty!, onChanged);


 // Topmost

/*ValueSetterGenerator*/
public static T Topmost<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.Topmost = value!);

/*BindFromFuncSetterGenerator*/
public static T Topmost<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(func, Avalonia.Controls.Primitives.Popup.TopmostProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Topmost<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(signal, Avalonia.Controls.Primitives.Popup.TopmostProperty!, onChanged);


 // TakesFocusFromNativeControl

/*ValueSetterGenerator*/
public static T TakesFocusFromNativeControl<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.TakesFocusFromNativeControl = value!);

/*BindFromFuncSetterGenerator*/
public static T TakesFocusFromNativeControl<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(func, Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TakesFocusFromNativeControl<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(signal, Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty!, onChanged);


 // ShouldUseOverlayLayer

/*ValueSetterGenerator*/
public static T ShouldUseOverlayLayer<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> control._set(() => control.ShouldUseOverlayLayer = value!);

/*BindFromFuncSetterGenerator*/
public static T ShouldUseOverlayLayer<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(func, Avalonia.Controls.Primitives.Popup.ShouldUseOverlayLayerProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ShouldUseOverlayLayer<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(signal, Avalonia.Controls.Primitives.Popup.ShouldUseOverlayLayerProperty!, onChanged);



//================= Attached Properties ======================//
 // TakesFocusFromNativeControl

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T Popup_TakesFocusFromNativeControl<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T Popup_TakesFocusFromNativeControl<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T Popup_TakesFocusFromNativeControl<T>(this T control, System.Boolean value, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty!, onChanged);



//================= Events ======================//
 // Closed

/*ActionToEventGenerator*/
public static T OnClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.Popup  => 
 control._setEvent((System.EventHandler<System.EventArgs>) ((arg0, arg1) => action(arg1)), h => control.Closed += h);


 // Opened

/*ActionToEventGenerator*/
public static T OnOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.Popup  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Opened += h);



//================= Styles ======================//
 // WindowManagerAddShadowHint

/*ValueStyleSetterGenerator*/
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, binding);


 // Child

/*ValueStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.ChildProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.ChildProperty, binding);


 // InheritsTransform

/*ValueStyleSetterGenerator*/
public static Style<T> InheritsTransform<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InheritsTransform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, binding);


 // IsOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsOpenProperty, binding);


 // PlacementAnchor

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementAnchor<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementAnchor<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, binding);


 // PlacementConstraintAdjustment

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, binding);


 // PlacementGravity

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementGravity<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementGravity<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, binding);


 // Placement

/*ValueStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementProperty, binding);


 // PlacementRect

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementRect<T>(this Style<T> style, System.Nullable<Avalonia.Rect> value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementRectProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementRect<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, binding);


 // PlacementTarget

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementTarget<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementTarget<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, binding);


 // CustomPopupPlacementCallback

/*ValueStyleSetterGenerator*/
public static Style<T> CustomPopupPlacementCallback<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CustomPopupPlacementCallback<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty, binding);


 // OverlayDismissEventPassThrough

/*ValueStyleSetterGenerator*/
public static Style<T> OverlayDismissEventPassThrough<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OverlayDismissEventPassThrough<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, binding);


 // OverlayInputPassThroughElement

/*ValueStyleSetterGenerator*/
public static Style<T> OverlayInputPassThroughElement<T>(this Style<T> style, Avalonia.Input.IInputElement value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OverlayInputPassThroughElement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, binding);


 // HorizontalOffset

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, binding);


 // IsLightDismissEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsLightDismissEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsLightDismissEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, binding);


 // VerticalOffset

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, binding);


 // Topmost

/*ValueStyleSetterGenerator*/
public static Style<T> Topmost<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.TopmostProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Topmost<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.TopmostProperty, binding);


 // TakesFocusFromNativeControl

/*ValueStyleSetterGenerator*/
public static Style<T> TakesFocusFromNativeControl<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TakesFocusFromNativeControl<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty, binding);


 // ShouldUseOverlayLayer

/*ValueStyleSetterGenerator*/
public static Style<T> ShouldUseOverlayLayer<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.ShouldUseOverlayLayerProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShouldUseOverlayLayer<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.ShouldUseOverlayLayerProperty, binding);



}
