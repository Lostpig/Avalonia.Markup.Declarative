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
public static partial class Window_MarkupExtensions
{
//================= Properties ======================//
 // SizeToContent

/*ValueSetterGenerator*/
public static T SizeToContent<T>(this T control, Avalonia.Controls.SizeToContent value) where T : Avalonia.Controls.Window 
=> control._set(() => control.SizeToContent = value!);

/*BindFromFuncSetterGenerator*/
public static T SizeToContent<T>(this T control, Func<Avalonia.Controls.SizeToContent> func, Action<Avalonia.Controls.SizeToContent>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(func, Avalonia.Controls.Window.SizeToContentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SizeToContent<T>(this T control, ISignal<Avalonia.Controls.SizeToContent> signal, Action<Avalonia.Controls.SizeToContent>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(signal, Avalonia.Controls.Window.SizeToContentProperty!, onChanged);


 // ExtendClientAreaToDecorationsHint

/*ValueSetterGenerator*/
public static T ExtendClientAreaToDecorationsHint<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
=> control._set(() => control.ExtendClientAreaToDecorationsHint = value!);

/*BindFromFuncSetterGenerator*/
public static T ExtendClientAreaToDecorationsHint<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(func, Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ExtendClientAreaToDecorationsHint<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(signal, Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty!, onChanged);


 // ExtendClientAreaChromeHints

/*ValueSetterGenerator*/
public static T ExtendClientAreaChromeHints<T>(this T control, Avalonia.Platform.ExtendClientAreaChromeHints value) where T : Avalonia.Controls.Window 
=> control._set(() => control.ExtendClientAreaChromeHints = value!);

/*BindFromFuncSetterGenerator*/
public static T ExtendClientAreaChromeHints<T>(this T control, Func<Avalonia.Platform.ExtendClientAreaChromeHints> func, Action<Avalonia.Platform.ExtendClientAreaChromeHints>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(func, Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ExtendClientAreaChromeHints<T>(this T control, ISignal<Avalonia.Platform.ExtendClientAreaChromeHints> signal, Action<Avalonia.Platform.ExtendClientAreaChromeHints>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(signal, Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty!, onChanged);


 // ExtendClientAreaTitleBarHeightHint

/*ValueSetterGenerator*/
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, System.Double value) where T : Avalonia.Controls.Window 
=> control._set(() => control.ExtendClientAreaTitleBarHeightHint = value!);

/*BindFromFuncSetterGenerator*/
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(func, Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(signal, Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty!, onChanged);


 // SystemDecorations

/*ValueSetterGenerator*/
public static T SystemDecorations<T>(this T control, Avalonia.Controls.SystemDecorations value) where T : Avalonia.Controls.Window 
=> control._set(() => control.SystemDecorations = value!);

/*BindFromFuncSetterGenerator*/
public static T SystemDecorations<T>(this T control, Func<Avalonia.Controls.SystemDecorations> func, Action<Avalonia.Controls.SystemDecorations>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(func, Avalonia.Controls.Window.SystemDecorationsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SystemDecorations<T>(this T control, ISignal<Avalonia.Controls.SystemDecorations> signal, Action<Avalonia.Controls.SystemDecorations>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(signal, Avalonia.Controls.Window.SystemDecorationsProperty!, onChanged);


 // ShowActivated

/*ValueSetterGenerator*/
public static T ShowActivated<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
=> control._set(() => control.ShowActivated = value!);

/*BindFromFuncSetterGenerator*/
public static T ShowActivated<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(func, Avalonia.Controls.Window.ShowActivatedProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ShowActivated<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(signal, Avalonia.Controls.Window.ShowActivatedProperty!, onChanged);


 // ShowInTaskbar

/*ValueSetterGenerator*/
public static T ShowInTaskbar<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
=> control._set(() => control.ShowInTaskbar = value!);

/*BindFromFuncSetterGenerator*/
public static T ShowInTaskbar<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(func, Avalonia.Controls.Window.ShowInTaskbarProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ShowInTaskbar<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(signal, Avalonia.Controls.Window.ShowInTaskbarProperty!, onChanged);


 // ClosingBehavior

/*ValueSetterGenerator*/
public static T ClosingBehavior<T>(this T control, Avalonia.Controls.WindowClosingBehavior value) where T : Avalonia.Controls.Window 
=> control._set(() => control.ClosingBehavior = value!);

/*BindFromFuncSetterGenerator*/
public static T ClosingBehavior<T>(this T control, Func<Avalonia.Controls.WindowClosingBehavior> func, Action<Avalonia.Controls.WindowClosingBehavior>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(func, Avalonia.Controls.Window.ClosingBehaviorProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ClosingBehavior<T>(this T control, ISignal<Avalonia.Controls.WindowClosingBehavior> signal, Action<Avalonia.Controls.WindowClosingBehavior>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(signal, Avalonia.Controls.Window.ClosingBehaviorProperty!, onChanged);


 // WindowState

/*ValueSetterGenerator*/
public static T WindowState<T>(this T control, Avalonia.Controls.WindowState value) where T : Avalonia.Controls.Window 
=> control._set(() => control.WindowState = value!);

/*BindFromFuncSetterGenerator*/
public static T WindowState<T>(this T control, Func<Avalonia.Controls.WindowState> func, Action<Avalonia.Controls.WindowState>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(func, Avalonia.Controls.Window.WindowStateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T WindowState<T>(this T control, ISignal<Avalonia.Controls.WindowState> signal, Action<Avalonia.Controls.WindowState>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(signal, Avalonia.Controls.Window.WindowStateProperty!, onChanged);


 // Title

/*ValueSetterGenerator*/
public static T Title<T>(this T control, System.String value) where T : Avalonia.Controls.Window 
=> control._set(() => control.Title = value!);

/*BindFromFuncSetterGenerator*/
public static T Title<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(func, Avalonia.Controls.Window.TitleProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Title<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(signal, Avalonia.Controls.Window.TitleProperty!, onChanged);


 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, Avalonia.Controls.WindowIcon value) where T : Avalonia.Controls.Window 
=> control._set(() => control.Icon = value!);

/*BindFromFuncSetterGenerator*/
public static T Icon<T>(this T control, Func<Avalonia.Controls.WindowIcon> func, Action<Avalonia.Controls.WindowIcon>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(func, Avalonia.Controls.Window.IconProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Icon<T>(this T control, ISignal<Avalonia.Controls.WindowIcon> signal, Action<Avalonia.Controls.WindowIcon>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(signal, Avalonia.Controls.Window.IconProperty!, onChanged);


 // WindowStartupLocation

/*ValueSetterGenerator*/
public static T WindowStartupLocation<T>(this T control, Avalonia.Controls.WindowStartupLocation value) where T : Avalonia.Controls.Window 
=> control._set(() => control.WindowStartupLocation = value!);

/*BindFromFuncSetterGenerator*/
public static T WindowStartupLocation<T>(this T control, Func<Avalonia.Controls.WindowStartupLocation> func, Action<Avalonia.Controls.WindowStartupLocation>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(func, Avalonia.Controls.Window.WindowStartupLocationProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T WindowStartupLocation<T>(this T control, ISignal<Avalonia.Controls.WindowStartupLocation> signal, Action<Avalonia.Controls.WindowStartupLocation>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(signal, Avalonia.Controls.Window.WindowStartupLocationProperty!, onChanged);


 // CanResize

/*ValueSetterGenerator*/
public static T CanResize<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
=> control._set(() => control.CanResize = value!);

/*BindFromFuncSetterGenerator*/
public static T CanResize<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(func, Avalonia.Controls.Window.CanResizeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CanResize<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Window 
   => control._set(signal, Avalonia.Controls.Window.CanResizeProperty!, onChanged);



//================= Events ======================//
 // Closing

/*ActionToEventGenerator*/
public static T OnClosing<T>(this T control, Action<Avalonia.Controls.WindowClosingEventArgs> action) where T : Avalonia.Controls.Window  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.WindowClosingEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Closing += h);



//================= Styles ======================//
 // SizeToContent

/*ValueStyleSetterGenerator*/
public static Style<T> SizeToContent<T>(this Style<T> style, Avalonia.Controls.SizeToContent value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.SizeToContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SizeToContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.SizeToContentProperty, binding);


 // ExtendClientAreaToDecorationsHint

/*ValueStyleSetterGenerator*/
public static Style<T> ExtendClientAreaToDecorationsHint<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ExtendClientAreaToDecorationsHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty, binding);


 // ExtendClientAreaChromeHints

/*ValueStyleSetterGenerator*/
public static Style<T> ExtendClientAreaChromeHints<T>(this Style<T> style, Avalonia.Platform.ExtendClientAreaChromeHints value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ExtendClientAreaChromeHints<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty, binding);


 // ExtendClientAreaTitleBarHeightHint

/*ValueStyleSetterGenerator*/
public static Style<T> ExtendClientAreaTitleBarHeightHint<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ExtendClientAreaTitleBarHeightHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty, binding);


 // SystemDecorations

/*ValueStyleSetterGenerator*/
public static Style<T> SystemDecorations<T>(this Style<T> style, Avalonia.Controls.SystemDecorations value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.SystemDecorationsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SystemDecorations<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.SystemDecorationsProperty, binding);


 // ShowActivated

/*ValueStyleSetterGenerator*/
public static Style<T> ShowActivated<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ShowActivatedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowActivated<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ShowActivatedProperty, binding);


 // ShowInTaskbar

/*ValueStyleSetterGenerator*/
public static Style<T> ShowInTaskbar<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ShowInTaskbarProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowInTaskbar<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ShowInTaskbarProperty, binding);


 // ClosingBehavior

/*ValueStyleSetterGenerator*/
public static Style<T> ClosingBehavior<T>(this Style<T> style, Avalonia.Controls.WindowClosingBehavior value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ClosingBehaviorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClosingBehavior<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ClosingBehaviorProperty, binding);


 // WindowState

/*ValueStyleSetterGenerator*/
public static Style<T> WindowState<T>(this Style<T> style, Avalonia.Controls.WindowState value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.WindowStateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> WindowState<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.WindowStateProperty, binding);


 // Title

/*ValueStyleSetterGenerator*/
public static Style<T> Title<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.TitleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Title<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.TitleProperty, binding);


 // Icon

/*ValueStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, Avalonia.Controls.WindowIcon value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.IconProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.IconProperty, binding);


 // WindowStartupLocation

/*ValueStyleSetterGenerator*/
public static Style<T> WindowStartupLocation<T>(this Style<T> style, Avalonia.Controls.WindowStartupLocation value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.WindowStartupLocationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> WindowStartupLocation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.WindowStartupLocationProperty, binding);


 // CanResize

/*ValueStyleSetterGenerator*/
public static Style<T> CanResize<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.CanResizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanResize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.CanResizeProperty, binding);



}
