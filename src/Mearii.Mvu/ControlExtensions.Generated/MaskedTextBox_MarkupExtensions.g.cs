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
public static partial class MaskedTextBox_MarkupExtensions
{
//================= Properties ======================//
 // AsciiOnly

/*ValueSetterGenerator*/
public static T AsciiOnly<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> control._set(() => control.AsciiOnly = value!);

/*BindFromFuncSetterGenerator*/
public static T AsciiOnly<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(func, Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T AsciiOnly<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(signal, Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty!, onChanged);


 // Culture

/*ValueSetterGenerator*/
public static T Culture<T>(this T control, System.Globalization.CultureInfo value) where T : Avalonia.Controls.MaskedTextBox 
=> control._set(() => control.Culture = value!);

/*BindFromFuncSetterGenerator*/
public static T Culture<T>(this T control, Func<System.Globalization.CultureInfo> func, Action<System.Globalization.CultureInfo>? onChanged = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(func, Avalonia.Controls.MaskedTextBox.CultureProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Culture<T>(this T control, ISignal<System.Globalization.CultureInfo> signal, Action<System.Globalization.CultureInfo>? onChanged = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(signal, Avalonia.Controls.MaskedTextBox.CultureProperty!, onChanged);


 // HidePromptOnLeave

/*ValueSetterGenerator*/
public static T HidePromptOnLeave<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> control._set(() => control.HidePromptOnLeave = value!);

/*BindFromFuncSetterGenerator*/
public static T HidePromptOnLeave<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(func, Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HidePromptOnLeave<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(signal, Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty!, onChanged);


 // Mask

/*ValueSetterGenerator*/
public static T Mask<T>(this T control, System.String value) where T : Avalonia.Controls.MaskedTextBox 
=> control._set(() => control.Mask = value!);

/*BindFromFuncSetterGenerator*/
public static T Mask<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(func, Avalonia.Controls.MaskedTextBox.MaskProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Mask<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(signal, Avalonia.Controls.MaskedTextBox.MaskProperty!, onChanged);


 // PromptChar

/*ValueSetterGenerator*/
public static T PromptChar<T>(this T control, System.Char value) where T : Avalonia.Controls.MaskedTextBox 
=> control._set(() => control.PromptChar = value!);

/*BindFromFuncSetterGenerator*/
public static T PromptChar<T>(this T control, Func<System.Char> func, Action<System.Char>? onChanged = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(func, Avalonia.Controls.MaskedTextBox.PromptCharProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PromptChar<T>(this T control, ISignal<System.Char> signal, Action<System.Char>? onChanged = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(signal, Avalonia.Controls.MaskedTextBox.PromptCharProperty!, onChanged);


 // ResetOnPrompt

/*ValueSetterGenerator*/
public static T ResetOnPrompt<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> control._set(() => control.ResetOnPrompt = value!);

/*BindFromFuncSetterGenerator*/
public static T ResetOnPrompt<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(func, Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ResetOnPrompt<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(signal, Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty!, onChanged);


 // ResetOnSpace

/*ValueSetterGenerator*/
public static T ResetOnSpace<T>(this T control, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> control._set(() => control.ResetOnSpace = value!);

/*BindFromFuncSetterGenerator*/
public static T ResetOnSpace<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(func, Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ResetOnSpace<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(signal, Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty!, onChanged);



//================= Styles ======================//
 // AsciiOnly

/*ValueStyleSetterGenerator*/
public static Style<T> AsciiOnly<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AsciiOnly<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty, binding);


 // Culture

/*ValueStyleSetterGenerator*/
public static Style<T> Culture<T>(this Style<T> style, System.Globalization.CultureInfo value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.CultureProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Culture<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.CultureProperty, binding);


 // HidePromptOnLeave

/*ValueStyleSetterGenerator*/
public static Style<T> HidePromptOnLeave<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HidePromptOnLeave<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty, binding);


 // Mask

/*ValueStyleSetterGenerator*/
public static Style<T> Mask<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.MaskProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Mask<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.MaskProperty, binding);


 // PromptChar

/*ValueStyleSetterGenerator*/
public static Style<T> PromptChar<T>(this Style<T> style, System.Char value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.PromptCharProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PromptChar<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.PromptCharProperty, binding);


 // ResetOnPrompt

/*ValueStyleSetterGenerator*/
public static Style<T> ResetOnPrompt<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ResetOnPrompt<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty, binding);


 // ResetOnSpace

/*ValueStyleSetterGenerator*/
public static Style<T> ResetOnSpace<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ResetOnSpace<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty, binding);



}
