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
public static partial class TrayIcon_MarkupExtensions
{
//================= Properties ======================//
 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand value) where T : Avalonia.Controls.TrayIcon 
=> control._set(() => control.Command = value!);

/*BindFromFuncSetterGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(func, Avalonia.Controls.TrayIcon.CommandProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Command<T>(this T control, ISignal<System.Windows.Input.ICommand> signal, Action<System.Windows.Input.ICommand>? onChanged = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(signal, Avalonia.Controls.TrayIcon.CommandProperty!, onChanged);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object value) where T : Avalonia.Controls.TrayIcon 
=> control._set(() => control.CommandParameter = value!);

/*BindFromFuncSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(func, Avalonia.Controls.TrayIcon.CommandParameterProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CommandParameter<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(signal, Avalonia.Controls.TrayIcon.CommandParameterProperty!, onChanged);


 // Menu

/*ValueSetterGenerator*/
public static T Menu<T>(this T control, Avalonia.Controls.NativeMenu value) where T : Avalonia.Controls.TrayIcon 
=> control._set(() => control.Menu = value!);

/*BindFromFuncSetterGenerator*/
public static T Menu<T>(this T control, Func<Avalonia.Controls.NativeMenu> func, Action<Avalonia.Controls.NativeMenu>? onChanged = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(func, Avalonia.Controls.TrayIcon.MenuProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Menu<T>(this T control, ISignal<Avalonia.Controls.NativeMenu> signal, Action<Avalonia.Controls.NativeMenu>? onChanged = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(signal, Avalonia.Controls.TrayIcon.MenuProperty!, onChanged);


 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, Avalonia.Controls.WindowIcon value) where T : Avalonia.Controls.TrayIcon 
=> control._set(() => control.Icon = value!);

/*BindFromFuncSetterGenerator*/
public static T Icon<T>(this T control, Func<Avalonia.Controls.WindowIcon> func, Action<Avalonia.Controls.WindowIcon>? onChanged = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(func, Avalonia.Controls.TrayIcon.IconProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Icon<T>(this T control, ISignal<Avalonia.Controls.WindowIcon> signal, Action<Avalonia.Controls.WindowIcon>? onChanged = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(signal, Avalonia.Controls.TrayIcon.IconProperty!, onChanged);


 // ToolTipText

/*ValueSetterGenerator*/
public static T ToolTipText<T>(this T control, System.String value) where T : Avalonia.Controls.TrayIcon 
=> control._set(() => control.ToolTipText = value!);

/*BindFromFuncSetterGenerator*/
public static T ToolTipText<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(func, Avalonia.Controls.TrayIcon.ToolTipTextProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ToolTipText<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(signal, Avalonia.Controls.TrayIcon.ToolTipTextProperty!, onChanged);


 // IsVisible

/*ValueSetterGenerator*/
public static T IsVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TrayIcon 
=> control._set(() => control.IsVisible = value!);

/*BindFromFuncSetterGenerator*/
public static T IsVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(func, Avalonia.Controls.TrayIcon.IsVisibleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsVisible<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(signal, Avalonia.Controls.TrayIcon.IsVisibleProperty!, onChanged);



//================= Attached Properties ======================//
 // Icons

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T TrayIcon_Icons<T>(this T control, Func<Avalonia.Controls.TrayIcons> func, Action<Avalonia.Controls.TrayIcons>? onChanged = null) where T : Avalonia.Application 
   => control._set(func, Avalonia.Controls.TrayIcon.IconsProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T TrayIcon_Icons<T>(this T control, ISignal<Avalonia.Controls.TrayIcons> signal, Action<Avalonia.Controls.TrayIcons>? onChanged = null) where T : Avalonia.Application 
   => control._set(signal, Avalonia.Controls.TrayIcon.IconsProperty!, onChanged);



//================= Events ======================//
 // Clicked

/*ActionToEventGenerator*/
public static T OnClicked<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TrayIcon  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Clicked += h);



}
