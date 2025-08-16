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
public static partial class Carousel_MarkupExtensions
{
//================= Properties ======================//
 // PageTransition

/*ValueSetterGenerator*/
public static T PageTransition<T>(this T control, Avalonia.Animation.IPageTransition value) where T : Avalonia.Controls.Carousel 
=> control._set(() => control.PageTransition = value!);

/*BindFromFuncSetterGenerator*/
public static T PageTransition<T>(this T control, Func<Avalonia.Animation.IPageTransition> func, Action<Avalonia.Animation.IPageTransition>? onChanged = null) where T : Avalonia.Controls.Carousel 
   => control._set(func, Avalonia.Controls.Carousel.PageTransitionProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PageTransition<T>(this T control, ISignal<Avalonia.Animation.IPageTransition> signal, Action<Avalonia.Animation.IPageTransition>? onChanged = null) where T : Avalonia.Controls.Carousel 
   => control._set(signal, Avalonia.Controls.Carousel.PageTransitionProperty!, onChanged);



//================= Styles ======================//
 // PageTransition

/*ValueStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, Avalonia.Animation.IPageTransition value) where T : Avalonia.Controls.Carousel 
=> style._addSetter(Avalonia.Controls.Carousel.PageTransitionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Carousel 
=> style._addSetter(Avalonia.Controls.Carousel.PageTransitionProperty, binding);



}
