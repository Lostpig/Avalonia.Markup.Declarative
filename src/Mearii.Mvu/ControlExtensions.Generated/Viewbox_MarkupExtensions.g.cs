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
public static partial class Viewbox_MarkupExtensions
{
//================= Properties ======================//
 // Stretch

/*ValueSetterGenerator*/
public static T Stretch<T>(this T control, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Viewbox 
=> control._set(() => control.Stretch = value!);

/*BindFromFuncSetterGenerator*/
public static T Stretch<T>(this T control, Func<Avalonia.Media.Stretch> func, Action<Avalonia.Media.Stretch>? onChanged = null) where T : Avalonia.Controls.Viewbox 
   => control._set(func, Avalonia.Controls.Viewbox.StretchProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Stretch<T>(this T control, ISignal<Avalonia.Media.Stretch> signal, Action<Avalonia.Media.Stretch>? onChanged = null) where T : Avalonia.Controls.Viewbox 
   => control._set(signal, Avalonia.Controls.Viewbox.StretchProperty!, onChanged);


 // StretchDirection

/*ValueSetterGenerator*/
public static T StretchDirection<T>(this T control, Avalonia.Media.StretchDirection value) where T : Avalonia.Controls.Viewbox 
=> control._set(() => control.StretchDirection = value!);

/*BindFromFuncSetterGenerator*/
public static T StretchDirection<T>(this T control, Func<Avalonia.Media.StretchDirection> func, Action<Avalonia.Media.StretchDirection>? onChanged = null) where T : Avalonia.Controls.Viewbox 
   => control._set(func, Avalonia.Controls.Viewbox.StretchDirectionProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T StretchDirection<T>(this T control, ISignal<Avalonia.Media.StretchDirection> signal, Action<Avalonia.Media.StretchDirection>? onChanged = null) where T : Avalonia.Controls.Viewbox 
   => control._set(signal, Avalonia.Controls.Viewbox.StretchDirectionProperty!, onChanged);


 // Child

/*ValueSetterGenerator*/
public static T Child<T>(this T control, Avalonia.Controls.Control value) where T : Avalonia.Controls.Viewbox 
=> control._set(() => control.Child = value!);

/*BindFromFuncSetterGenerator*/
public static T Child<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null) where T : Avalonia.Controls.Viewbox 
   => control._set(func, Avalonia.Controls.Viewbox.ChildProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Child<T>(this T control, ISignal<Avalonia.Controls.Control> signal, Action<Avalonia.Controls.Control>? onChanged = null) where T : Avalonia.Controls.Viewbox 
   => control._set(signal, Avalonia.Controls.Viewbox.ChildProperty!, onChanged);



//================= Styles ======================//
 // Stretch

/*ValueStyleSetterGenerator*/
public static Style<T> Stretch<T>(this Style<T> style, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Viewbox 
=> style._addSetter(Avalonia.Controls.Viewbox.StretchProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Stretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Viewbox 
=> style._addSetter(Avalonia.Controls.Viewbox.StretchProperty, binding);


 // StretchDirection

/*ValueStyleSetterGenerator*/
public static Style<T> StretchDirection<T>(this Style<T> style, Avalonia.Media.StretchDirection value) where T : Avalonia.Controls.Viewbox 
=> style._addSetter(Avalonia.Controls.Viewbox.StretchDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StretchDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Viewbox 
=> style._addSetter(Avalonia.Controls.Viewbox.StretchDirectionProperty, binding);


 // Child

/*ValueStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Viewbox 
=> style._addSetter(Avalonia.Controls.Viewbox.ChildProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Viewbox 
=> style._addSetter(Avalonia.Controls.Viewbox.ChildProperty, binding);



}
