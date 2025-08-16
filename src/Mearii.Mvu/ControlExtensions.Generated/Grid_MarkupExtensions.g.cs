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
public static partial class Grid_MarkupExtensions
{
//================= Properties ======================//
 // ShowGridLines

/*ValueSetterGenerator*/
public static T ShowGridLines<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Grid 
=> control._set(() => control.ShowGridLines = value!);

/*BindFromFuncSetterGenerator*/
public static T ShowGridLines<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Grid 
   => control._set(func, Avalonia.Controls.Grid.ShowGridLinesProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ShowGridLines<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Grid 
   => control._set(signal, Avalonia.Controls.Grid.ShowGridLinesProperty!, onChanged);


 // RowSpacing

/*ValueSetterGenerator*/
public static T RowSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.Grid 
=> control._set(() => control.RowSpacing = value!);

/*BindFromFuncSetterGenerator*/
public static T RowSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Grid 
   => control._set(func, Avalonia.Controls.Grid.RowSpacingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T RowSpacing<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Grid 
   => control._set(signal, Avalonia.Controls.Grid.RowSpacingProperty!, onChanged);


 // ColumnSpacing

/*ValueSetterGenerator*/
public static T ColumnSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.Grid 
=> control._set(() => control.ColumnSpacing = value!);

/*BindFromFuncSetterGenerator*/
public static T ColumnSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Grid 
   => control._set(func, Avalonia.Controls.Grid.ColumnSpacingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ColumnSpacing<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.Grid 
   => control._set(signal, Avalonia.Controls.Grid.ColumnSpacingProperty!, onChanged);



//================= Attached Properties ======================//
 // Column

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T Grid_Column<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.Grid.ColumnProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T Grid_Column<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.Grid.ColumnProperty!, onChanged);


 // Row

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T Grid_Row<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.Grid.RowProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T Grid_Row<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.Grid.RowProperty!, onChanged);


 // ColumnSpan

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T Grid_ColumnSpan<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.Grid.ColumnSpanProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T Grid_ColumnSpan<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.Grid.ColumnSpanProperty!, onChanged);


 // RowSpan

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T Grid_RowSpan<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.Grid.RowSpanProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T Grid_RowSpan<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.Grid.RowSpanProperty!, onChanged);


 // IsSharedSizeScope

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T Grid_IsSharedSizeScope<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.Grid.IsSharedSizeScopeProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T Grid_IsSharedSizeScope<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.Grid.IsSharedSizeScopeProperty!, onChanged);



//================= Styles ======================//
 // ShowGridLines

/*ValueStyleSetterGenerator*/
public static Style<T> ShowGridLines<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Grid 
=> style._addSetter(Avalonia.Controls.Grid.ShowGridLinesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowGridLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Grid 
=> style._addSetter(Avalonia.Controls.Grid.ShowGridLinesProperty, binding);


 // RowSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> RowSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Grid 
=> style._addSetter(Avalonia.Controls.Grid.RowSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RowSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Grid 
=> style._addSetter(Avalonia.Controls.Grid.RowSpacingProperty, binding);


 // ColumnSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> ColumnSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Grid 
=> style._addSetter(Avalonia.Controls.Grid.ColumnSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ColumnSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Grid 
=> style._addSetter(Avalonia.Controls.Grid.ColumnSpacingProperty, binding);



}
