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
public static partial class WrapPanel_MarkupExtensions
{
//================= Properties ======================//
 // ItemSpacing

/*ValueSetterGenerator*/
public static T ItemSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> control._set(() => control.ItemSpacing = value!);

/*BindFromFuncSetterGenerator*/
public static T ItemSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(func, Avalonia.Controls.WrapPanel.ItemSpacingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ItemSpacing<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(signal, Avalonia.Controls.WrapPanel.ItemSpacingProperty!, onChanged);


 // LineSpacing

/*ValueSetterGenerator*/
public static T LineSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> control._set(() => control.LineSpacing = value!);

/*BindFromFuncSetterGenerator*/
public static T LineSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(func, Avalonia.Controls.WrapPanel.LineSpacingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T LineSpacing<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(signal, Avalonia.Controls.WrapPanel.LineSpacingProperty!, onChanged);


 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.WrapPanel 
=> control._set(() => control.Orientation = value!);

/*BindFromFuncSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(func, Avalonia.Controls.WrapPanel.OrientationProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Orientation<T>(this T control, ISignal<Avalonia.Layout.Orientation> signal, Action<Avalonia.Layout.Orientation>? onChanged = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(signal, Avalonia.Controls.WrapPanel.OrientationProperty!, onChanged);


 // ItemsAlignment

/*ValueSetterGenerator*/
public static T ItemsAlignment<T>(this T control, Avalonia.Controls.WrapPanelItemsAlignment value) where T : Avalonia.Controls.WrapPanel 
=> control._set(() => control.ItemsAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T ItemsAlignment<T>(this T control, Func<Avalonia.Controls.WrapPanelItemsAlignment> func, Action<Avalonia.Controls.WrapPanelItemsAlignment>? onChanged = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(func, Avalonia.Controls.WrapPanel.ItemsAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ItemsAlignment<T>(this T control, ISignal<Avalonia.Controls.WrapPanelItemsAlignment> signal, Action<Avalonia.Controls.WrapPanelItemsAlignment>? onChanged = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(signal, Avalonia.Controls.WrapPanel.ItemsAlignmentProperty!, onChanged);


 // ItemWidth

/*ValueSetterGenerator*/
public static T ItemWidth<T>(this T control, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> control._set(() => control.ItemWidth = value!);

/*BindFromFuncSetterGenerator*/
public static T ItemWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(func, Avalonia.Controls.WrapPanel.ItemWidthProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ItemWidth<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(signal, Avalonia.Controls.WrapPanel.ItemWidthProperty!, onChanged);


 // ItemHeight

/*ValueSetterGenerator*/
public static T ItemHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> control._set(() => control.ItemHeight = value!);

/*BindFromFuncSetterGenerator*/
public static T ItemHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(func, Avalonia.Controls.WrapPanel.ItemHeightProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ItemHeight<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(signal, Avalonia.Controls.WrapPanel.ItemHeightProperty!, onChanged);



//================= Styles ======================//
 // ItemSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> ItemSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemSpacingProperty, binding);


 // LineSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> LineSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.LineSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LineSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.LineSpacingProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.OrientationProperty, binding);


 // ItemsAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsAlignment<T>(this Style<T> style, Avalonia.Controls.WrapPanelItemsAlignment value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemsAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemsAlignmentProperty, binding);


 // ItemWidth

/*ValueStyleSetterGenerator*/
public static Style<T> ItemWidth<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemWidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemWidth<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemWidthProperty, binding);


 // ItemHeight

/*ValueStyleSetterGenerator*/
public static Style<T> ItemHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemHeightProperty, binding);



}
