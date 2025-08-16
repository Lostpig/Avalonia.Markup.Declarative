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
public static partial class ToggleSwitch_MarkupExtensions
{
//================= Properties ======================//
 // OffContent

/*ValueSetterGenerator*/
public static T OffContent<T>(this T control, System.Object value) where T : Avalonia.Controls.ToggleSwitch 
=> control._set(() => control.OffContent = value!);

/*BindFromFuncSetterGenerator*/
public static T OffContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(func, Avalonia.Controls.ToggleSwitch.OffContentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T OffContent<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(signal, Avalonia.Controls.ToggleSwitch.OffContentProperty!, onChanged);


 // OffContentTemplate

/*ValueSetterGenerator*/
public static T OffContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ToggleSwitch 
=> control._set(() => control.OffContentTemplate = value!);

/*BindFromFuncSetterGenerator*/
public static T OffContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(func, Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T OffContentTemplate<T>(this T control, ISignal<Avalonia.Controls.Templates.IDataTemplate> signal, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(signal, Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty!, onChanged);


 // OnContent

/*ValueSetterGenerator*/
public static T OnContent<T>(this T control, System.Object value) where T : Avalonia.Controls.ToggleSwitch 
=> control._set(() => control.OnContent = value!);

/*BindFromFuncSetterGenerator*/
public static T OnContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(func, Avalonia.Controls.ToggleSwitch.OnContentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T OnContent<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(signal, Avalonia.Controls.ToggleSwitch.OnContentProperty!, onChanged);


 // OnContentTemplate

/*ValueSetterGenerator*/
public static T OnContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ToggleSwitch 
=> control._set(() => control.OnContentTemplate = value!);

/*BindFromFuncSetterGenerator*/
public static T OnContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(func, Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T OnContentTemplate<T>(this T control, ISignal<Avalonia.Controls.Templates.IDataTemplate> signal, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(signal, Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty!, onChanged);


 // KnobTransitions

/*ValueSetterGenerator*/
public static T KnobTransitions<T>(this T control, Avalonia.Animation.Transitions value) where T : Avalonia.Controls.ToggleSwitch 
=> control._set(() => control.KnobTransitions = value!);

/*BindFromFuncSetterGenerator*/
public static T KnobTransitions<T>(this T control, Func<Avalonia.Animation.Transitions> func, Action<Avalonia.Animation.Transitions>? onChanged = null) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(func, Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T KnobTransitions<T>(this T control, ISignal<Avalonia.Animation.Transitions> signal, Action<Avalonia.Animation.Transitions>? onChanged = null) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(signal, Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty!, onChanged);



//================= Styles ======================//
 // OffContent

/*ValueStyleSetterGenerator*/
public static Style<T> OffContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OffContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OffContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OffContentProperty, binding);


 // OffContentTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> OffContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OffContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty, binding);


 // OnContent

/*ValueStyleSetterGenerator*/
public static Style<T> OnContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OnContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OnContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OnContentProperty, binding);


 // OnContentTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> OnContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OnContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty, binding);


 // KnobTransitions

/*ValueStyleSetterGenerator*/
public static Style<T> KnobTransitions<T>(this Style<T> style, Avalonia.Animation.Transitions value) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> KnobTransitions<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty, binding);



}
