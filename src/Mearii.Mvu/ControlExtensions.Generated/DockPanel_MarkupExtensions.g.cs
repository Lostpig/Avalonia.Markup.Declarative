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
public static partial class DockPanel_MarkupExtensions
{
//================= Properties ======================//
 // LastChildFill

/*ValueSetterGenerator*/
public static T LastChildFill<T>(this T control, System.Boolean value) where T : Avalonia.Controls.DockPanel 
=> control._set(() => control.LastChildFill = value!);

/*BindFromFuncSetterGenerator*/
public static T LastChildFill<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.DockPanel 
   => control._set(func, Avalonia.Controls.DockPanel.LastChildFillProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T LastChildFill<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.DockPanel 
   => control._set(signal, Avalonia.Controls.DockPanel.LastChildFillProperty!, onChanged);


 // HorizontalSpacing

/*ValueSetterGenerator*/
public static T HorizontalSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.DockPanel 
=> control._set(() => control.HorizontalSpacing = value!);

/*BindFromFuncSetterGenerator*/
public static T HorizontalSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.DockPanel 
   => control._set(func, Avalonia.Controls.DockPanel.HorizontalSpacingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HorizontalSpacing<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.DockPanel 
   => control._set(signal, Avalonia.Controls.DockPanel.HorizontalSpacingProperty!, onChanged);


 // VerticalSpacing

/*ValueSetterGenerator*/
public static T VerticalSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.DockPanel 
=> control._set(() => control.VerticalSpacing = value!);

/*BindFromFuncSetterGenerator*/
public static T VerticalSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.DockPanel 
   => control._set(func, Avalonia.Controls.DockPanel.VerticalSpacingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T VerticalSpacing<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.DockPanel 
   => control._set(signal, Avalonia.Controls.DockPanel.VerticalSpacingProperty!, onChanged);



//================= Attached Properties ======================//
 // Dock

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T DockPanel_Dock<T>(this T control, Func<Avalonia.Controls.Dock> func, Action<Avalonia.Controls.Dock>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.DockPanel.DockProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T DockPanel_Dock<T>(this T control, ISignal<Avalonia.Controls.Dock> signal, Action<Avalonia.Controls.Dock>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.DockPanel.DockProperty!, onChanged);



//================= Styles ======================//
 // LastChildFill

/*ValueStyleSetterGenerator*/
public static Style<T> LastChildFill<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DockPanel 
=> style._addSetter(Avalonia.Controls.DockPanel.LastChildFillProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LastChildFill<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DockPanel 
=> style._addSetter(Avalonia.Controls.DockPanel.LastChildFillProperty, binding);


 // HorizontalSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.DockPanel 
=> style._addSetter(Avalonia.Controls.DockPanel.HorizontalSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DockPanel 
=> style._addSetter(Avalonia.Controls.DockPanel.HorizontalSpacingProperty, binding);


 // VerticalSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.DockPanel 
=> style._addSetter(Avalonia.Controls.DockPanel.VerticalSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DockPanel 
=> style._addSetter(Avalonia.Controls.DockPanel.VerticalSpacingProperty, binding);



}
