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
public static partial class ButtonSpinner_MarkupExtensions
{
//================= Properties ======================//
 // AllowSpin

/*ValueSetterGenerator*/
public static T AllowSpin<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ButtonSpinner 
=> control._set(() => control.AllowSpin = value!);

/*BindFromFuncSetterGenerator*/
public static T AllowSpin<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ButtonSpinner 
   => control._set(func, Avalonia.Controls.ButtonSpinner.AllowSpinProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T AllowSpin<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ButtonSpinner 
   => control._set(signal, Avalonia.Controls.ButtonSpinner.AllowSpinProperty!, onChanged);


 // ShowButtonSpinner

/*ValueSetterGenerator*/
public static T ShowButtonSpinner<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ButtonSpinner 
=> control._set(() => control.ShowButtonSpinner = value!);

/*BindFromFuncSetterGenerator*/
public static T ShowButtonSpinner<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ButtonSpinner 
   => control._set(func, Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ShowButtonSpinner<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ButtonSpinner 
   => control._set(signal, Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty!, onChanged);


 // ButtonSpinnerLocation

/*ValueSetterGenerator*/
public static T ButtonSpinnerLocation<T>(this T control, Avalonia.Controls.Location value) where T : Avalonia.Controls.ButtonSpinner 
=> control._set(() => control.ButtonSpinnerLocation = value!);

/*BindFromFuncSetterGenerator*/
public static T ButtonSpinnerLocation<T>(this T control, Func<Avalonia.Controls.Location> func, Action<Avalonia.Controls.Location>? onChanged = null) where T : Avalonia.Controls.ButtonSpinner 
   => control._set(func, Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ButtonSpinnerLocation<T>(this T control, ISignal<Avalonia.Controls.Location> signal, Action<Avalonia.Controls.Location>? onChanged = null) where T : Avalonia.Controls.ButtonSpinner 
   => control._set(signal, Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty!, onChanged);



//================= Styles ======================//
 // AllowSpin

/*ValueStyleSetterGenerator*/
public static Style<T> AllowSpin<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ButtonSpinner 
=> style._addSetter(Avalonia.Controls.ButtonSpinner.AllowSpinProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AllowSpin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ButtonSpinner 
=> style._addSetter(Avalonia.Controls.ButtonSpinner.AllowSpinProperty, binding);


 // ShowButtonSpinner

/*ValueStyleSetterGenerator*/
public static Style<T> ShowButtonSpinner<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ButtonSpinner 
=> style._addSetter(Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowButtonSpinner<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ButtonSpinner 
=> style._addSetter(Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty, binding);


 // ButtonSpinnerLocation

/*ValueStyleSetterGenerator*/
public static Style<T> ButtonSpinnerLocation<T>(this Style<T> style, Avalonia.Controls.Location value) where T : Avalonia.Controls.ButtonSpinner 
=> style._addSetter(Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ButtonSpinnerLocation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ButtonSpinner 
=> style._addSetter(Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty, binding);



}
