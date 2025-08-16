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
public static partial class Expander_MarkupExtensions
{
//================= Properties ======================//
 // ContentTransition

/*ValueSetterGenerator*/
public static T ContentTransition<T>(this T control, Avalonia.Animation.IPageTransition value) where T : Avalonia.Controls.Expander 
=> control._set(() => control.ContentTransition = value!);

/*BindFromFuncSetterGenerator*/
public static T ContentTransition<T>(this T control, Func<Avalonia.Animation.IPageTransition> func, Action<Avalonia.Animation.IPageTransition>? onChanged = null) where T : Avalonia.Controls.Expander 
   => control._set(func, Avalonia.Controls.Expander.ContentTransitionProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ContentTransition<T>(this T control, ISignal<Avalonia.Animation.IPageTransition> signal, Action<Avalonia.Animation.IPageTransition>? onChanged = null) where T : Avalonia.Controls.Expander 
   => control._set(signal, Avalonia.Controls.Expander.ContentTransitionProperty!, onChanged);


 // ExpandDirection

/*ValueSetterGenerator*/
public static T ExpandDirection<T>(this T control, Avalonia.Controls.ExpandDirection value) where T : Avalonia.Controls.Expander 
=> control._set(() => control.ExpandDirection = value!);

/*BindFromFuncSetterGenerator*/
public static T ExpandDirection<T>(this T control, Func<Avalonia.Controls.ExpandDirection> func, Action<Avalonia.Controls.ExpandDirection>? onChanged = null) where T : Avalonia.Controls.Expander 
   => control._set(func, Avalonia.Controls.Expander.ExpandDirectionProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ExpandDirection<T>(this T control, ISignal<Avalonia.Controls.ExpandDirection> signal, Action<Avalonia.Controls.ExpandDirection>? onChanged = null) where T : Avalonia.Controls.Expander 
   => control._set(signal, Avalonia.Controls.Expander.ExpandDirectionProperty!, onChanged);


 // IsExpanded

/*ValueSetterGenerator*/
public static T IsExpanded<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Expander 
=> control._set(() => control.IsExpanded = value!);

/*BindFromFuncSetterGenerator*/
public static T IsExpanded<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Expander 
   => control._set(func, Avalonia.Controls.Expander.IsExpandedProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsExpanded<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Expander 
   => control._set(signal, Avalonia.Controls.Expander.IsExpandedProperty!, onChanged);



//================= Events ======================//
 // Collapsed

/*ActionToEventGenerator*/
public static T OnCollapsed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Expander 
{
  control.AddHandler(Avalonia.Controls.Expander.CollapsedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Expander.CollapsedEvent.RoutingStrategies);
  return control;
}



 // Collapsing

/*ActionToEventGenerator*/
public static T OnCollapsing<T>(this T control, Action<Avalonia.Interactivity.CancelRoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Expander 
{
  control.AddHandler(Avalonia.Controls.Expander.CollapsingEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Expander.CollapsingEvent.RoutingStrategies);
  return control;
}



 // Expanded

/*ActionToEventGenerator*/
public static T OnExpanded<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Expander 
{
  control.AddHandler(Avalonia.Controls.Expander.ExpandedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Expander.ExpandedEvent.RoutingStrategies);
  return control;
}



 // Expanding

/*ActionToEventGenerator*/
public static T OnExpanding<T>(this T control, Action<Avalonia.Interactivity.CancelRoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Expander 
{
  control.AddHandler(Avalonia.Controls.Expander.ExpandingEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Expander.ExpandingEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // ContentTransition

/*ValueStyleSetterGenerator*/
public static Style<T> ContentTransition<T>(this Style<T> style, Avalonia.Animation.IPageTransition value) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.ContentTransitionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ContentTransition<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.ContentTransitionProperty, binding);


 // ExpandDirection

/*ValueStyleSetterGenerator*/
public static Style<T> ExpandDirection<T>(this Style<T> style, Avalonia.Controls.ExpandDirection value) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.ExpandDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ExpandDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.ExpandDirectionProperty, binding);


 // IsExpanded

/*ValueStyleSetterGenerator*/
public static Style<T> IsExpanded<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.IsExpandedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsExpanded<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.IsExpandedProperty, binding);



}
