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
public static partial class ToggleButton_MarkupExtensions
{
//================= Properties ======================//
 // IsChecked

/*ValueSetterGenerator*/
public static T IsChecked<T>(this T control, System.Nullable<System.Boolean> value) where T : Avalonia.Controls.Primitives.ToggleButton 
=> control._set(() => control.IsChecked = value!);

/*BindFromFuncSetterGenerator*/
public static T IsChecked<T>(this T control, Func<System.Nullable<System.Boolean>> func, Action<System.Nullable<System.Boolean>>? onChanged = null) where T : Avalonia.Controls.Primitives.ToggleButton 
   => control._set(func, Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsChecked<T>(this T control, ISignal<System.Nullable<System.Boolean>> signal, Action<System.Nullable<System.Boolean>>? onChanged = null) where T : Avalonia.Controls.Primitives.ToggleButton 
   => control._set(signal, Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty!, onChanged);


 // IsThreeState

/*ValueSetterGenerator*/
public static T IsThreeState<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.ToggleButton 
=> control._set(() => control.IsThreeState = value!);

/*BindFromFuncSetterGenerator*/
public static T IsThreeState<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.ToggleButton 
   => control._set(func, Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsThreeState<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.ToggleButton 
   => control._set(signal, Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty!, onChanged);



//================= Events ======================//
 // Checked

/*ActionToEventGenerator*/
[Obsolete]public static T OnChecked<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.ToggleButton 
{
  control.AddHandler(Avalonia.Controls.Primitives.ToggleButton.CheckedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Primitives.ToggleButton.CheckedEvent.RoutingStrategies);
  return control;
}



 // Unchecked

/*ActionToEventGenerator*/
[Obsolete]public static T OnUnchecked<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.ToggleButton 
{
  control.AddHandler(Avalonia.Controls.Primitives.ToggleButton.UncheckedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Primitives.ToggleButton.UncheckedEvent.RoutingStrategies);
  return control;
}



 // Indeterminate

/*ActionToEventGenerator*/
[Obsolete]public static T OnIndeterminate<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.ToggleButton 
{
  control.AddHandler(Avalonia.Controls.Primitives.ToggleButton.IndeterminateEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Primitives.ToggleButton.IndeterminateEvent.RoutingStrategies);
  return control;
}



 // IsCheckedChanged

/*ActionToEventGenerator*/
public static T OnIsCheckedChanged<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.ToggleButton 
{
  control.AddHandler(Avalonia.Controls.Primitives.ToggleButton.IsCheckedChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Primitives.ToggleButton.IsCheckedChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // IsChecked

/*ValueStyleSetterGenerator*/
public static Style<T> IsChecked<T>(this Style<T> style, System.Nullable<System.Boolean> value) where T : Avalonia.Controls.Primitives.ToggleButton 
=> style._addSetter(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsChecked<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ToggleButton 
=> style._addSetter(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty, binding);


 // IsThreeState

/*ValueStyleSetterGenerator*/
public static Style<T> IsThreeState<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.ToggleButton 
=> style._addSetter(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsThreeState<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ToggleButton 
=> style._addSetter(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty, binding);



}
