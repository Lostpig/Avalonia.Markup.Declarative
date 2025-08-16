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
public static partial class ContentControl_MarkupExtensions
{
//================= Properties ======================//
 // Content

/*ValueSetterGenerator*/
public static T Content<T>(this T control, System.Object value) where T : Avalonia.Controls.ContentControl 
=> control._set(() => control.Content = value!);

/*BindFromFuncSetterGenerator*/
public static T Content<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.ContentControl 
   => control._set(func, Avalonia.Controls.ContentControl.ContentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Content<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.ContentControl 
   => control._set(signal, Avalonia.Controls.ContentControl.ContentProperty!, onChanged);


 // ContentTemplate

/*ValueSetterGenerator*/
public static T ContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ContentControl 
=> control._set(() => control.ContentTemplate = value!);

/*BindFromFuncSetterGenerator*/
public static T ContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.ContentControl 
   => control._set(func, Avalonia.Controls.ContentControl.ContentTemplateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ContentTemplate<T>(this T control, ISignal<Avalonia.Controls.Templates.IDataTemplate> signal, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.ContentControl 
   => control._set(signal, Avalonia.Controls.ContentControl.ContentTemplateProperty!, onChanged);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ContentControl 
=> control._set(() => control.HorizontalContentAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null) where T : Avalonia.Controls.ContentControl 
   => control._set(func, Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, ISignal<Avalonia.Layout.HorizontalAlignment> signal, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null) where T : Avalonia.Controls.ContentControl 
   => control._set(signal, Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty!, onChanged);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ContentControl 
=> control._set(() => control.VerticalContentAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null) where T : Avalonia.Controls.ContentControl 
   => control._set(func, Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, ISignal<Avalonia.Layout.VerticalAlignment> signal, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null) where T : Avalonia.Controls.ContentControl 
   => control._set(signal, Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty!, onChanged);



//================= Styles ======================//
 // Content

/*ValueStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.ContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Content<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.ContentProperty, binding);


 // ContentTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.ContentTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.ContentTemplateProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContentControl 
=> style._addSetter(Avalonia.Controls.ContentControl.VerticalContentAlignmentProperty, binding);



}
