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
public static partial class ProgressBar_MarkupExtensions
{
//================= Properties ======================//
 // IsIndeterminate

/*ValueSetterGenerator*/
public static T IsIndeterminate<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ProgressBar 
=> control._set(() => control.IsIndeterminate = value!);

/*BindFromFuncSetterGenerator*/
public static T IsIndeterminate<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ProgressBar 
   => control._set(func, Avalonia.Controls.ProgressBar.IsIndeterminateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsIndeterminate<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ProgressBar 
   => control._set(signal, Avalonia.Controls.ProgressBar.IsIndeterminateProperty!, onChanged);


 // ShowProgressText

/*ValueSetterGenerator*/
public static T ShowProgressText<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ProgressBar 
=> control._set(() => control.ShowProgressText = value!);

/*BindFromFuncSetterGenerator*/
public static T ShowProgressText<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ProgressBar 
   => control._set(func, Avalonia.Controls.ProgressBar.ShowProgressTextProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ShowProgressText<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ProgressBar 
   => control._set(signal, Avalonia.Controls.ProgressBar.ShowProgressTextProperty!, onChanged);


 // ProgressTextFormat

/*ValueSetterGenerator*/
public static T ProgressTextFormat<T>(this T control, System.String value) where T : Avalonia.Controls.ProgressBar 
=> control._set(() => control.ProgressTextFormat = value!);

/*BindFromFuncSetterGenerator*/
public static T ProgressTextFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.ProgressBar 
   => control._set(func, Avalonia.Controls.ProgressBar.ProgressTextFormatProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ProgressTextFormat<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.ProgressBar 
   => control._set(signal, Avalonia.Controls.ProgressBar.ProgressTextFormatProperty!, onChanged);


 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.ProgressBar 
=> control._set(() => control.Orientation = value!);

/*BindFromFuncSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null) where T : Avalonia.Controls.ProgressBar 
   => control._set(func, Avalonia.Controls.ProgressBar.OrientationProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Orientation<T>(this T control, ISignal<Avalonia.Layout.Orientation> signal, Action<Avalonia.Layout.Orientation>? onChanged = null) where T : Avalonia.Controls.ProgressBar 
   => control._set(signal, Avalonia.Controls.ProgressBar.OrientationProperty!, onChanged);



//================= Styles ======================//
 // IsIndeterminate

/*ValueStyleSetterGenerator*/
public static Style<T> IsIndeterminate<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.IsIndeterminateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsIndeterminate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.IsIndeterminateProperty, binding);


 // ShowProgressText

/*ValueStyleSetterGenerator*/
public static Style<T> ShowProgressText<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.ShowProgressTextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowProgressText<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.ShowProgressTextProperty, binding);


 // ProgressTextFormat

/*ValueStyleSetterGenerator*/
public static Style<T> ProgressTextFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ProgressTextFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ProgressBar 
=> style._addSetter(Avalonia.Controls.ProgressBar.OrientationProperty, binding);



}
