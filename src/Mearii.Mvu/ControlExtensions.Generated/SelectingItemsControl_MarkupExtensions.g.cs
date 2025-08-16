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
public static partial class SelectingItemsControl_MarkupExtensions
{
//================= Properties ======================//
 // AutoScrollToSelectedItem

/*ValueSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> control._set(() => control.AutoScrollToSelectedItem = value!);

/*BindFromFuncSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(func, Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(signal, Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty!, onChanged);


 // SelectedIndex

/*ValueSetterGenerator*/
public static T SelectedIndex<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> control._set(() => control.SelectedIndex = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectedIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(func, Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectedIndex<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(signal, Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty!, onChanged);


 // SelectedItem

/*ValueSetterGenerator*/
public static T SelectedItem<T>(this T control, System.Object value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> control._set(() => control.SelectedItem = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectedItem<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(func, Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectedItem<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(signal, Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty!, onChanged);


 // SelectedValue

/*ValueSetterGenerator*/
public static T SelectedValue<T>(this T control, System.Object value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> control._set(() => control.SelectedValue = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectedValue<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(func, Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectedValue<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(signal, Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty!, onChanged);


 // SelectedValueBinding

/*ValueSetterGenerator*/
public static T SelectedValueBinding<T>(this T control, Avalonia.Data.IBinding value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> control._set(() => control.SelectedValueBinding = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectedValueBinding<T>(this T control, Func<Avalonia.Data.IBinding> func, Action<Avalonia.Data.IBinding>? onChanged = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(func, Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectedValueBinding<T>(this T control, ISignal<Avalonia.Data.IBinding> signal, Action<Avalonia.Data.IBinding>? onChanged = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(signal, Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty!, onChanged);


 // IsTextSearchEnabled

/*ValueSetterGenerator*/
public static T IsTextSearchEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> control._set(() => control.IsTextSearchEnabled = value!);

/*BindFromFuncSetterGenerator*/
public static T IsTextSearchEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(func, Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsTextSearchEnabled<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(signal, Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty!, onChanged);


 // WrapSelection

/*ValueSetterGenerator*/
public static T WrapSelection<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> control._set(() => control.WrapSelection = value!);

/*BindFromFuncSetterGenerator*/
public static T WrapSelection<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(func, Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T WrapSelection<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
   => control._set(signal, Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty!, onChanged);



//================= Events ======================//
 // SelectionChanged

/*ActionToEventGenerator*/
public static T OnSelectionChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
{
  control.AddHandler(Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // AutoScrollToSelectedItem

/*ValueStyleSetterGenerator*/
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty, binding);


 // SelectedValue

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedValue<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedValue<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty, binding);


 // SelectedValueBinding

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedValueBinding<T>(this Style<T> style, Avalonia.Data.IBinding value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped SelectedValueBinding because already exist in value setters


 // IsTextSearchEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsTextSearchEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTextSearchEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty, binding);


 // WrapSelection

/*ValueStyleSetterGenerator*/
public static Style<T> WrapSelection<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> WrapSelection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl 
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty, binding);



}
