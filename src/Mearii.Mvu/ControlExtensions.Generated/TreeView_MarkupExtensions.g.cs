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
public static partial class TreeView_MarkupExtensions
{
//================= Properties ======================//
 // AutoScrollToSelectedItem

/*ValueSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TreeView 
=> control._set(() => control.AutoScrollToSelectedItem = value!);

/*BindFromFuncSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TreeView 
   => control._set(func, Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TreeView 
   => control._set(signal, Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty!, onChanged);


 // SelectedItem

/*ValueSetterGenerator*/
public static T SelectedItem<T>(this T control, System.Object value) where T : Avalonia.Controls.TreeView 
=> control._set(() => control.SelectedItem = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectedItem<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.TreeView 
   => control._set(func, Avalonia.Controls.TreeView.SelectedItemProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectedItem<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.TreeView 
   => control._set(signal, Avalonia.Controls.TreeView.SelectedItemProperty!, onChanged);


 // SelectedItems

/*ValueSetterGenerator*/
public static T SelectedItems<T>(this T control, System.Collections.IList value) where T : Avalonia.Controls.TreeView 
=> control._set(() => control.SelectedItems = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectedItems<T>(this T control, Func<System.Collections.IList> func, Action<System.Collections.IList>? onChanged = null) where T : Avalonia.Controls.TreeView 
   => control._set(func, Avalonia.Controls.TreeView.SelectedItemsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectedItems<T>(this T control, ISignal<System.Collections.IList> signal, Action<System.Collections.IList>? onChanged = null) where T : Avalonia.Controls.TreeView 
   => control._set(signal, Avalonia.Controls.TreeView.SelectedItemsProperty!, onChanged);


 // SelectionMode

/*ValueSetterGenerator*/
public static T SelectionMode<T>(this T control, Avalonia.Controls.SelectionMode value) where T : Avalonia.Controls.TreeView 
=> control._set(() => control.SelectionMode = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectionMode<T>(this T control, Func<Avalonia.Controls.SelectionMode> func, Action<Avalonia.Controls.SelectionMode>? onChanged = null) where T : Avalonia.Controls.TreeView 
   => control._set(func, Avalonia.Controls.TreeView.SelectionModeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectionMode<T>(this T control, ISignal<Avalonia.Controls.SelectionMode> signal, Action<Avalonia.Controls.SelectionMode>? onChanged = null) where T : Avalonia.Controls.TreeView 
   => control._set(signal, Avalonia.Controls.TreeView.SelectionModeProperty!, onChanged);



//================= Events ======================//
 // SelectionChanged

/*ActionToEventGenerator*/
public static T OnSelectionChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action) where T : Avalonia.Controls.TreeView  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.SelectionChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectionChanged += h);



//================= Styles ======================//
 // AutoScrollToSelectedItem

/*ValueStyleSetterGenerator*/
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TreeView 
=> style._addSetter(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TreeView 
=> style._addSetter(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty, binding);


 // SelectionMode

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionMode<T>(this Style<T> style, Avalonia.Controls.SelectionMode value) where T : Avalonia.Controls.TreeView 
=> style._addSetter(Avalonia.Controls.TreeView.SelectionModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TreeView 
=> style._addSetter(Avalonia.Controls.TreeView.SelectionModeProperty, binding);



}
