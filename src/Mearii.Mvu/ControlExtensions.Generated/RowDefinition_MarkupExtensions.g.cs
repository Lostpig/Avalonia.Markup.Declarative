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
public static partial class RowDefinition_MarkupExtensions
{
//================= Properties ======================//
 // MaxHeight

/*ValueSetterGenerator*/
public static T MaxHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.RowDefinition 
=> control._set(() => control.MaxHeight = value!);

/*BindFromFuncSetterGenerator*/
public static T MaxHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.RowDefinition 
   => control._set(func, Avalonia.Controls.RowDefinition.MaxHeightProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MaxHeight<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.RowDefinition 
   => control._set(signal, Avalonia.Controls.RowDefinition.MaxHeightProperty!, onChanged);


 // MinHeight

/*ValueSetterGenerator*/
public static T MinHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.RowDefinition 
=> control._set(() => control.MinHeight = value!);

/*BindFromFuncSetterGenerator*/
public static T MinHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.RowDefinition 
   => control._set(func, Avalonia.Controls.RowDefinition.MinHeightProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MinHeight<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.RowDefinition 
   => control._set(signal, Avalonia.Controls.RowDefinition.MinHeightProperty!, onChanged);


 // Height

/*ValueSetterGenerator*/
public static T Height<T>(this T control, Avalonia.Controls.GridLength value) where T : Avalonia.Controls.RowDefinition 
=> control._set(() => control.Height = value!);

/*BindFromFuncSetterGenerator*/
public static T Height<T>(this T control, Func<Avalonia.Controls.GridLength> func, Action<Avalonia.Controls.GridLength>? onChanged = null) where T : Avalonia.Controls.RowDefinition 
   => control._set(func, Avalonia.Controls.RowDefinition.HeightProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Height<T>(this T control, ISignal<Avalonia.Controls.GridLength> signal, Action<Avalonia.Controls.GridLength>? onChanged = null) where T : Avalonia.Controls.RowDefinition 
   => control._set(signal, Avalonia.Controls.RowDefinition.HeightProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T Height<T>(this T control, System.Double value = default!) where T : Avalonia.Controls.RowDefinition 
   => control._set(() => control.Height = new Avalonia.Controls.GridLength(value));
public static T Height<T>(this T control, System.Double value = default!, Avalonia.Controls.GridUnitType type = default!) where T : Avalonia.Controls.RowDefinition 
   => control._set(() => control.Height = new Avalonia.Controls.GridLength(value, type));



}
