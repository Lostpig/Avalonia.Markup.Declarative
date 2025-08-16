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
public static partial class Control_MarkupExtensions
{
//================= Properties ======================//
 // FocusAdorner

/*ValueSetterGenerator*/
public static T FocusAdorner<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.Control 
=> control._set(() => control.FocusAdorner = value!);

/*BindFromFuncSetterGenerator*/
public static T FocusAdorner<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.Control.FocusAdornerProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FocusAdorner<T>(this T control, ISignal<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> signal, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.Control.FocusAdornerProperty!, onChanged);


 // Tag

/*ValueSetterGenerator*/
public static T Tag<T>(this T control, System.Object value) where T : Avalonia.Controls.Control 
=> control._set(() => control.Tag = value!);

/*BindFromFuncSetterGenerator*/
public static T Tag<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.Control.TagProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Tag<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.Control.TagProperty!, onChanged);


 // ContextMenu

/*ValueSetterGenerator*/
public static T ContextMenu<T>(this T control, Avalonia.Controls.ContextMenu value) where T : Avalonia.Controls.Control 
=> control._set(() => control.ContextMenu = value!);

/*BindFromFuncSetterGenerator*/
public static T ContextMenu<T>(this T control, Func<Avalonia.Controls.ContextMenu> func, Action<Avalonia.Controls.ContextMenu>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.Control.ContextMenuProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ContextMenu<T>(this T control, ISignal<Avalonia.Controls.ContextMenu> signal, Action<Avalonia.Controls.ContextMenu>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.Control.ContextMenuProperty!, onChanged);


 // ContextFlyout

/*ValueSetterGenerator*/
public static T ContextFlyout<T>(this T control, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.Control 
=> control._set(() => control.ContextFlyout = value!);

/*BindFromFuncSetterGenerator*/
public static T ContextFlyout<T>(this T control, Func<Avalonia.Controls.Primitives.FlyoutBase> func, Action<Avalonia.Controls.Primitives.FlyoutBase>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.Control.ContextFlyoutProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ContextFlyout<T>(this T control, ISignal<Avalonia.Controls.Primitives.FlyoutBase> signal, Action<Avalonia.Controls.Primitives.FlyoutBase>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.Control.ContextFlyoutProperty!, onChanged);



//================= Events ======================//
 // ContextRequested

/*ActionToEventGenerator*/
public static T OnContextRequested<T>(this T control, Action<Avalonia.Controls.ContextRequestedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Control 
{
  control.AddHandler(Avalonia.Controls.Control.ContextRequestedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Control.ContextRequestedEvent.RoutingStrategies);
  return control;
}



 // Loaded

/*ActionToEventGenerator*/
public static T OnLoaded<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Control 
{
  control.AddHandler(Avalonia.Controls.Control.LoadedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Control.LoadedEvent.RoutingStrategies);
  return control;
}



 // Unloaded

/*ActionToEventGenerator*/
public static T OnUnloaded<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Control 
{
  control.AddHandler(Avalonia.Controls.Control.UnloadedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Control.UnloadedEvent.RoutingStrategies);
  return control;
}



 // SizeChanged

/*ActionToEventGenerator*/
public static T OnSizeChanged<T>(this T control, Action<Avalonia.Controls.SizeChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Control 
{
  control.AddHandler(Avalonia.Controls.Control.SizeChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Control.SizeChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // FocusAdorner

/*ValueStyleSetterGenerator*/
public static Style<T> FocusAdorner<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.FocusAdornerProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FocusAdorner<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.FocusAdornerProperty, binding);


 // Tag

/*ValueStyleSetterGenerator*/
public static Style<T> Tag<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.TagProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Tag<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.TagProperty, binding);


 // ContextMenu

/*ValueStyleSetterGenerator*/
public static Style<T> ContextMenu<T>(this Style<T> style, Avalonia.Controls.ContextMenu value) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.ContextMenuProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ContextMenu<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.ContextMenuProperty, binding);


 // ContextFlyout

/*ValueStyleSetterGenerator*/
public static Style<T> ContextFlyout<T>(this Style<T> style, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.ContextFlyoutProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ContextFlyout<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.ContextFlyoutProperty, binding);



}
