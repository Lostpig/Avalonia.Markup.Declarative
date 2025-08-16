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
public static partial class WindowNotificationManager_MarkupExtensions
{
//================= Properties ======================//
 // Position

/*ValueSetterGenerator*/
public static T Position<T>(this T control, Avalonia.Controls.Notifications.NotificationPosition value) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> control._set(() => control.Position = value!);

/*BindFromFuncSetterGenerator*/
public static T Position<T>(this T control, Func<Avalonia.Controls.Notifications.NotificationPosition> func, Action<Avalonia.Controls.Notifications.NotificationPosition>? onChanged = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(func, Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Position<T>(this T control, ISignal<Avalonia.Controls.Notifications.NotificationPosition> signal, Action<Avalonia.Controls.Notifications.NotificationPosition>? onChanged = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(signal, Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty!, onChanged);


 // MaxItems

/*ValueSetterGenerator*/
public static T MaxItems<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> control._set(() => control.MaxItems = value!);

/*BindFromFuncSetterGenerator*/
public static T MaxItems<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(func, Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MaxItems<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
   => control._set(signal, Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty!, onChanged);



//================= Styles ======================//
 // Position

/*ValueStyleSetterGenerator*/
public static Style<T> Position<T>(this Style<T> style, Avalonia.Controls.Notifications.NotificationPosition value) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> style._addSetter(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Position<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> style._addSetter(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, binding);


 // MaxItems

/*ValueStyleSetterGenerator*/
public static Style<T> MaxItems<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> style._addSetter(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxItems<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Notifications.WindowNotificationManager 
=> style._addSetter(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, binding);



}
