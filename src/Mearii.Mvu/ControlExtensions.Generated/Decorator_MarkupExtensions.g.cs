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
public static partial class Decorator_MarkupExtensions
{
//================= Properties ======================//
 // Child

/*ValueSetterGenerator*/
public static T Child<T>(this T control, Avalonia.Controls.Control value) where T : Avalonia.Controls.Decorator 
=> control._set(() => control.Child = value!);

/*BindFromFuncSetterGenerator*/
public static T Child<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null) where T : Avalonia.Controls.Decorator 
   => control._set(func, Avalonia.Controls.Decorator.ChildProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Child<T>(this T control, ISignal<Avalonia.Controls.Control> signal, Action<Avalonia.Controls.Control>? onChanged = null) where T : Avalonia.Controls.Decorator 
   => control._set(signal, Avalonia.Controls.Decorator.ChildProperty!, onChanged);


 // Padding

/*ValueSetterGenerator*/
public static T Padding<T>(this T control, Avalonia.Thickness value) where T : Avalonia.Controls.Decorator 
=> control._set(() => control.Padding = value!);

/*BindFromFuncSetterGenerator*/
public static T Padding<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null) where T : Avalonia.Controls.Decorator 
   => control._set(func, Avalonia.Controls.Decorator.PaddingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Padding<T>(this T control, ISignal<Avalonia.Thickness> signal, Action<Avalonia.Thickness>? onChanged = null) where T : Avalonia.Controls.Decorator 
   => control._set(signal, Avalonia.Controls.Decorator.PaddingProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T Padding<T>(this T control, System.Double uniformLength = default!) where T : Avalonia.Controls.Decorator 
   => control._set(() => control.Padding = new Avalonia.Thickness(uniformLength));
public static T Padding<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Avalonia.Controls.Decorator 
   => control._set(() => control.Padding = new Avalonia.Thickness(horizontal, vertical));
public static T Padding<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Avalonia.Controls.Decorator 
   => control._set(() => control.Padding = new Avalonia.Thickness(left, top, right, bottom));



//================= Styles ======================//
 // Child

/*ValueStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Decorator 
=> style._addSetter(Avalonia.Controls.Decorator.ChildProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Decorator 
=> style._addSetter(Avalonia.Controls.Decorator.ChildProperty, binding);


 // Padding

/*ValueStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Decorator 
=> style._addSetter(Avalonia.Controls.Decorator.PaddingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Decorator 
=> style._addSetter(Avalonia.Controls.Decorator.PaddingProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> Padding<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Decorator 
   => style._addSetter(Avalonia.Controls.Decorator.PaddingProperty, new Avalonia.Thickness(uniformLength));public static Style<T> Padding<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Decorator 
   => style._addSetter(Avalonia.Controls.Decorator.PaddingProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> Padding<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Decorator 
   => style._addSetter(Avalonia.Controls.Decorator.PaddingProperty, new Avalonia.Thickness(left, top, right, bottom));



}
