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
public static partial class SplitButton_MarkupExtensions
{
//================= Properties ======================//
 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand value) where T : Avalonia.Controls.SplitButton 
=> control._set(() => control.Command = value!);

/*BindFromFuncSetterGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null) where T : Avalonia.Controls.SplitButton 
   => control._set(func, Avalonia.Controls.SplitButton.CommandProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Command<T>(this T control, ISignal<System.Windows.Input.ICommand> signal, Action<System.Windows.Input.ICommand>? onChanged = null) where T : Avalonia.Controls.SplitButton 
   => control._set(signal, Avalonia.Controls.SplitButton.CommandProperty!, onChanged);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object value) where T : Avalonia.Controls.SplitButton 
=> control._set(() => control.CommandParameter = value!);

/*BindFromFuncSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.SplitButton 
   => control._set(func, Avalonia.Controls.SplitButton.CommandParameterProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CommandParameter<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.SplitButton 
   => control._set(signal, Avalonia.Controls.SplitButton.CommandParameterProperty!, onChanged);


 // Flyout

/*ValueSetterGenerator*/
public static T Flyout<T>(this T control, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.SplitButton 
=> control._set(() => control.Flyout = value!);

/*BindFromFuncSetterGenerator*/
public static T Flyout<T>(this T control, Func<Avalonia.Controls.Primitives.FlyoutBase> func, Action<Avalonia.Controls.Primitives.FlyoutBase>? onChanged = null) where T : Avalonia.Controls.SplitButton 
   => control._set(func, Avalonia.Controls.SplitButton.FlyoutProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Flyout<T>(this T control, ISignal<Avalonia.Controls.Primitives.FlyoutBase> signal, Action<Avalonia.Controls.Primitives.FlyoutBase>? onChanged = null) where T : Avalonia.Controls.SplitButton 
   => control._set(signal, Avalonia.Controls.SplitButton.FlyoutProperty!, onChanged);


 // HotKey

/*ValueSetterGenerator*/
public static T HotKey<T>(this T control, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.SplitButton 
=> control._set(() => control.HotKey = value!);

/*BindFromFuncSetterGenerator*/
public static T HotKey<T>(this T control, Func<Avalonia.Input.KeyGesture> func, Action<Avalonia.Input.KeyGesture>? onChanged = null) where T : Avalonia.Controls.SplitButton 
   => control._set(func, Avalonia.Controls.SplitButton.HotKeyProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HotKey<T>(this T control, ISignal<Avalonia.Input.KeyGesture> signal, Action<Avalonia.Input.KeyGesture>? onChanged = null) where T : Avalonia.Controls.SplitButton 
   => control._set(signal, Avalonia.Controls.SplitButton.HotKeyProperty!, onChanged);



//================= Events ======================//
 // Click

/*ActionToEventGenerator*/
public static T OnClick<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SplitButton 
{
  control.AddHandler(Avalonia.Controls.SplitButton.ClickEvent, (_, args) => action(args), routes ?? Avalonia.Controls.SplitButton.ClickEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Command

/*ValueStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, System.Windows.Input.ICommand value) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.CommandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.CommandProperty, binding);


 // CommandParameter

/*ValueStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.CommandParameterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.CommandParameterProperty, binding);


 // Flyout

/*ValueStyleSetterGenerator*/
public static Style<T> Flyout<T>(this Style<T> style, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.FlyoutProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Flyout<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.FlyoutProperty, binding);


 // HotKey

/*ValueStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.HotKeyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitButton 
=> style._addSetter(Avalonia.Controls.SplitButton.HotKeyProperty, binding);



}
