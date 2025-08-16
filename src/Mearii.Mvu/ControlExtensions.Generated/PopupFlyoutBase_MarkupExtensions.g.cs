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
public static partial class PopupFlyoutBase_MarkupExtensions
{
//================= Properties ======================//
 // Placement

/*ValueSetterGenerator*/
public static T Placement<T>(this T control, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._set(() => control.Placement = value!);

/*BindFromFuncSetterGenerator*/
public static T Placement<T>(this T control, Func<Avalonia.Controls.PlacementMode> func, Action<Avalonia.Controls.PlacementMode>? onChanged = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(func, Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Placement<T>(this T control, ISignal<Avalonia.Controls.PlacementMode> signal, Action<Avalonia.Controls.PlacementMode>? onChanged = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(signal, Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementProperty!, onChanged);


 // HorizontalOffset

/*ValueSetterGenerator*/
public static T HorizontalOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._set(() => control.HorizontalOffset = value!);

/*BindFromFuncSetterGenerator*/
public static T HorizontalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(func, Avalonia.Controls.Primitives.PopupFlyoutBase.HorizontalOffsetProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HorizontalOffset<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(signal, Avalonia.Controls.Primitives.PopupFlyoutBase.HorizontalOffsetProperty!, onChanged);


 // VerticalOffset

/*ValueSetterGenerator*/
public static T VerticalOffset<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._set(() => control.VerticalOffset = value!);

/*BindFromFuncSetterGenerator*/
public static T VerticalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(func, Avalonia.Controls.Primitives.PopupFlyoutBase.VerticalOffsetProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T VerticalOffset<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(signal, Avalonia.Controls.Primitives.PopupFlyoutBase.VerticalOffsetProperty!, onChanged);


 // PlacementAnchor

/*ValueSetterGenerator*/
public static T PlacementAnchor<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._set(() => control.PlacementAnchor = value!);

/*BindFromFuncSetterGenerator*/
public static T PlacementAnchor<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor>? onChanged = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(func, Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementAnchorProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PlacementAnchor<T>(this T control, ISignal<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> signal, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor>? onChanged = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(signal, Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementAnchorProperty!, onChanged);


 // PlacementGravity

/*ValueSetterGenerator*/
public static T PlacementGravity<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._set(() => control.PlacementGravity = value!);

/*BindFromFuncSetterGenerator*/
public static T PlacementGravity<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity>? onChanged = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(func, Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementGravityProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PlacementGravity<T>(this T control, ISignal<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> signal, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity>? onChanged = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(signal, Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementGravityProperty!, onChanged);


 // CustomPopupPlacementCallback

/*ValueSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback value) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._set(() => control.CustomPopupPlacementCallback = value!);

/*BindFromFuncSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> func, Action<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback>? onChanged = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(func, Avalonia.Controls.Primitives.PopupFlyoutBase.CustomPopupPlacementCallbackProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, ISignal<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> signal, Action<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback>? onChanged = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(signal, Avalonia.Controls.Primitives.PopupFlyoutBase.CustomPopupPlacementCallbackProperty!, onChanged);


 // ShowMode

/*ValueSetterGenerator*/
public static T ShowMode<T>(this T control, Avalonia.Controls.FlyoutShowMode value) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._set(() => control.ShowMode = value!);

/*BindFromFuncSetterGenerator*/
public static T ShowMode<T>(this T control, Func<Avalonia.Controls.FlyoutShowMode> func, Action<Avalonia.Controls.FlyoutShowMode>? onChanged = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(func, Avalonia.Controls.Primitives.PopupFlyoutBase.ShowModeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ShowMode<T>(this T control, ISignal<Avalonia.Controls.FlyoutShowMode> signal, Action<Avalonia.Controls.FlyoutShowMode>? onChanged = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(signal, Avalonia.Controls.Primitives.PopupFlyoutBase.ShowModeProperty!, onChanged);


 // OverlayDismissEventPassThrough

/*ValueSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._set(() => control.OverlayDismissEventPassThrough = value!);

/*BindFromFuncSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(func, Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayDismissEventPassThroughProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(signal, Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayDismissEventPassThroughProperty!, onChanged);


 // OverlayInputPassThroughElement

/*ValueSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, Avalonia.Input.IInputElement value) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._set(() => control.OverlayInputPassThroughElement = value!);

/*BindFromFuncSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, Func<Avalonia.Input.IInputElement> func, Action<Avalonia.Input.IInputElement>? onChanged = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(func, Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayInputPassThroughElementProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, ISignal<Avalonia.Input.IInputElement> signal, Action<Avalonia.Input.IInputElement>? onChanged = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(signal, Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayInputPassThroughElementProperty!, onChanged);


 // PlacementConstraintAdjustment

/*ValueSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._set(() => control.PlacementConstraintAdjustment = value!);

/*BindFromFuncSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment>? onChanged = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(func, Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementConstraintAdjustmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, ISignal<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> signal, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment>? onChanged = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(signal, Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementConstraintAdjustmentProperty!, onChanged);



//================= Events ======================//
 // Closing

/*ActionToEventGenerator*/
public static T OnClosing<T>(this T control, Action<System.ComponentModel.CancelEventArgs> action) where T : Avalonia.Controls.Primitives.PopupFlyoutBase  => 
 control._setEvent((System.EventHandler<System.ComponentModel.CancelEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Closing += h);


 // Opening

/*ActionToEventGenerator*/
public static T OnOpening<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.PopupFlyoutBase  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Opening += h);



}
