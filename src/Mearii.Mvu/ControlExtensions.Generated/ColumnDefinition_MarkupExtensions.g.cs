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
public static partial class ColumnDefinition_MarkupExtensions
{
//================= Properties ======================//
 // MaxWidth

/*ValueSetterGenerator*/
public static T MaxWidth<T>(this T control, System.Double value) where T : Avalonia.Controls.ColumnDefinition 
=> control._set(() => control.MaxWidth = value!);

/*BindFromFuncSetterGenerator*/
public static T MaxWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(func, Avalonia.Controls.ColumnDefinition.MaxWidthProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MaxWidth<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(signal, Avalonia.Controls.ColumnDefinition.MaxWidthProperty!, onChanged);


 // MinWidth

/*ValueSetterGenerator*/
public static T MinWidth<T>(this T control, System.Double value) where T : Avalonia.Controls.ColumnDefinition 
=> control._set(() => control.MinWidth = value!);

/*BindFromFuncSetterGenerator*/
public static T MinWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(func, Avalonia.Controls.ColumnDefinition.MinWidthProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MinWidth<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(signal, Avalonia.Controls.ColumnDefinition.MinWidthProperty!, onChanged);


 // Width

/*ValueSetterGenerator*/
public static T Width<T>(this T control, Avalonia.Controls.GridLength value) where T : Avalonia.Controls.ColumnDefinition 
=> control._set(() => control.Width = value!);

/*BindFromFuncSetterGenerator*/
public static T Width<T>(this T control, Func<Avalonia.Controls.GridLength> func, Action<Avalonia.Controls.GridLength>? onChanged = null) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(func, Avalonia.Controls.ColumnDefinition.WidthProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Width<T>(this T control, ISignal<Avalonia.Controls.GridLength> signal, Action<Avalonia.Controls.GridLength>? onChanged = null) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(signal, Avalonia.Controls.ColumnDefinition.WidthProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T Width<T>(this T control, System.Double value = default!) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(() => control.Width = new Avalonia.Controls.GridLength(value));
public static T Width<T>(this T control, System.Double value = default!, Avalonia.Controls.GridUnitType type = default!) where T : Avalonia.Controls.ColumnDefinition 
   => control._set(() => control.Width = new Avalonia.Controls.GridLength(value, type));



}
