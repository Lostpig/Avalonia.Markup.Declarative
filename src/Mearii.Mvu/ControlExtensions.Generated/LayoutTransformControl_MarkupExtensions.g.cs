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
public static partial class LayoutTransformControl_MarkupExtensions
{
//================= Properties ======================//
 // LayoutTransform

/*ValueSetterGenerator*/
public static T LayoutTransform<T>(this T control, Avalonia.Media.ITransform value) where T : Avalonia.Controls.LayoutTransformControl 
=> control._set(() => control.LayoutTransform = value!);

/*BindFromFuncSetterGenerator*/
public static T LayoutTransform<T>(this T control, Func<Avalonia.Media.ITransform> func, Action<Avalonia.Media.ITransform>? onChanged = null) where T : Avalonia.Controls.LayoutTransformControl 
   => control._set(func, Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T LayoutTransform<T>(this T control, ISignal<Avalonia.Media.ITransform> signal, Action<Avalonia.Media.ITransform>? onChanged = null) where T : Avalonia.Controls.LayoutTransformControl 
   => control._set(signal, Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty!, onChanged);


 // UseRenderTransform

/*ValueSetterGenerator*/
public static T UseRenderTransform<T>(this T control, System.Boolean value) where T : Avalonia.Controls.LayoutTransformControl 
=> control._set(() => control.UseRenderTransform = value!);

/*BindFromFuncSetterGenerator*/
public static T UseRenderTransform<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.LayoutTransformControl 
   => control._set(func, Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T UseRenderTransform<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.LayoutTransformControl 
   => control._set(signal, Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty!, onChanged);



//================= Styles ======================//
 // LayoutTransform

/*ValueStyleSetterGenerator*/
public static Style<T> LayoutTransform<T>(this Style<T> style, Avalonia.Media.ITransform value) where T : Avalonia.Controls.LayoutTransformControl 
=> style._addSetter(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LayoutTransform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.LayoutTransformControl 
=> style._addSetter(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty, binding);


 // UseRenderTransform

/*ValueStyleSetterGenerator*/
public static Style<T> UseRenderTransform<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.LayoutTransformControl 
=> style._addSetter(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseRenderTransform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.LayoutTransformControl 
=> style._addSetter(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty, binding);



}
