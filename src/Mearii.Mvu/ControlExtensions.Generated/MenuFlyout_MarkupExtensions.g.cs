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
public static partial class MenuFlyout_MarkupExtensions
{
//================= Properties ======================//
 // ItemsSource

/*ValueSetterGenerator*/
public static T ItemsSource<T>(this T control, System.Collections.IEnumerable value) where T : Avalonia.Controls.MenuFlyout 
=> control._set(() => control.ItemsSource = value!);

/*BindFromFuncSetterGenerator*/
public static T ItemsSource<T>(this T control, Func<System.Collections.IEnumerable> func, Action<System.Collections.IEnumerable>? onChanged = null) where T : Avalonia.Controls.MenuFlyout 
   => control._set(func, Avalonia.Controls.MenuFlyout.ItemsSourceProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ItemsSource<T>(this T control, ISignal<System.Collections.IEnumerable> signal, Action<System.Collections.IEnumerable>? onChanged = null) where T : Avalonia.Controls.MenuFlyout 
   => control._set(signal, Avalonia.Controls.MenuFlyout.ItemsSourceProperty!, onChanged);


 // ItemTemplate

/*ValueSetterGenerator*/
public static T ItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.MenuFlyout 
=> control._set(() => control.ItemTemplate = value!);

/*BindFromFuncSetterGenerator*/
public static T ItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.MenuFlyout 
   => control._set(func, Avalonia.Controls.MenuFlyout.ItemTemplateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ItemTemplate<T>(this T control, ISignal<Avalonia.Controls.Templates.IDataTemplate> signal, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.MenuFlyout 
   => control._set(signal, Avalonia.Controls.MenuFlyout.ItemTemplateProperty!, onChanged);


 // ItemContainerTheme

/*ValueSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, Avalonia.Styling.ControlTheme value) where T : Avalonia.Controls.MenuFlyout 
=> control._set(() => control.ItemContainerTheme = value!);

/*BindFromFuncSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme> func, Action<Avalonia.Styling.ControlTheme>? onChanged = null) where T : Avalonia.Controls.MenuFlyout 
   => control._set(func, Avalonia.Controls.MenuFlyout.ItemContainerThemeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, ISignal<Avalonia.Styling.ControlTheme> signal, Action<Avalonia.Styling.ControlTheme>? onChanged = null) where T : Avalonia.Controls.MenuFlyout 
   => control._set(signal, Avalonia.Controls.MenuFlyout.ItemContainerThemeProperty!, onChanged);


 // FlyoutPresenterTheme

/*ValueSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, Avalonia.Styling.ControlTheme value) where T : Avalonia.Controls.MenuFlyout 
=> control._set(() => control.FlyoutPresenterTheme = value!);

/*BindFromFuncSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme> func, Action<Avalonia.Styling.ControlTheme>? onChanged = null) where T : Avalonia.Controls.MenuFlyout 
   => control._set(func, Avalonia.Controls.MenuFlyout.FlyoutPresenterThemeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, ISignal<Avalonia.Styling.ControlTheme> signal, Action<Avalonia.Styling.ControlTheme>? onChanged = null) where T : Avalonia.Controls.MenuFlyout 
   => control._set(signal, Avalonia.Controls.MenuFlyout.FlyoutPresenterThemeProperty!, onChanged);



}
