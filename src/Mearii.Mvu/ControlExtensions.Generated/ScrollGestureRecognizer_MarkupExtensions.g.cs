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
public static partial class ScrollGestureRecognizer_MarkupExtensions
{
//================= Properties ======================//
 // CanHorizontallyScroll

/*ValueSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, System.Boolean value) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
=> control._set(() => control.CanHorizontallyScroll = value!);

/*BindFromFuncSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(func, Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanHorizontallyScrollProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(signal, Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanHorizontallyScrollProperty!, onChanged);


 // CanVerticallyScroll

/*ValueSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, System.Boolean value) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
=> control._set(() => control.CanVerticallyScroll = value!);

/*BindFromFuncSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(func, Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanVerticallyScrollProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(signal, Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanVerticallyScrollProperty!, onChanged);


 // IsScrollInertiaEnabled

/*ValueSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
=> control._set(() => control.IsScrollInertiaEnabled = value!);

/*BindFromFuncSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(func, Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.IsScrollInertiaEnabledProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(signal, Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.IsScrollInertiaEnabledProperty!, onChanged);


 // ScrollStartDistance

/*ValueSetterGenerator*/
public static T ScrollStartDistance<T>(this T control, System.Int32 value) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
=> control._set(() => control.ScrollStartDistance = value!);

/*BindFromFuncSetterGenerator*/
public static T ScrollStartDistance<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(func, Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.ScrollStartDistanceProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ScrollStartDistance<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(signal, Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.ScrollStartDistanceProperty!, onChanged);



}
