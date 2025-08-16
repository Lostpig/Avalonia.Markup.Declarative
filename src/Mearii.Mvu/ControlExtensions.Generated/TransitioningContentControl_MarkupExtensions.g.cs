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
public static partial class TransitioningContentControl_MarkupExtensions
{
//================= Properties ======================//
 // PageTransition

/*ValueSetterGenerator*/
public static T PageTransition<T>(this T control, Avalonia.Animation.IPageTransition value) where T : Avalonia.Controls.TransitioningContentControl 
=> control._set(() => control.PageTransition = value!);

/*BindFromFuncSetterGenerator*/
public static T PageTransition<T>(this T control, Func<Avalonia.Animation.IPageTransition> func, Action<Avalonia.Animation.IPageTransition>? onChanged = null) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(func, Avalonia.Controls.TransitioningContentControl.PageTransitionProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PageTransition<T>(this T control, ISignal<Avalonia.Animation.IPageTransition> signal, Action<Avalonia.Animation.IPageTransition>? onChanged = null) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(signal, Avalonia.Controls.TransitioningContentControl.PageTransitionProperty!, onChanged);


 // IsTransitionReversed

/*ValueSetterGenerator*/
public static T IsTransitionReversed<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TransitioningContentControl 
=> control._set(() => control.IsTransitionReversed = value!);

/*BindFromFuncSetterGenerator*/
public static T IsTransitionReversed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(func, Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsTransitionReversed<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(signal, Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty!, onChanged);



//================= Events ======================//
 // TransitionCompleted

/*ActionToEventGenerator*/
public static T OnTransitionCompleted<T>(this T control, Action<Avalonia.Controls.TransitionCompletedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TransitioningContentControl 
{
  control.AddHandler(Avalonia.Controls.TransitioningContentControl.TransitionCompletedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TransitioningContentControl.TransitionCompletedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // PageTransition

/*ValueStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, Avalonia.Animation.IPageTransition value) where T : Avalonia.Controls.TransitioningContentControl 
=> style._addSetter(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TransitioningContentControl 
=> style._addSetter(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, binding);


 // IsTransitionReversed

/*ValueStyleSetterGenerator*/
public static Style<T> IsTransitionReversed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TransitioningContentControl 
=> style._addSetter(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTransitionReversed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TransitioningContentControl 
=> style._addSetter(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty, binding);



}
