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
public static partial class ScrollViewer_MarkupExtensions
{
//================= Properties ======================//
 // BringIntoViewOnFocusChange

/*ValueSetterGenerator*/
public static T BringIntoViewOnFocusChange<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
=> control._set(() => control.BringIntoViewOnFocusChange = value!);

/*BindFromFuncSetterGenerator*/
public static T BringIntoViewOnFocusChange<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(func, Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T BringIntoViewOnFocusChange<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(signal, Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty!, onChanged);


 // Offset

/*ValueSetterGenerator*/
public static T Offset<T>(this T control, Avalonia.Vector value) where T : Avalonia.Controls.ScrollViewer 
=> control._set(() => control.Offset = value!);

/*BindFromFuncSetterGenerator*/
public static T Offset<T>(this T control, Func<Avalonia.Vector> func, Action<Avalonia.Vector>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(func, Avalonia.Controls.ScrollViewer.OffsetProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Offset<T>(this T control, ISignal<Avalonia.Vector> signal, Action<Avalonia.Vector>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(signal, Avalonia.Controls.ScrollViewer.OffsetProperty!, onChanged);


 // HorizontalScrollBarVisibility

/*ValueSetterGenerator*/
public static T HorizontalScrollBarVisibility<T>(this T control, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.ScrollViewer 
=> control._set(() => control.HorizontalScrollBarVisibility = value!);

/*BindFromFuncSetterGenerator*/
public static T HorizontalScrollBarVisibility<T>(this T control, Func<Avalonia.Controls.Primitives.ScrollBarVisibility> func, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(func, Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HorizontalScrollBarVisibility<T>(this T control, ISignal<Avalonia.Controls.Primitives.ScrollBarVisibility> signal, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(signal, Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty!, onChanged);


 // HorizontalSnapPointsType

/*ValueSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.ScrollViewer 
=> control._set(() => control.HorizontalSnapPointsType = value!);

/*BindFromFuncSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(func, Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, ISignal<Avalonia.Controls.Primitives.SnapPointsType> signal, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(signal, Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty!, onChanged);


 // VerticalSnapPointsType

/*ValueSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.ScrollViewer 
=> control._set(() => control.VerticalSnapPointsType = value!);

/*BindFromFuncSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(func, Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, ISignal<Avalonia.Controls.Primitives.SnapPointsType> signal, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(signal, Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty!, onChanged);


 // HorizontalSnapPointsAlignment

/*ValueSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.ScrollViewer 
=> control._set(() => control.HorizontalSnapPointsAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(func, Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, ISignal<Avalonia.Controls.Primitives.SnapPointsAlignment> signal, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(signal, Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty!, onChanged);


 // VerticalSnapPointsAlignment

/*ValueSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.ScrollViewer 
=> control._set(() => control.VerticalSnapPointsAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(func, Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, ISignal<Avalonia.Controls.Primitives.SnapPointsAlignment> signal, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(signal, Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty!, onChanged);


 // VerticalScrollBarVisibility

/*ValueSetterGenerator*/
public static T VerticalScrollBarVisibility<T>(this T control, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.ScrollViewer 
=> control._set(() => control.VerticalScrollBarVisibility = value!);

/*BindFromFuncSetterGenerator*/
public static T VerticalScrollBarVisibility<T>(this T control, Func<Avalonia.Controls.Primitives.ScrollBarVisibility> func, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(func, Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T VerticalScrollBarVisibility<T>(this T control, ISignal<Avalonia.Controls.Primitives.ScrollBarVisibility> signal, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(signal, Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty!, onChanged);


 // AllowAutoHide

/*ValueSetterGenerator*/
public static T AllowAutoHide<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
=> control._set(() => control.AllowAutoHide = value!);

/*BindFromFuncSetterGenerator*/
public static T AllowAutoHide<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(func, Avalonia.Controls.ScrollViewer.AllowAutoHideProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T AllowAutoHide<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(signal, Avalonia.Controls.ScrollViewer.AllowAutoHideProperty!, onChanged);


 // IsScrollChainingEnabled

/*ValueSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
=> control._set(() => control.IsScrollChainingEnabled = value!);

/*BindFromFuncSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(func, Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(signal, Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty!, onChanged);


 // IsScrollInertiaEnabled

/*ValueSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
=> control._set(() => control.IsScrollInertiaEnabled = value!);

/*BindFromFuncSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(func, Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(signal, Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty!, onChanged);


 // IsDeferredScrollingEnabled

/*ValueSetterGenerator*/
public static T IsDeferredScrollingEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
=> control._set(() => control.IsDeferredScrollingEnabled = value!);

/*BindFromFuncSetterGenerator*/
public static T IsDeferredScrollingEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(func, Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsDeferredScrollingEnabled<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(signal, Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty!, onChanged);



//================= Attached Properties ======================//
 // BringIntoViewOnFocusChange

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ScrollViewer_BringIntoViewOnFocusChange<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ScrollViewer_BringIntoViewOnFocusChange<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_BringIntoViewOnFocusChange<T>(this T control, System.Boolean value, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty!, onChanged);


 // HorizontalScrollBarVisibility

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ScrollViewer_HorizontalScrollBarVisibility<T>(this T control, Func<Avalonia.Controls.Primitives.ScrollBarVisibility> func, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ScrollViewer_HorizontalScrollBarVisibility<T>(this T control, ISignal<Avalonia.Controls.Primitives.ScrollBarVisibility> signal, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_HorizontalScrollBarVisibility<T>(this T control, Avalonia.Controls.Primitives.ScrollBarVisibility value, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty!, onChanged);


 // HorizontalSnapPointsType

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ScrollViewer_HorizontalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ScrollViewer_HorizontalSnapPointsType<T>(this T control, ISignal<Avalonia.Controls.Primitives.SnapPointsType> signal, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_HorizontalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty!, onChanged);


 // VerticalSnapPointsType

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ScrollViewer_VerticalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ScrollViewer_VerticalSnapPointsType<T>(this T control, ISignal<Avalonia.Controls.Primitives.SnapPointsType> signal, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_VerticalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty!, onChanged);


 // HorizontalSnapPointsAlignment

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ScrollViewer_HorizontalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ScrollViewer_HorizontalSnapPointsAlignment<T>(this T control, ISignal<Avalonia.Controls.Primitives.SnapPointsAlignment> signal, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_HorizontalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty!, onChanged);


 // VerticalSnapPointsAlignment

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ScrollViewer_VerticalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ScrollViewer_VerticalSnapPointsAlignment<T>(this T control, ISignal<Avalonia.Controls.Primitives.SnapPointsAlignment> signal, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_VerticalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty!, onChanged);


 // VerticalScrollBarVisibility

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ScrollViewer_VerticalScrollBarVisibility<T>(this T control, Func<Avalonia.Controls.Primitives.ScrollBarVisibility> func, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ScrollViewer_VerticalScrollBarVisibility<T>(this T control, ISignal<Avalonia.Controls.Primitives.ScrollBarVisibility> signal, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_VerticalScrollBarVisibility<T>(this T control, Avalonia.Controls.Primitives.ScrollBarVisibility value, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty!, onChanged);


 // AllowAutoHide

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ScrollViewer_AllowAutoHide<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ScrollViewer.AllowAutoHideProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ScrollViewer_AllowAutoHide<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ScrollViewer.AllowAutoHideProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_AllowAutoHide<T>(this T control, System.Boolean value, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ScrollViewer.AllowAutoHideProperty!, onChanged);


 // IsScrollChainingEnabled

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ScrollViewer_IsScrollChainingEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ScrollViewer_IsScrollChainingEnabled<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_IsScrollChainingEnabled<T>(this T control, System.Boolean value, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty!, onChanged);


 // IsScrollInertiaEnabled

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ScrollViewer_IsScrollInertiaEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ScrollViewer_IsScrollInertiaEnabled<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_IsScrollInertiaEnabled<T>(this T control, System.Boolean value, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty!, onChanged);


 // IsDeferredScrollingEnabled

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T ScrollViewer_IsDeferredScrollingEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T ScrollViewer_IsDeferredScrollingEnabled<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_IsDeferredScrollingEnabled<T>(this T control, System.Boolean value, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty!, onChanged);



//================= Events ======================//
 // ScrollChanged

/*ActionToEventGenerator*/
public static T OnScrollChanged<T>(this T control, Action<Avalonia.Controls.ScrollChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.ScrollViewer 
{
  control.AddHandler(Avalonia.Controls.ScrollViewer.ScrollChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.ScrollViewer.ScrollChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // BringIntoViewOnFocusChange

/*ValueStyleSetterGenerator*/
public static Style<T> BringIntoViewOnFocusChange<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BringIntoViewOnFocusChange<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, binding);


 // Offset

/*ValueStyleSetterGenerator*/
public static Style<T> Offset<T>(this Style<T> style, Avalonia.Vector value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.OffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Offset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.OffsetProperty, binding);


 // HorizontalScrollBarVisibility

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalScrollBarVisibility<T>(this Style<T> style, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalScrollBarVisibility<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, binding);


 // HorizontalSnapPointsType

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, binding);


 // VerticalSnapPointsType

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, binding);


 // HorizontalSnapPointsAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, binding);


 // VerticalSnapPointsAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, binding);


 // VerticalScrollBarVisibility

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalScrollBarVisibility<T>(this Style<T> style, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalScrollBarVisibility<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, binding);


 // AllowAutoHide

/*ValueStyleSetterGenerator*/
public static Style<T> AllowAutoHide<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AllowAutoHide<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, binding);


 // IsScrollChainingEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, binding);


 // IsScrollInertiaEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsScrollInertiaEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsScrollInertiaEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, binding);


 // IsDeferredScrollingEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsDeferredScrollingEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDeferredScrollingEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, binding);



}
