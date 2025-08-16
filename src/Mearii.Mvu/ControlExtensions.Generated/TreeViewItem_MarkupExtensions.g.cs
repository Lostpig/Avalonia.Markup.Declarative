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
public static partial class TreeViewItem_MarkupExtensions
{
//================= Properties ======================//
 // IsExpanded

/*ValueSetterGenerator*/
public static T IsExpanded<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TreeViewItem 
=> control._set(() => control.IsExpanded = value!);

/*BindFromFuncSetterGenerator*/
public static T IsExpanded<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TreeViewItem 
   => control._set(func, Avalonia.Controls.TreeViewItem.IsExpandedProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsExpanded<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TreeViewItem 
   => control._set(signal, Avalonia.Controls.TreeViewItem.IsExpandedProperty!, onChanged);


 // IsSelected

/*ValueSetterGenerator*/
public static T IsSelected<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TreeViewItem 
=> control._set(() => control.IsSelected = value!);

/*BindFromFuncSetterGenerator*/
public static T IsSelected<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TreeViewItem 
   => control._set(func, Avalonia.Controls.TreeViewItem.IsSelectedProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsSelected<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TreeViewItem 
   => control._set(signal, Avalonia.Controls.TreeViewItem.IsSelectedProperty!, onChanged);



//================= Events ======================//
 // Expanded

/*ActionToEventGenerator*/
public static T OnExpanded<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TreeViewItem 
{
  control.AddHandler(Avalonia.Controls.TreeViewItem.ExpandedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TreeViewItem.ExpandedEvent.RoutingStrategies);
  return control;
}



 // Collapsed

/*ActionToEventGenerator*/
public static T OnCollapsed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TreeViewItem 
{
  control.AddHandler(Avalonia.Controls.TreeViewItem.CollapsedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TreeViewItem.CollapsedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // IsExpanded

/*ValueStyleSetterGenerator*/
public static Style<T> IsExpanded<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TreeViewItem 
=> style._addSetter(Avalonia.Controls.TreeViewItem.IsExpandedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsExpanded<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TreeViewItem 
=> style._addSetter(Avalonia.Controls.TreeViewItem.IsExpandedProperty, binding);


 // IsSelected

/*ValueStyleSetterGenerator*/
public static Style<T> IsSelected<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TreeViewItem 
=> style._addSetter(Avalonia.Controls.TreeViewItem.IsSelectedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSelected<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TreeViewItem 
=> style._addSetter(Avalonia.Controls.TreeViewItem.IsSelectedProperty, binding);



}
