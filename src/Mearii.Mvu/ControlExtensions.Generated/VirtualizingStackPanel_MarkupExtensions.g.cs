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
public static partial class VirtualizingStackPanel_MarkupExtensions
{
//================= Properties ======================//
 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.VirtualizingStackPanel 
=> control._set(() => control.Orientation = value!);

/*BindFromFuncSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(func, Avalonia.Controls.VirtualizingStackPanel.OrientationProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Orientation<T>(this T control, ISignal<Avalonia.Layout.Orientation> signal, Action<Avalonia.Layout.Orientation>? onChanged = null) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(signal, Avalonia.Controls.VirtualizingStackPanel.OrientationProperty!, onChanged);


 // AreHorizontalSnapPointsRegular

/*ValueSetterGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, System.Boolean value) where T : Avalonia.Controls.VirtualizingStackPanel 
=> control._set(() => control.AreHorizontalSnapPointsRegular = value!);

/*BindFromFuncSetterGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(func, Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(signal, Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty!, onChanged);


 // AreVerticalSnapPointsRegular

/*ValueSetterGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, System.Boolean value) where T : Avalonia.Controls.VirtualizingStackPanel 
=> control._set(() => control.AreVerticalSnapPointsRegular = value!);

/*BindFromFuncSetterGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(func, Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(signal, Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty!, onChanged);



//================= Events ======================//
 // HorizontalSnapPointsChanged

/*ActionToEventGenerator*/
public static T OnHorizontalSnapPointsChanged<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.VirtualizingStackPanel 
{
  control.AddHandler(Avalonia.Controls.VirtualizingStackPanel.HorizontalSnapPointsChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.VirtualizingStackPanel.HorizontalSnapPointsChangedEvent.RoutingStrategies);
  return control;
}



 // VerticalSnapPointsChanged

/*ActionToEventGenerator*/
public static T OnVerticalSnapPointsChanged<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.VirtualizingStackPanel 
{
  control.AddHandler(Avalonia.Controls.VirtualizingStackPanel.VerticalSnapPointsChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.VirtualizingStackPanel.VerticalSnapPointsChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.OrientationProperty, binding);


 // AreHorizontalSnapPointsRegular

/*ValueStyleSetterGenerator*/
public static Style<T> AreHorizontalSnapPointsRegular<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AreHorizontalSnapPointsRegular<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, binding);


 // AreVerticalSnapPointsRegular

/*ValueStyleSetterGenerator*/
public static Style<T> AreVerticalSnapPointsRegular<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AreVerticalSnapPointsRegular<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, binding);



}
