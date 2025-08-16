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
public static partial class TopLevel_MarkupExtensions
{
//================= Properties ======================//
 // TransparencyLevelHint

/*ValueSetterGenerator*/
public static T TransparencyLevelHint<T>(this T control, System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel> value) where T : Avalonia.Controls.TopLevel 
=> control._set(() => control.TransparencyLevelHint = value!);

/*BindFromFuncSetterGenerator*/
public static T TransparencyLevelHint<T>(this T control, Func<System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>> func, Action<System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>>? onChanged = null) where T : Avalonia.Controls.TopLevel 
   => control._set(func, Avalonia.Controls.TopLevel.TransparencyLevelHintProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TransparencyLevelHint<T>(this T control, ISignal<System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>> signal, Action<System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>>? onChanged = null) where T : Avalonia.Controls.TopLevel 
   => control._set(signal, Avalonia.Controls.TopLevel.TransparencyLevelHintProperty!, onChanged);


 // TransparencyBackgroundFallback

/*ValueSetterGenerator*/
public static T TransparencyBackgroundFallback<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TopLevel 
=> control._set(() => control.TransparencyBackgroundFallback = value!);

/*BindFromFuncSetterGenerator*/
public static T TransparencyBackgroundFallback<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.TopLevel 
   => control._set(func, Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TransparencyBackgroundFallback<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.TopLevel 
   => control._set(signal, Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty!, onChanged);


 // RequestedThemeVariant

/*ValueSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Avalonia.Styling.ThemeVariant value) where T : Avalonia.Controls.TopLevel 
=> control._set(() => control.RequestedThemeVariant = value!);

/*BindFromFuncSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Func<Avalonia.Styling.ThemeVariant> func, Action<Avalonia.Styling.ThemeVariant>? onChanged = null) where T : Avalonia.Controls.TopLevel 
   => control._set(func, Avalonia.Controls.TopLevel.RequestedThemeVariantProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, ISignal<Avalonia.Styling.ThemeVariant> signal, Action<Avalonia.Styling.ThemeVariant>? onChanged = null) where T : Avalonia.Controls.TopLevel 
   => control._set(signal, Avalonia.Controls.TopLevel.RequestedThemeVariantProperty!, onChanged);



//================= Attached Properties ======================//
 // SystemBarColor

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T TopLevel_SystemBarColor<T>(this T control, Func<Avalonia.Media.SolidColorBrush> func, Action<Avalonia.Media.SolidColorBrush>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.TopLevel.SystemBarColorProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T TopLevel_SystemBarColor<T>(this T control, ISignal<Avalonia.Media.SolidColorBrush> signal, Action<Avalonia.Media.SolidColorBrush>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.TopLevel.SystemBarColorProperty!, onChanged);


 // AutoSafeAreaPadding

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T TopLevel_AutoSafeAreaPadding<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.TopLevel.AutoSafeAreaPaddingProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T TopLevel_AutoSafeAreaPadding<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.TopLevel.AutoSafeAreaPaddingProperty!, onChanged);



//================= Events ======================//
 // Opened

/*ActionToEventGenerator*/
public static T OnOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TopLevel  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Opened += h);


 // Closed

/*ActionToEventGenerator*/
public static T OnClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TopLevel  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Closed += h);


 // ScalingChanged

/*ActionToEventGenerator*/
public static T OnScalingChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TopLevel  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.ScalingChanged += h);


 // BackRequested

/*ActionToEventGenerator*/
public static T OnBackRequested<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.TopLevel 
{
  control.AddHandler(Avalonia.Controls.TopLevel.BackRequestedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.TopLevel.BackRequestedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // TransparencyLevelHint

/*ValueStyleSetterGenerator*/
public static Style<T> TransparencyLevelHint<T>(this Style<T> style, System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel> value) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TransparencyLevelHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, binding);


 // TransparencyBackgroundFallback

/*ValueStyleSetterGenerator*/
public static Style<T> TransparencyBackgroundFallback<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TransparencyBackgroundFallback<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, binding);


 // RequestedThemeVariant

/*ValueStyleSetterGenerator*/
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, Avalonia.Styling.ThemeVariant value) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, binding);



}
