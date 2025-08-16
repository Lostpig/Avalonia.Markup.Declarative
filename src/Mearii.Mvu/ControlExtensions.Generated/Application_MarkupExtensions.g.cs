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
public static partial class Application_MarkupExtensions
{
//================= Properties ======================//
 // DataContext

/*ValueSetterGenerator*/
public static T DataContext<T>(this T control, System.Object value) where T : Avalonia.Application 
=> control._set(() => control.DataContext = value!);

/*BindFromFuncSetterGenerator*/
public static T DataContext<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Application 
   => control._set(func, Avalonia.Application.DataContextProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T DataContext<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Application 
   => control._set(signal, Avalonia.Application.DataContextProperty!, onChanged);


 // RequestedThemeVariant

/*ValueSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Avalonia.Styling.ThemeVariant value) where T : Avalonia.Application 
=> control._set(() => control.RequestedThemeVariant = value!);

/*BindFromFuncSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Func<Avalonia.Styling.ThemeVariant> func, Action<Avalonia.Styling.ThemeVariant>? onChanged = null) where T : Avalonia.Application 
   => control._set(func, Avalonia.Application.RequestedThemeVariantProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, ISignal<Avalonia.Styling.ThemeVariant> signal, Action<Avalonia.Styling.ThemeVariant>? onChanged = null) where T : Avalonia.Application 
   => control._set(signal, Avalonia.Application.RequestedThemeVariantProperty!, onChanged);


 // Name

/*ValueSetterGenerator*/
public static T Name<T>(this T control, System.String value) where T : Avalonia.Application 
=> control._set(() => control.Name = value!);

/*BindFromFuncSetterGenerator*/
public static T Name<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Application 
   => control._set(func, Avalonia.Application.NameProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Name<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Application 
   => control._set(signal, Avalonia.Application.NameProperty!, onChanged);



//================= Events ======================//
 // ResourcesChanged

/*ActionToEventGenerator*/
public static T OnResourcesChanged<T>(this T control, Action<Avalonia.Controls.ResourcesChangedEventArgs> action) where T : Avalonia.Application  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ResourcesChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ResourcesChanged += h);


 // UrlsOpened

/*ActionToEventGenerator*/
[Obsolete]public static T OnUrlsOpened<T>(this T control, Action<Avalonia.UrlOpenedEventArgs> action) where T : Avalonia.Application  => 
 control._setEvent((System.EventHandler<Avalonia.UrlOpenedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.UrlsOpened += h);


 // ActualThemeVariantChanged

/*ActionToEventGenerator*/
public static T OnActualThemeVariantChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Application  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.ActualThemeVariantChanged += h);



}
