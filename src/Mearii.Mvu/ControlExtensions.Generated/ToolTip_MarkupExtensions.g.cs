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
public static partial class ToolTip_MarkupExtensions
{
//================= Attached Properties ======================//
 // Tip

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ToolTip_Tip<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ToolTip.TipProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ToolTip_Tip<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ToolTip.TipProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolTip_Tip<T>(this T control, System.Object value, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ToolTip.TipProperty!, onChanged);


 // IsOpen

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ToolTip_IsOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ToolTip.IsOpenProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ToolTip_IsOpen<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ToolTip.IsOpenProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolTip_IsOpen<T>(this T control, System.Boolean value, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ToolTip.IsOpenProperty!, onChanged);


 // Placement

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ToolTip_Placement<T>(this T control, Func<Avalonia.Controls.PlacementMode> func, Action<Avalonia.Controls.PlacementMode>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ToolTip.PlacementProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ToolTip_Placement<T>(this T control, ISignal<Avalonia.Controls.PlacementMode> signal, Action<Avalonia.Controls.PlacementMode>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ToolTip.PlacementProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolTip_Placement<T>(this T control, Avalonia.Controls.PlacementMode value, Action<Avalonia.Controls.PlacementMode>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ToolTip.PlacementProperty!, onChanged);


 // HorizontalOffset

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ToolTip_HorizontalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ToolTip.HorizontalOffsetProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ToolTip_HorizontalOffset<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ToolTip.HorizontalOffsetProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolTip_HorizontalOffset<T>(this T control, System.Double value, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ToolTip.HorizontalOffsetProperty!, onChanged);


 // VerticalOffset

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ToolTip_VerticalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ToolTip.VerticalOffsetProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ToolTip_VerticalOffset<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ToolTip.VerticalOffsetProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolTip_VerticalOffset<T>(this T control, System.Double value, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ToolTip.VerticalOffsetProperty!, onChanged);


 // CustomPopupPlacementCallback

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ToolTip_CustomPopupPlacementCallback<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> func, Action<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ToolTip.CustomPopupPlacementCallbackProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ToolTip_CustomPopupPlacementCallback<T>(this T control, ISignal<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> signal, Action<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ToolTip.CustomPopupPlacementCallbackProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolTip_CustomPopupPlacementCallback<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback value, Action<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ToolTip.CustomPopupPlacementCallbackProperty!, onChanged);


 // ShowDelay

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ToolTip_ShowDelay<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ToolTip.ShowDelayProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ToolTip_ShowDelay<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ToolTip.ShowDelayProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolTip_ShowDelay<T>(this T control, System.Int32 value, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ToolTip.ShowDelayProperty!, onChanged);


 // BetweenShowDelay

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ToolTip_BetweenShowDelay<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ToolTip.BetweenShowDelayProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ToolTip_BetweenShowDelay<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ToolTip.BetweenShowDelayProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolTip_BetweenShowDelay<T>(this T control, System.Int32 value, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ToolTip.BetweenShowDelayProperty!, onChanged);


 // ShowOnDisabled

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ToolTip_ShowOnDisabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ToolTip.ShowOnDisabledProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ToolTip_ShowOnDisabled<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ToolTip.ShowOnDisabledProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolTip_ShowOnDisabled<T>(this T control, System.Boolean value, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ToolTip.ShowOnDisabledProperty!, onChanged);


 // ServiceEnabled

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ToolTip_ServiceEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ToolTip.ServiceEnabledProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ToolTip_ServiceEnabled<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ToolTip.ServiceEnabledProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolTip_ServiceEnabled<T>(this T control, System.Boolean value, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ToolTip.ServiceEnabledProperty!, onChanged);



}
