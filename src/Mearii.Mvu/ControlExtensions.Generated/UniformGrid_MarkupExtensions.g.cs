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
public static partial class UniformGrid_MarkupExtensions
{
//================= Properties ======================//
 // Rows

/*ValueSetterGenerator*/
public static T Rows<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> control._set(() => control.Rows = value!);

/*BindFromFuncSetterGenerator*/
public static T Rows<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(func, Avalonia.Controls.Primitives.UniformGrid.RowsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Rows<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(signal, Avalonia.Controls.Primitives.UniformGrid.RowsProperty!, onChanged);


 // Columns

/*ValueSetterGenerator*/
public static T Columns<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> control._set(() => control.Columns = value!);

/*BindFromFuncSetterGenerator*/
public static T Columns<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(func, Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Columns<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(signal, Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty!, onChanged);


 // FirstColumn

/*ValueSetterGenerator*/
public static T FirstColumn<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> control._set(() => control.FirstColumn = value!);

/*BindFromFuncSetterGenerator*/
public static T FirstColumn<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(func, Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FirstColumn<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(signal, Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty!, onChanged);


 // RowSpacing

/*ValueSetterGenerator*/
public static T RowSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> control._set(() => control.RowSpacing = value!);

/*BindFromFuncSetterGenerator*/
public static T RowSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(func, Avalonia.Controls.Primitives.UniformGrid.RowSpacingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T RowSpacing<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(signal, Avalonia.Controls.Primitives.UniformGrid.RowSpacingProperty!, onChanged);


 // ColumnSpacing

/*ValueSetterGenerator*/
public static T ColumnSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> control._set(() => control.ColumnSpacing = value!);

/*BindFromFuncSetterGenerator*/
public static T ColumnSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(func, Avalonia.Controls.Primitives.UniformGrid.ColumnSpacingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ColumnSpacing<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(signal, Avalonia.Controls.Primitives.UniformGrid.ColumnSpacingProperty!, onChanged);



//================= Styles ======================//
 // Rows

/*ValueStyleSetterGenerator*/
public static Style<T> Rows<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.RowsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Rows<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.RowsProperty, binding);


 // Columns

/*ValueStyleSetterGenerator*/
public static Style<T> Columns<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Columns<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty, binding);


 // FirstColumn

/*ValueStyleSetterGenerator*/
public static Style<T> FirstColumn<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FirstColumn<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty, binding);


 // RowSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> RowSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.RowSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RowSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.RowSpacingProperty, binding);


 // ColumnSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> ColumnSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.ColumnSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ColumnSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.ColumnSpacingProperty, binding);



}
