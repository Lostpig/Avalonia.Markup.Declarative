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
public static partial class Flyout_MarkupExtensions
{
//================= Properties ======================//
 // Content

/*ValueSetterGenerator*/
public static T Content<T>(this T control, System.Object value) where T : Avalonia.Controls.Flyout 
=> control._set(() => control.Content = value!);

/*BindFromFuncSetterGenerator*/
public static T Content<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.Flyout 
   => control._set(func, Avalonia.Controls.Flyout.ContentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Content<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.Flyout 
   => control._set(signal, Avalonia.Controls.Flyout.ContentProperty!, onChanged);


 // ContentTemplate

/*ValueSetterGenerator*/
public static T ContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.Flyout 
=> control._set(() => control.ContentTemplate = value!);

/*BindFromFuncSetterGenerator*/
public static T ContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.Flyout 
   => control._set(func, Avalonia.Controls.Flyout.ContentTemplateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ContentTemplate<T>(this T control, ISignal<Avalonia.Controls.Templates.IDataTemplate> signal, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.Flyout 
   => control._set(signal, Avalonia.Controls.Flyout.ContentTemplateProperty!, onChanged);


 // FlyoutPresenterTheme

/*ValueSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, Avalonia.Styling.ControlTheme value) where T : Avalonia.Controls.Flyout 
=> control._set(() => control.FlyoutPresenterTheme = value!);

/*BindFromFuncSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme> func, Action<Avalonia.Styling.ControlTheme>? onChanged = null) where T : Avalonia.Controls.Flyout 
   => control._set(func, Avalonia.Controls.Flyout.FlyoutPresenterThemeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FlyoutPresenterTheme<T>(this T control, ISignal<Avalonia.Styling.ControlTheme> signal, Action<Avalonia.Styling.ControlTheme>? onChanged = null) where T : Avalonia.Controls.Flyout 
   => control._set(signal, Avalonia.Controls.Flyout.FlyoutPresenterThemeProperty!, onChanged);



}
