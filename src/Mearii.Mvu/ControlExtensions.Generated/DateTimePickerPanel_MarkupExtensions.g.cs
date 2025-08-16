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
public static partial class DateTimePickerPanel_MarkupExtensions
{
//================= Properties ======================//
 // ItemHeight

/*ValueSetterGenerator*/
public static T ItemHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> control._set(() => control.ItemHeight = value!);

/*BindFromFuncSetterGenerator*/
public static T ItemHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(func, Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ItemHeight<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(signal, Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty!, onChanged);


 // PanelType

/*ValueSetterGenerator*/
public static T PanelType<T>(this T control, Avalonia.Controls.Primitives.DateTimePickerPanelType value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> control._set(() => control.PanelType = value!);

/*BindFromFuncSetterGenerator*/
public static T PanelType<T>(this T control, Func<Avalonia.Controls.Primitives.DateTimePickerPanelType> func, Action<Avalonia.Controls.Primitives.DateTimePickerPanelType>? onChanged = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(func, Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PanelType<T>(this T control, ISignal<Avalonia.Controls.Primitives.DateTimePickerPanelType> signal, Action<Avalonia.Controls.Primitives.DateTimePickerPanelType>? onChanged = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(signal, Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty!, onChanged);


 // ItemFormat

/*ValueSetterGenerator*/
public static T ItemFormat<T>(this T control, System.String value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> control._set(() => control.ItemFormat = value!);

/*BindFromFuncSetterGenerator*/
public static T ItemFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(func, Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ItemFormat<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(signal, Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty!, onChanged);


 // ShouldLoop

/*ValueSetterGenerator*/
public static T ShouldLoop<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> control._set(() => control.ShouldLoop = value!);

/*BindFromFuncSetterGenerator*/
public static T ShouldLoop<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(func, Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ShouldLoop<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
   => control._set(signal, Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty!, onChanged);



//================= Events ======================//
 // ScrollInvalidated

/*ActionToEventGenerator*/
public static T OnScrollInvalidated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.DateTimePickerPanel  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.ScrollInvalidated += h);


 // SelectionChanged

/*ActionToEventGenerator*/
public static T OnSelectionChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.DateTimePickerPanel  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.SelectionChanged += h);



//================= Styles ======================//
 // ItemHeight

/*ValueStyleSetterGenerator*/
public static Style<T> ItemHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty, binding);


 // PanelType

/*ValueStyleSetterGenerator*/
public static Style<T> PanelType<T>(this Style<T> style, Avalonia.Controls.Primitives.DateTimePickerPanelType value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PanelType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty, binding);


 // ItemFormat

/*ValueStyleSetterGenerator*/
public static Style<T> ItemFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty, binding);


 // ShouldLoop

/*ValueStyleSetterGenerator*/
public static Style<T> ShouldLoop<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShouldLoop<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel 
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty, binding);



}
