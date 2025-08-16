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
public static partial class NotificationCard_MarkupExtensions
{
//================= Properties ======================//
 // IsClosed

/*ValueSetterGenerator*/
public static T IsClosed<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Notifications.NotificationCard 
=> control._set(() => control.IsClosed = value!);

/*BindFromFuncSetterGenerator*/
public static T IsClosed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Notifications.NotificationCard 
   => control._set(func, Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsClosed<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Notifications.NotificationCard 
   => control._set(signal, Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty!, onChanged);


 // NotificationType

/*ValueSetterGenerator*/
public static T NotificationType<T>(this T control, Avalonia.Controls.Notifications.NotificationType value) where T : Avalonia.Controls.Notifications.NotificationCard 
=> control._set(() => control.NotificationType = value!);

/*BindFromFuncSetterGenerator*/
public static T NotificationType<T>(this T control, Func<Avalonia.Controls.Notifications.NotificationType> func, Action<Avalonia.Controls.Notifications.NotificationType>? onChanged = null) where T : Avalonia.Controls.Notifications.NotificationCard 
   => control._set(func, Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T NotificationType<T>(this T control, ISignal<Avalonia.Controls.Notifications.NotificationType> signal, Action<Avalonia.Controls.Notifications.NotificationType>? onChanged = null) where T : Avalonia.Controls.Notifications.NotificationCard 
   => control._set(signal, Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty!, onChanged);



//================= Attached Properties ======================//
 // CloseOnClick

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T NotificationCard_CloseOnClick<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Button 
   => control._set(func, Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T NotificationCard_CloseOnClick<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Button 
   => control._set(signal, Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty!, onChanged);



//================= Events ======================//
 // NotificationClosed

/*ActionToEventGenerator*/
public static T OnNotificationClosed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Notifications.NotificationCard 
{
  control.AddHandler(Avalonia.Controls.Notifications.NotificationCard.NotificationClosedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Notifications.NotificationCard.NotificationClosedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // IsClosed

/*ValueStyleSetterGenerator*/
public static Style<T> IsClosed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Notifications.NotificationCard 
=> style._addSetter(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsClosed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Notifications.NotificationCard 
=> style._addSetter(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty, binding);


 // NotificationType

/*ValueStyleSetterGenerator*/
public static Style<T> NotificationType<T>(this Style<T> style, Avalonia.Controls.Notifications.NotificationType value) where T : Avalonia.Controls.Notifications.NotificationCard 
=> style._addSetter(Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> NotificationType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Notifications.NotificationCard 
=> style._addSetter(Avalonia.Controls.Notifications.NotificationCard.NotificationTypeProperty, binding);



}
