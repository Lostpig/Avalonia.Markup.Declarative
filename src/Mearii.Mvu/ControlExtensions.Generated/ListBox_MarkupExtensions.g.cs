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
public static partial class ListBox_MarkupExtensions
{
//================= Properties ======================//
 // SelectedItems

/*ValueSetterGenerator*/
public static T SelectedItems<T>(this T control, System.Collections.IList value) where T : Avalonia.Controls.ListBox 
=> control._set(() => control.SelectedItems = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectedItems<T>(this T control, Func<System.Collections.IList> func, Action<System.Collections.IList>? onChanged = null) where T : Avalonia.Controls.ListBox 
   => control._set(func, Avalonia.Controls.ListBox.SelectedItemsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectedItems<T>(this T control, ISignal<System.Collections.IList> signal, Action<System.Collections.IList>? onChanged = null) where T : Avalonia.Controls.ListBox 
   => control._set(signal, Avalonia.Controls.ListBox.SelectedItemsProperty!, onChanged);


 // Selection

/*ValueSetterGenerator*/
public static T Selection<T>(this T control, Avalonia.Controls.Selection.ISelectionModel value) where T : Avalonia.Controls.ListBox 
=> control._set(() => control.Selection = value!);

/*BindFromFuncSetterGenerator*/
public static T Selection<T>(this T control, Func<Avalonia.Controls.Selection.ISelectionModel> func, Action<Avalonia.Controls.Selection.ISelectionModel>? onChanged = null) where T : Avalonia.Controls.ListBox 
   => control._set(func, Avalonia.Controls.ListBox.SelectionProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Selection<T>(this T control, ISignal<Avalonia.Controls.Selection.ISelectionModel> signal, Action<Avalonia.Controls.Selection.ISelectionModel>? onChanged = null) where T : Avalonia.Controls.ListBox 
   => control._set(signal, Avalonia.Controls.ListBox.SelectionProperty!, onChanged);


 // SelectionMode

/*ValueSetterGenerator*/
public static T SelectionMode<T>(this T control, Avalonia.Controls.SelectionMode value) where T : Avalonia.Controls.ListBox 
=> control._set(() => control.SelectionMode = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectionMode<T>(this T control, Func<Avalonia.Controls.SelectionMode> func, Action<Avalonia.Controls.SelectionMode>? onChanged = null) where T : Avalonia.Controls.ListBox 
   => control._set(func, Avalonia.Controls.ListBox.SelectionModeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectionMode<T>(this T control, ISignal<Avalonia.Controls.SelectionMode> signal, Action<Avalonia.Controls.SelectionMode>? onChanged = null) where T : Avalonia.Controls.ListBox 
   => control._set(signal, Avalonia.Controls.ListBox.SelectionModeProperty!, onChanged);



//================= Styles ======================//
 // SelectionMode

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionMode<T>(this Style<T> style, Avalonia.Controls.SelectionMode value) where T : Avalonia.Controls.ListBox 
=> style._addSetter(Avalonia.Controls.ListBox.SelectionModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ListBox 
=> style._addSetter(Avalonia.Controls.ListBox.SelectionModeProperty, binding);



}
