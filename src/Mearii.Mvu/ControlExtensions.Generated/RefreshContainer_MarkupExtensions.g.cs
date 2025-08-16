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
public static partial class RefreshContainer_MarkupExtensions
{
//================= Properties ======================//
 // Visualizer

/*ValueSetterGenerator*/
public static T Visualizer<T>(this T control, Avalonia.Controls.RefreshVisualizer value) where T : Avalonia.Controls.RefreshContainer 
=> control._set(() => control.Visualizer = value!);

/*BindFromFuncSetterGenerator*/
public static T Visualizer<T>(this T control, Func<Avalonia.Controls.RefreshVisualizer> func, Action<Avalonia.Controls.RefreshVisualizer>? onChanged = null) where T : Avalonia.Controls.RefreshContainer 
   => control._set(func, Avalonia.Controls.RefreshContainer.VisualizerProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Visualizer<T>(this T control, ISignal<Avalonia.Controls.RefreshVisualizer> signal, Action<Avalonia.Controls.RefreshVisualizer>? onChanged = null) where T : Avalonia.Controls.RefreshContainer 
   => control._set(signal, Avalonia.Controls.RefreshContainer.VisualizerProperty!, onChanged);


 // PullDirection

/*ValueSetterGenerator*/
public static T PullDirection<T>(this T control, Avalonia.Input.PullDirection value) where T : Avalonia.Controls.RefreshContainer 
=> control._set(() => control.PullDirection = value!);

/*BindFromFuncSetterGenerator*/
public static T PullDirection<T>(this T control, Func<Avalonia.Input.PullDirection> func, Action<Avalonia.Input.PullDirection>? onChanged = null) where T : Avalonia.Controls.RefreshContainer 
   => control._set(func, Avalonia.Controls.RefreshContainer.PullDirectionProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PullDirection<T>(this T control, ISignal<Avalonia.Input.PullDirection> signal, Action<Avalonia.Input.PullDirection>? onChanged = null) where T : Avalonia.Controls.RefreshContainer 
   => control._set(signal, Avalonia.Controls.RefreshContainer.PullDirectionProperty!, onChanged);



//================= Events ======================//
 // RefreshRequested

/*ActionToEventGenerator*/
public static T OnRefreshRequested<T>(this T control, Action<Avalonia.Controls.RefreshRequestedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.RefreshContainer 
{
  control.AddHandler(Avalonia.Controls.RefreshContainer.RefreshRequestedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.RefreshContainer.RefreshRequestedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // PullDirection

/*ValueStyleSetterGenerator*/
public static Style<T> PullDirection<T>(this Style<T> style, Avalonia.Input.PullDirection value) where T : Avalonia.Controls.RefreshContainer 
=> style._addSetter(Avalonia.Controls.RefreshContainer.PullDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PullDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.RefreshContainer 
=> style._addSetter(Avalonia.Controls.RefreshContainer.PullDirectionProperty, binding);



}
