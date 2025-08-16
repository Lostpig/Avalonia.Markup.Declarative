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
public static partial class MenuItem_MarkupExtensions
{
//================= Properties ======================//
 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand value) where T : Avalonia.Controls.MenuItem 
=> control._set(() => control.Command = value!);

/*BindFromFuncSetterGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(func, Avalonia.Controls.MenuItem.CommandProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Command<T>(this T control, ISignal<System.Windows.Input.ICommand> signal, Action<System.Windows.Input.ICommand>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(signal, Avalonia.Controls.MenuItem.CommandProperty!, onChanged);


 // HotKey

/*ValueSetterGenerator*/
public static T HotKey<T>(this T control, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.MenuItem 
=> control._set(() => control.HotKey = value!);

/*BindFromFuncSetterGenerator*/
public static T HotKey<T>(this T control, Func<Avalonia.Input.KeyGesture> func, Action<Avalonia.Input.KeyGesture>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(func, Avalonia.Controls.MenuItem.HotKeyProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HotKey<T>(this T control, ISignal<Avalonia.Input.KeyGesture> signal, Action<Avalonia.Input.KeyGesture>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(signal, Avalonia.Controls.MenuItem.HotKeyProperty!, onChanged);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object value) where T : Avalonia.Controls.MenuItem 
=> control._set(() => control.CommandParameter = value!);

/*BindFromFuncSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(func, Avalonia.Controls.MenuItem.CommandParameterProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CommandParameter<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(signal, Avalonia.Controls.MenuItem.CommandParameterProperty!, onChanged);


 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, System.Object value) where T : Avalonia.Controls.MenuItem 
=> control._set(() => control.Icon = value!);

/*BindFromFuncSetterGenerator*/
public static T Icon<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(func, Avalonia.Controls.MenuItem.IconProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Icon<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(signal, Avalonia.Controls.MenuItem.IconProperty!, onChanged);


 // InputGesture

/*ValueSetterGenerator*/
public static T InputGesture<T>(this T control, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.MenuItem 
=> control._set(() => control.InputGesture = value!);

/*BindFromFuncSetterGenerator*/
public static T InputGesture<T>(this T control, Func<Avalonia.Input.KeyGesture> func, Action<Avalonia.Input.KeyGesture>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(func, Avalonia.Controls.MenuItem.InputGestureProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T InputGesture<T>(this T control, ISignal<Avalonia.Input.KeyGesture> signal, Action<Avalonia.Input.KeyGesture>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(signal, Avalonia.Controls.MenuItem.InputGestureProperty!, onChanged);


 // IsSubMenuOpen

/*ValueSetterGenerator*/
public static T IsSubMenuOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MenuItem 
=> control._set(() => control.IsSubMenuOpen = value!);

/*BindFromFuncSetterGenerator*/
public static T IsSubMenuOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(func, Avalonia.Controls.MenuItem.IsSubMenuOpenProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsSubMenuOpen<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(signal, Avalonia.Controls.MenuItem.IsSubMenuOpenProperty!, onChanged);


 // StaysOpenOnClick

/*ValueSetterGenerator*/
public static T StaysOpenOnClick<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MenuItem 
=> control._set(() => control.StaysOpenOnClick = value!);

/*BindFromFuncSetterGenerator*/
public static T StaysOpenOnClick<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(func, Avalonia.Controls.MenuItem.StaysOpenOnClickProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T StaysOpenOnClick<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(signal, Avalonia.Controls.MenuItem.StaysOpenOnClickProperty!, onChanged);


 // ToggleType

/*ValueSetterGenerator*/
public static T ToggleType<T>(this T control, Avalonia.Controls.MenuItemToggleType value) where T : Avalonia.Controls.MenuItem 
=> control._set(() => control.ToggleType = value!);

/*BindFromFuncSetterGenerator*/
public static T ToggleType<T>(this T control, Func<Avalonia.Controls.MenuItemToggleType> func, Action<Avalonia.Controls.MenuItemToggleType>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(func, Avalonia.Controls.MenuItem.ToggleTypeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ToggleType<T>(this T control, ISignal<Avalonia.Controls.MenuItemToggleType> signal, Action<Avalonia.Controls.MenuItemToggleType>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(signal, Avalonia.Controls.MenuItem.ToggleTypeProperty!, onChanged);


 // IsChecked

/*ValueSetterGenerator*/
public static T IsChecked<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MenuItem 
=> control._set(() => control.IsChecked = value!);

/*BindFromFuncSetterGenerator*/
public static T IsChecked<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(func, Avalonia.Controls.MenuItem.IsCheckedProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsChecked<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(signal, Avalonia.Controls.MenuItem.IsCheckedProperty!, onChanged);


 // GroupName

/*ValueSetterGenerator*/
public static T GroupName<T>(this T control, System.String value) where T : Avalonia.Controls.MenuItem 
=> control._set(() => control.GroupName = value!);

/*BindFromFuncSetterGenerator*/
public static T GroupName<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(func, Avalonia.Controls.MenuItem.GroupNameProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T GroupName<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(signal, Avalonia.Controls.MenuItem.GroupNameProperty!, onChanged);



//================= Events ======================//
 // Click

/*ActionToEventGenerator*/
public static T OnClick<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.MenuItem 
{
  control.AddHandler(Avalonia.Controls.MenuItem.ClickEvent, (_, args) => action(args), routes ?? Avalonia.Controls.MenuItem.ClickEvent.RoutingStrategies);
  return control;
}



 // PointerEnteredItem

/*ActionToEventGenerator*/
public static T OnPointerEnteredItem<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.MenuItem 
{
  control.AddHandler(Avalonia.Controls.MenuItem.PointerEnteredItemEvent, (_, args) => action(args), routes ?? Avalonia.Controls.MenuItem.PointerEnteredItemEvent.RoutingStrategies);
  return control;
}



 // PointerExitedItem

/*ActionToEventGenerator*/
public static T OnPointerExitedItem<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.MenuItem 
{
  control.AddHandler(Avalonia.Controls.MenuItem.PointerExitedItemEvent, (_, args) => action(args), routes ?? Avalonia.Controls.MenuItem.PointerExitedItemEvent.RoutingStrategies);
  return control;
}



 // SubmenuOpened

/*ActionToEventGenerator*/
public static T OnSubmenuOpened<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.MenuItem 
{
  control.AddHandler(Avalonia.Controls.MenuItem.SubmenuOpenedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.MenuItem.SubmenuOpenedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Command

/*ValueStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, System.Windows.Input.ICommand value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.CommandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.CommandProperty, binding);


 // HotKey

/*ValueStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.HotKeyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.HotKeyProperty, binding);


 // CommandParameter

/*ValueStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.CommandParameterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.CommandParameterProperty, binding);


 // Icon

/*ValueStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IconProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IconProperty, binding);


 // InputGesture

/*ValueStyleSetterGenerator*/
public static Style<T> InputGesture<T>(this Style<T> style, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.InputGestureProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InputGesture<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.InputGestureProperty, binding);


 // IsSubMenuOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsSubMenuOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSubMenuOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty, binding);


 // StaysOpenOnClick

/*ValueStyleSetterGenerator*/
public static Style<T> StaysOpenOnClick<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StaysOpenOnClick<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty, binding);


 // ToggleType

/*ValueStyleSetterGenerator*/
public static Style<T> ToggleType<T>(this Style<T> style, Avalonia.Controls.MenuItemToggleType value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.ToggleTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ToggleType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.ToggleTypeProperty, binding);


 // IsChecked

/*ValueStyleSetterGenerator*/
public static Style<T> IsChecked<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IsCheckedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsChecked<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IsCheckedProperty, binding);


 // GroupName

/*ValueStyleSetterGenerator*/
public static Style<T> GroupName<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.GroupNameProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> GroupName<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.GroupNameProperty, binding);



}
