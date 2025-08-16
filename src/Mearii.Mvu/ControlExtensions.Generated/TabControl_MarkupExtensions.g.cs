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
public static partial class TabControl_MarkupExtensions
{
//================= Properties ======================//
 // TabStripPlacement

/*ValueSetterGenerator*/
public static T TabStripPlacement<T>(this T control, Avalonia.Controls.Dock value) where T : Avalonia.Controls.TabControl 
=> control._set(() => control.TabStripPlacement = value!);

/*BindFromFuncSetterGenerator*/
public static T TabStripPlacement<T>(this T control, Func<Avalonia.Controls.Dock> func, Action<Avalonia.Controls.Dock>? onChanged = null) where T : Avalonia.Controls.TabControl 
   => control._set(func, Avalonia.Controls.TabControl.TabStripPlacementProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TabStripPlacement<T>(this T control, ISignal<Avalonia.Controls.Dock> signal, Action<Avalonia.Controls.Dock>? onChanged = null) where T : Avalonia.Controls.TabControl 
   => control._set(signal, Avalonia.Controls.TabControl.TabStripPlacementProperty!, onChanged);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.TabControl 
=> control._set(() => control.HorizontalContentAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null) where T : Avalonia.Controls.TabControl 
   => control._set(func, Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, ISignal<Avalonia.Layout.HorizontalAlignment> signal, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null) where T : Avalonia.Controls.TabControl 
   => control._set(signal, Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty!, onChanged);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.TabControl 
=> control._set(() => control.VerticalContentAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null) where T : Avalonia.Controls.TabControl 
   => control._set(func, Avalonia.Controls.TabControl.VerticalContentAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, ISignal<Avalonia.Layout.VerticalAlignment> signal, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null) where T : Avalonia.Controls.TabControl 
   => control._set(signal, Avalonia.Controls.TabControl.VerticalContentAlignmentProperty!, onChanged);


 // ContentTemplate

/*ValueSetterGenerator*/
public static T ContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.TabControl 
=> control._set(() => control.ContentTemplate = value!);

/*BindFromFuncSetterGenerator*/
public static T ContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.TabControl 
   => control._set(func, Avalonia.Controls.TabControl.ContentTemplateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ContentTemplate<T>(this T control, ISignal<Avalonia.Controls.Templates.IDataTemplate> signal, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.TabControl 
   => control._set(signal, Avalonia.Controls.TabControl.ContentTemplateProperty!, onChanged);



//================= Styles ======================//
 // TabStripPlacement

/*ValueStyleSetterGenerator*/
public static Style<T> TabStripPlacement<T>(this Style<T> style, Avalonia.Controls.Dock value) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.TabStripPlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TabStripPlacement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.TabStripPlacementProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty, binding);


 // ContentTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.ContentTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.ContentTemplateProperty, binding);



}
