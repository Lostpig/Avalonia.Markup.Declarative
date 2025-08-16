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
public static partial class NativeMenuItem_MarkupExtensions
{
//================= Properties ======================//
 // Menu

/*ValueSetterGenerator*/
public static T Menu<T>(this T control, Avalonia.Controls.NativeMenu value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.Menu = value!);

/*BindFromFuncSetterGenerator*/
public static T Menu<T>(this T control, Func<Avalonia.Controls.NativeMenu> func, Action<Avalonia.Controls.NativeMenu>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(func, Avalonia.Controls.NativeMenuItem.MenuProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Menu<T>(this T control, ISignal<Avalonia.Controls.NativeMenu> signal, Action<Avalonia.Controls.NativeMenu>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(signal, Avalonia.Controls.NativeMenuItem.MenuProperty!, onChanged);


 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, Avalonia.Media.Imaging.Bitmap value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.Icon = value!);

/*BindFromFuncSetterGenerator*/
public static T Icon<T>(this T control, Func<Avalonia.Media.Imaging.Bitmap> func, Action<Avalonia.Media.Imaging.Bitmap>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(func, Avalonia.Controls.NativeMenuItem.IconProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Icon<T>(this T control, ISignal<Avalonia.Media.Imaging.Bitmap> signal, Action<Avalonia.Media.Imaging.Bitmap>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(signal, Avalonia.Controls.NativeMenuItem.IconProperty!, onChanged);


 // Header

/*ValueSetterGenerator*/
public static T Header<T>(this T control, System.String value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.Header = value!);

/*BindFromFuncSetterGenerator*/
public static T Header<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(func, Avalonia.Controls.NativeMenuItem.HeaderProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Header<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(signal, Avalonia.Controls.NativeMenuItem.HeaderProperty!, onChanged);


 // ToolTip

/*ValueSetterGenerator*/
public static T ToolTip<T>(this T control, System.String value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.ToolTip = value!);

/*BindFromFuncSetterGenerator*/
public static T ToolTip<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(func, Avalonia.Controls.NativeMenuItem.ToolTipProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ToolTip<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(signal, Avalonia.Controls.NativeMenuItem.ToolTipProperty!, onChanged);


 // Gesture

/*ValueSetterGenerator*/
public static T Gesture<T>(this T control, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.Gesture = value!);

/*BindFromFuncSetterGenerator*/
public static T Gesture<T>(this T control, Func<Avalonia.Input.KeyGesture> func, Action<Avalonia.Input.KeyGesture>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(func, Avalonia.Controls.NativeMenuItem.GestureProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Gesture<T>(this T control, ISignal<Avalonia.Input.KeyGesture> signal, Action<Avalonia.Input.KeyGesture>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(signal, Avalonia.Controls.NativeMenuItem.GestureProperty!, onChanged);


 // IsChecked

/*ValueSetterGenerator*/
public static T IsChecked<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.IsChecked = value!);

/*BindFromFuncSetterGenerator*/
public static T IsChecked<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(func, Avalonia.Controls.NativeMenuItem.IsCheckedProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsChecked<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(signal, Avalonia.Controls.NativeMenuItem.IsCheckedProperty!, onChanged);


 // ToggleType

/*ValueSetterGenerator*/
public static T ToggleType<T>(this T control, Avalonia.Controls.NativeMenuItemToggleType value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.ToggleType = value!);

/*BindFromFuncSetterGenerator*/
public static T ToggleType<T>(this T control, Func<Avalonia.Controls.NativeMenuItemToggleType> func, Action<Avalonia.Controls.NativeMenuItemToggleType>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(func, Avalonia.Controls.NativeMenuItem.ToggleTypeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ToggleType<T>(this T control, ISignal<Avalonia.Controls.NativeMenuItemToggleType> signal, Action<Avalonia.Controls.NativeMenuItemToggleType>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(signal, Avalonia.Controls.NativeMenuItem.ToggleTypeProperty!, onChanged);


 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.Command = value!);

/*BindFromFuncSetterGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(func, Avalonia.Controls.NativeMenuItem.CommandProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Command<T>(this T control, ISignal<System.Windows.Input.ICommand> signal, Action<System.Windows.Input.ICommand>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(signal, Avalonia.Controls.NativeMenuItem.CommandProperty!, onChanged);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.CommandParameter = value!);

/*BindFromFuncSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(func, Avalonia.Controls.NativeMenuItem.CommandParameterProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CommandParameter<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(signal, Avalonia.Controls.NativeMenuItem.CommandParameterProperty!, onChanged);


 // IsEnabled

/*ValueSetterGenerator*/
public static T IsEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.IsEnabled = value!);

/*BindFromFuncSetterGenerator*/
public static T IsEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(func, Avalonia.Controls.NativeMenuItem.IsEnabledProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsEnabled<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(signal, Avalonia.Controls.NativeMenuItem.IsEnabledProperty!, onChanged);


 // IsVisible

/*ValueSetterGenerator*/
public static T IsVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.IsVisible = value!);

/*BindFromFuncSetterGenerator*/
public static T IsVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(func, Avalonia.Controls.NativeMenuItem.IsVisibleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsVisible<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(signal, Avalonia.Controls.NativeMenuItem.IsVisibleProperty!, onChanged);



//================= Events ======================//
 // Click

/*ActionToEventGenerator*/
public static T OnClick<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.NativeMenuItem  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Click += h);



}
