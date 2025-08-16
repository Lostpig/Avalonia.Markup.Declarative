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
public static partial class StackPanel_MarkupExtensions
{
//================= Properties ======================//
 // Spacing

/*ValueSetterGenerator*/
public static T Spacing<T>(this T control, System.Double value) where T : Avalonia.Controls.StackPanel 
=> control._set(() => control.Spacing = value!);

/*BindFromFuncSetterGenerator*/
public static T Spacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.StackPanel 
   => control._set(func, Avalonia.Controls.StackPanel.SpacingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Spacing<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.StackPanel 
   => control._set(signal, Avalonia.Controls.StackPanel.SpacingProperty!, onChanged);


 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.StackPanel 
=> control._set(() => control.Orientation = value!);

/*BindFromFuncSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null) where T : Avalonia.Controls.StackPanel 
   => control._set(func, Avalonia.Controls.StackPanel.OrientationProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Orientation<T>(this T control, ISignal<Avalonia.Layout.Orientation> signal, Action<Avalonia.Layout.Orientation>? onChanged = null) where T : Avalonia.Controls.StackPanel 
   => control._set(signal, Avalonia.Controls.StackPanel.OrientationProperty!, onChanged);


 // AreHorizontalSnapPointsRegular

/*ValueSetterGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, System.Boolean value) where T : Avalonia.Controls.StackPanel 
=> control._set(() => control.AreHorizontalSnapPointsRegular = value!);

/*BindFromFuncSetterGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.StackPanel 
   => control._set(func, Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.StackPanel 
   => control._set(signal, Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty!, onChanged);


 // AreVerticalSnapPointsRegular

/*ValueSetterGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, System.Boolean value) where T : Avalonia.Controls.StackPanel 
=> control._set(() => control.AreVerticalSnapPointsRegular = value!);

/*BindFromFuncSetterGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.StackPanel 
   => control._set(func, Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.StackPanel 
   => control._set(signal, Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty!, onChanged);



//================= Events ======================//
 // HorizontalSnapPointsChanged

/*ActionToEventGenerator*/
public static T OnHorizontalSnapPointsChanged<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.StackPanel 
{
  control.AddHandler(Avalonia.Controls.StackPanel.HorizontalSnapPointsChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.StackPanel.HorizontalSnapPointsChangedEvent.RoutingStrategies);
  return control;
}



 // VerticalSnapPointsChanged

/*ActionToEventGenerator*/
public static T OnVerticalSnapPointsChanged<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.StackPanel 
{
  control.AddHandler(Avalonia.Controls.StackPanel.VerticalSnapPointsChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.StackPanel.VerticalSnapPointsChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Spacing

/*ValueStyleSetterGenerator*/
public static Style<T> Spacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.StackPanel 
=> style._addSetter(Avalonia.Controls.StackPanel.SpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Spacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.StackPanel 
=> style._addSetter(Avalonia.Controls.StackPanel.SpacingProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.StackPanel 
=> style._addSetter(Avalonia.Controls.StackPanel.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.StackPanel 
=> style._addSetter(Avalonia.Controls.StackPanel.OrientationProperty, binding);


 // AreHorizontalSnapPointsRegular

/*ValueStyleSetterGenerator*/
public static Style<T> AreHorizontalSnapPointsRegular<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.StackPanel 
=> style._addSetter(Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AreHorizontalSnapPointsRegular<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.StackPanel 
=> style._addSetter(Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty, binding);


 // AreVerticalSnapPointsRegular

/*ValueStyleSetterGenerator*/
public static Style<T> AreVerticalSnapPointsRegular<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.StackPanel 
=> style._addSetter(Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AreVerticalSnapPointsRegular<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.StackPanel 
=> style._addSetter(Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty, binding);



}
