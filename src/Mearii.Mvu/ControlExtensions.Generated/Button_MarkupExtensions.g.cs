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
public static partial class Button_MarkupExtensions
{
//================= Properties ======================//
 // ClickMode

/*ValueSetterGenerator*/
public static T ClickMode<T>(this T control, Avalonia.Controls.ClickMode value) where T : Avalonia.Controls.Button 
=> control._set(() => control.ClickMode = value!);

/*BindFromFuncSetterGenerator*/
public static T ClickMode<T>(this T control, Func<Avalonia.Controls.ClickMode> func, Action<Avalonia.Controls.ClickMode>? onChanged = null) where T : Avalonia.Controls.Button 
   => control._set(func, Avalonia.Controls.Button.ClickModeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ClickMode<T>(this T control, ISignal<Avalonia.Controls.ClickMode> signal, Action<Avalonia.Controls.ClickMode>? onChanged = null) where T : Avalonia.Controls.Button 
   => control._set(signal, Avalonia.Controls.Button.ClickModeProperty!, onChanged);


 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand value) where T : Avalonia.Controls.Button 
=> control._set(() => control.Command = value!);

/*BindFromFuncSetterGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null) where T : Avalonia.Controls.Button 
   => control._set(func, Avalonia.Controls.Button.CommandProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Command<T>(this T control, ISignal<System.Windows.Input.ICommand> signal, Action<System.Windows.Input.ICommand>? onChanged = null) where T : Avalonia.Controls.Button 
   => control._set(signal, Avalonia.Controls.Button.CommandProperty!, onChanged);


 // HotKey

/*ValueSetterGenerator*/
public static T HotKey<T>(this T control, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.Button 
=> control._set(() => control.HotKey = value!);

/*BindFromFuncSetterGenerator*/
public static T HotKey<T>(this T control, Func<Avalonia.Input.KeyGesture> func, Action<Avalonia.Input.KeyGesture>? onChanged = null) where T : Avalonia.Controls.Button 
   => control._set(func, Avalonia.Controls.Button.HotKeyProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HotKey<T>(this T control, ISignal<Avalonia.Input.KeyGesture> signal, Action<Avalonia.Input.KeyGesture>? onChanged = null) where T : Avalonia.Controls.Button 
   => control._set(signal, Avalonia.Controls.Button.HotKeyProperty!, onChanged);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object value) where T : Avalonia.Controls.Button 
=> control._set(() => control.CommandParameter = value!);

/*BindFromFuncSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.Button 
   => control._set(func, Avalonia.Controls.Button.CommandParameterProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CommandParameter<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.Button 
   => control._set(signal, Avalonia.Controls.Button.CommandParameterProperty!, onChanged);


 // IsDefault

/*ValueSetterGenerator*/
public static T IsDefault<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Button 
=> control._set(() => control.IsDefault = value!);

/*BindFromFuncSetterGenerator*/
public static T IsDefault<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Button 
   => control._set(func, Avalonia.Controls.Button.IsDefaultProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsDefault<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Button 
   => control._set(signal, Avalonia.Controls.Button.IsDefaultProperty!, onChanged);


 // IsCancel

/*ValueSetterGenerator*/
public static T IsCancel<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Button 
=> control._set(() => control.IsCancel = value!);

/*BindFromFuncSetterGenerator*/
public static T IsCancel<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Button 
   => control._set(func, Avalonia.Controls.Button.IsCancelProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsCancel<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Button 
   => control._set(signal, Avalonia.Controls.Button.IsCancelProperty!, onChanged);


 // Flyout

/*ValueSetterGenerator*/
public static T Flyout<T>(this T control, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.Button 
=> control._set(() => control.Flyout = value!);

/*BindFromFuncSetterGenerator*/
public static T Flyout<T>(this T control, Func<Avalonia.Controls.Primitives.FlyoutBase> func, Action<Avalonia.Controls.Primitives.FlyoutBase>? onChanged = null) where T : Avalonia.Controls.Button 
   => control._set(func, Avalonia.Controls.Button.FlyoutProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Flyout<T>(this T control, ISignal<Avalonia.Controls.Primitives.FlyoutBase> signal, Action<Avalonia.Controls.Primitives.FlyoutBase>? onChanged = null) where T : Avalonia.Controls.Button 
   => control._set(signal, Avalonia.Controls.Button.FlyoutProperty!, onChanged);



//================= Events ======================//
 // Click

/*ActionToEventGenerator*/
public static T OnClick<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Button 
{
  control.AddHandler(Avalonia.Controls.Button.ClickEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Button.ClickEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // ClickMode

/*ValueStyleSetterGenerator*/
public static Style<T> ClickMode<T>(this Style<T> style, Avalonia.Controls.ClickMode value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.ClickModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClickMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.ClickModeProperty, binding);


 // Command

/*ValueStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, System.Windows.Input.ICommand value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.CommandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.CommandProperty, binding);


 // HotKey

/*ValueStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.HotKeyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.HotKeyProperty, binding);


 // CommandParameter

/*ValueStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.CommandParameterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.CommandParameterProperty, binding);


 // IsDefault

/*ValueStyleSetterGenerator*/
public static Style<T> IsDefault<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.IsDefaultProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDefault<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.IsDefaultProperty, binding);


 // IsCancel

/*ValueStyleSetterGenerator*/
public static Style<T> IsCancel<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.IsCancelProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsCancel<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.IsCancelProperty, binding);


 // Flyout

/*ValueStyleSetterGenerator*/
public static Style<T> Flyout<T>(this Style<T> style, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.FlyoutProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Flyout<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.FlyoutProperty, binding);



}
