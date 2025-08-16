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
public static partial class RefreshVisualizer_MarkupExtensions
{
//================= Properties ======================//
 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Controls.RefreshVisualizerOrientation value) where T : Avalonia.Controls.RefreshVisualizer 
=> control._set(() => control.Orientation = value!);

/*BindFromFuncSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Controls.RefreshVisualizerOrientation> func, Action<Avalonia.Controls.RefreshVisualizerOrientation>? onChanged = null) where T : Avalonia.Controls.RefreshVisualizer 
   => control._set(func, Avalonia.Controls.RefreshVisualizer.OrientationProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Orientation<T>(this T control, ISignal<Avalonia.Controls.RefreshVisualizerOrientation> signal, Action<Avalonia.Controls.RefreshVisualizerOrientation>? onChanged = null) where T : Avalonia.Controls.RefreshVisualizer 
   => control._set(signal, Avalonia.Controls.RefreshVisualizer.OrientationProperty!, onChanged);



//================= Events ======================//
 // RefreshRequested

/*ActionToEventGenerator*/
public static T OnRefreshRequested<T>(this T control, Action<Avalonia.Controls.RefreshRequestedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.RefreshVisualizer 
{
  control.AddHandler(Avalonia.Controls.RefreshVisualizer.RefreshRequestedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.RefreshVisualizer.RefreshRequestedEvent.RoutingStrategies);
  return control;
}




}
