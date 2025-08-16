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
public static partial class ComboBox_MarkupExtensions
{
//================= Properties ======================//
 // IsDropDownOpen

/*ValueSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.IsDropDownOpen = value!);

/*BindFromFuncSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ComboBox 
   => control._set(func, Avalonia.Controls.ComboBox.IsDropDownOpenProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ComboBox 
   => control._set(signal, Avalonia.Controls.ComboBox.IsDropDownOpenProperty!, onChanged);


 // MaxDropDownHeight

/*ValueSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.MaxDropDownHeight = value!);

/*BindFromFuncSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.ComboBox 
   => control._set(func, Avalonia.Controls.ComboBox.MaxDropDownHeightProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.ComboBox 
   => control._set(signal, Avalonia.Controls.ComboBox.MaxDropDownHeightProperty!, onChanged);


 // PlaceholderText

/*ValueSetterGenerator*/
public static T PlaceholderText<T>(this T control, System.String value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.PlaceholderText = value!);

/*BindFromFuncSetterGenerator*/
public static T PlaceholderText<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.ComboBox 
   => control._set(func, Avalonia.Controls.ComboBox.PlaceholderTextProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PlaceholderText<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.ComboBox 
   => control._set(signal, Avalonia.Controls.ComboBox.PlaceholderTextProperty!, onChanged);


 // PlaceholderForeground

/*ValueSetterGenerator*/
public static T PlaceholderForeground<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.PlaceholderForeground = value!);

/*BindFromFuncSetterGenerator*/
public static T PlaceholderForeground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.ComboBox 
   => control._set(func, Avalonia.Controls.ComboBox.PlaceholderForegroundProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PlaceholderForeground<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.ComboBox 
   => control._set(signal, Avalonia.Controls.ComboBox.PlaceholderForegroundProperty!, onChanged);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.HorizontalContentAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null) where T : Avalonia.Controls.ComboBox 
   => control._set(func, Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, ISignal<Avalonia.Layout.HorizontalAlignment> signal, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null) where T : Avalonia.Controls.ComboBox 
   => control._set(signal, Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty!, onChanged);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.VerticalContentAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null) where T : Avalonia.Controls.ComboBox 
   => control._set(func, Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, ISignal<Avalonia.Layout.VerticalAlignment> signal, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null) where T : Avalonia.Controls.ComboBox 
   => control._set(signal, Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty!, onChanged);


 // SelectionBoxItemTemplate

/*ValueSetterGenerator*/
public static T SelectionBoxItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.SelectionBoxItemTemplate = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectionBoxItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.ComboBox 
   => control._set(func, Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectionBoxItemTemplate<T>(this T control, ISignal<Avalonia.Controls.Templates.IDataTemplate> signal, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.ComboBox 
   => control._set(signal, Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty!, onChanged);



//================= Events ======================//
 // DropDownClosed

/*ActionToEventGenerator*/
public static T OnDropDownClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.ComboBox  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DropDownClosed += h);


 // DropDownOpened

/*ActionToEventGenerator*/
public static T OnDropDownOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.ComboBox  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DropDownOpened += h);



//================= Styles ======================//
 // IsDropDownOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.IsDropDownOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.IsDropDownOpenProperty, binding);


 // MaxDropDownHeight

/*ValueStyleSetterGenerator*/
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty, binding);


 // PlaceholderText

/*ValueStyleSetterGenerator*/
public static Style<T> PlaceholderText<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.PlaceholderTextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlaceholderText<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.PlaceholderTextProperty, binding);


 // PlaceholderForeground

/*ValueStyleSetterGenerator*/
public static Style<T> PlaceholderForeground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlaceholderForeground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty, binding);


 // SelectionBoxItemTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionBoxItemTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionBoxItemTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty, binding);



}
