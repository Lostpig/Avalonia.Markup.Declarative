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
public static partial class SplitView_MarkupExtensions
{
//================= Properties ======================//
 // CompactPaneLength

/*ValueSetterGenerator*/
public static T CompactPaneLength<T>(this T control, System.Double value) where T : Avalonia.Controls.SplitView 
=> control._set(() => control.CompactPaneLength = value!);

/*BindFromFuncSetterGenerator*/
public static T CompactPaneLength<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.SplitView 
   => control._set(func, Avalonia.Controls.SplitView.CompactPaneLengthProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CompactPaneLength<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.SplitView 
   => control._set(signal, Avalonia.Controls.SplitView.CompactPaneLengthProperty!, onChanged);


 // DisplayMode

/*ValueSetterGenerator*/
public static T DisplayMode<T>(this T control, Avalonia.Controls.SplitViewDisplayMode value) where T : Avalonia.Controls.SplitView 
=> control._set(() => control.DisplayMode = value!);

/*BindFromFuncSetterGenerator*/
public static T DisplayMode<T>(this T control, Func<Avalonia.Controls.SplitViewDisplayMode> func, Action<Avalonia.Controls.SplitViewDisplayMode>? onChanged = null) where T : Avalonia.Controls.SplitView 
   => control._set(func, Avalonia.Controls.SplitView.DisplayModeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T DisplayMode<T>(this T control, ISignal<Avalonia.Controls.SplitViewDisplayMode> signal, Action<Avalonia.Controls.SplitViewDisplayMode>? onChanged = null) where T : Avalonia.Controls.SplitView 
   => control._set(signal, Avalonia.Controls.SplitView.DisplayModeProperty!, onChanged);


 // IsPaneOpen

/*ValueSetterGenerator*/
public static T IsPaneOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.SplitView 
=> control._set(() => control.IsPaneOpen = value!);

/*BindFromFuncSetterGenerator*/
public static T IsPaneOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.SplitView 
   => control._set(func, Avalonia.Controls.SplitView.IsPaneOpenProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsPaneOpen<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.SplitView 
   => control._set(signal, Avalonia.Controls.SplitView.IsPaneOpenProperty!, onChanged);


 // OpenPaneLength

/*ValueSetterGenerator*/
public static T OpenPaneLength<T>(this T control, System.Double value) where T : Avalonia.Controls.SplitView 
=> control._set(() => control.OpenPaneLength = value!);

/*BindFromFuncSetterGenerator*/
public static T OpenPaneLength<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.SplitView 
   => control._set(func, Avalonia.Controls.SplitView.OpenPaneLengthProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T OpenPaneLength<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.SplitView 
   => control._set(signal, Avalonia.Controls.SplitView.OpenPaneLengthProperty!, onChanged);


 // PaneBackground

/*ValueSetterGenerator*/
public static T PaneBackground<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.SplitView 
=> control._set(() => control.PaneBackground = value!);

/*BindFromFuncSetterGenerator*/
public static T PaneBackground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.SplitView 
   => control._set(func, Avalonia.Controls.SplitView.PaneBackgroundProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PaneBackground<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.SplitView 
   => control._set(signal, Avalonia.Controls.SplitView.PaneBackgroundProperty!, onChanged);


 // PanePlacement

/*ValueSetterGenerator*/
public static T PanePlacement<T>(this T control, Avalonia.Controls.SplitViewPanePlacement value) where T : Avalonia.Controls.SplitView 
=> control._set(() => control.PanePlacement = value!);

/*BindFromFuncSetterGenerator*/
public static T PanePlacement<T>(this T control, Func<Avalonia.Controls.SplitViewPanePlacement> func, Action<Avalonia.Controls.SplitViewPanePlacement>? onChanged = null) where T : Avalonia.Controls.SplitView 
   => control._set(func, Avalonia.Controls.SplitView.PanePlacementProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PanePlacement<T>(this T control, ISignal<Avalonia.Controls.SplitViewPanePlacement> signal, Action<Avalonia.Controls.SplitViewPanePlacement>? onChanged = null) where T : Avalonia.Controls.SplitView 
   => control._set(signal, Avalonia.Controls.SplitView.PanePlacementProperty!, onChanged);


 // Pane

/*ValueSetterGenerator*/
public static T Pane<T>(this T control, System.Object value) where T : Avalonia.Controls.SplitView 
=> control._set(() => control.Pane = value!);

/*BindFromFuncSetterGenerator*/
public static T Pane<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.SplitView 
   => control._set(func, Avalonia.Controls.SplitView.PaneProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Pane<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.SplitView 
   => control._set(signal, Avalonia.Controls.SplitView.PaneProperty!, onChanged);


 // PaneTemplate

/*ValueSetterGenerator*/
public static T PaneTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.SplitView 
=> control._set(() => control.PaneTemplate = value!);

/*BindFromFuncSetterGenerator*/
public static T PaneTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.SplitView 
   => control._set(func, Avalonia.Controls.SplitView.PaneTemplateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PaneTemplate<T>(this T control, ISignal<Avalonia.Controls.Templates.IDataTemplate> signal, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.SplitView 
   => control._set(signal, Avalonia.Controls.SplitView.PaneTemplateProperty!, onChanged);


 // UseLightDismissOverlayMode

/*ValueSetterGenerator*/
public static T UseLightDismissOverlayMode<T>(this T control, System.Boolean value) where T : Avalonia.Controls.SplitView 
=> control._set(() => control.UseLightDismissOverlayMode = value!);

/*BindFromFuncSetterGenerator*/
public static T UseLightDismissOverlayMode<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.SplitView 
   => control._set(func, Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T UseLightDismissOverlayMode<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.SplitView 
   => control._set(signal, Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty!, onChanged);



//================= Events ======================//
 // PaneClosed

/*ActionToEventGenerator*/
public static T OnPaneClosed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SplitView 
{
  control.AddHandler(Avalonia.Controls.SplitView.PaneClosedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.SplitView.PaneClosedEvent.RoutingStrategies);
  return control;
}



 // PaneClosing

/*ActionToEventGenerator*/
public static T OnPaneClosing<T>(this T control, Action<Avalonia.Interactivity.CancelRoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SplitView 
{
  control.AddHandler(Avalonia.Controls.SplitView.PaneClosingEvent, (_, args) => action(args), routes ?? Avalonia.Controls.SplitView.PaneClosingEvent.RoutingStrategies);
  return control;
}



 // PaneOpened

/*ActionToEventGenerator*/
public static T OnPaneOpened<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SplitView 
{
  control.AddHandler(Avalonia.Controls.SplitView.PaneOpenedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.SplitView.PaneOpenedEvent.RoutingStrategies);
  return control;
}



 // PaneOpening

/*ActionToEventGenerator*/
public static T OnPaneOpening<T>(this T control, Action<Avalonia.Interactivity.CancelRoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SplitView 
{
  control.AddHandler(Avalonia.Controls.SplitView.PaneOpeningEvent, (_, args) => action(args), routes ?? Avalonia.Controls.SplitView.PaneOpeningEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // CompactPaneLength

/*ValueStyleSetterGenerator*/
public static Style<T> CompactPaneLength<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.CompactPaneLengthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CompactPaneLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.CompactPaneLengthProperty, binding);


 // DisplayMode

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayMode<T>(this Style<T> style, Avalonia.Controls.SplitViewDisplayMode value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.DisplayModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.DisplayModeProperty, binding);


 // IsPaneOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsPaneOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.IsPaneOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsPaneOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.IsPaneOpenProperty, binding);


 // OpenPaneLength

/*ValueStyleSetterGenerator*/
public static Style<T> OpenPaneLength<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.OpenPaneLengthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OpenPaneLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.OpenPaneLengthProperty, binding);


 // PaneBackground

/*ValueStyleSetterGenerator*/
public static Style<T> PaneBackground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneBackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PaneBackground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneBackgroundProperty, binding);


 // PanePlacement

/*ValueStyleSetterGenerator*/
public static Style<T> PanePlacement<T>(this Style<T> style, Avalonia.Controls.SplitViewPanePlacement value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PanePlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PanePlacement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PanePlacementProperty, binding);


 // Pane

/*ValueStyleSetterGenerator*/
public static Style<T> Pane<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Pane<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneProperty, binding);


 // PaneTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> PaneTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PaneTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneTemplateProperty, binding);


 // UseLightDismissOverlayMode

/*ValueStyleSetterGenerator*/
public static Style<T> UseLightDismissOverlayMode<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseLightDismissOverlayMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty, binding);



}
