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
public static partial class AdornerLayer_MarkupExtensions
{
//================= Properties ======================//
 // DefaultFocusAdorner

/*ValueSetterGenerator*/
public static T DefaultFocusAdorner<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.Primitives.AdornerLayer 
=> control._set(() => control.DefaultFocusAdorner = value!);

/*BindFromFuncSetterGenerator*/
public static T DefaultFocusAdorner<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>? onChanged = null) where T : Avalonia.Controls.Primitives.AdornerLayer 
   => control._set(func, Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T DefaultFocusAdorner<T>(this T control, ISignal<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> signal, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>? onChanged = null) where T : Avalonia.Controls.Primitives.AdornerLayer 
   => control._set(signal, Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty!, onChanged);



//================= Attached Properties ======================//
 // AdornedElement

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T AdornerLayer_AdornedElement<T>(this T control, Func<Avalonia.Visual> func, Action<Avalonia.Visual>? onChanged = null) where T : Avalonia.Visual 
   => control._set(func, Avalonia.Controls.Primitives.AdornerLayer.AdornedElementProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T AdornerLayer_AdornedElement<T>(this T control, ISignal<Avalonia.Visual> signal, Action<Avalonia.Visual>? onChanged = null) where T : Avalonia.Visual 
   => control._set(signal, Avalonia.Controls.Primitives.AdornerLayer.AdornedElementProperty!, onChanged);


 // IsClipEnabled

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T AdornerLayer_IsClipEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Visual 
   => control._set(func, Avalonia.Controls.Primitives.AdornerLayer.IsClipEnabledProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T AdornerLayer_IsClipEnabled<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Visual 
   => control._set(signal, Avalonia.Controls.Primitives.AdornerLayer.IsClipEnabledProperty!, onChanged);


 // Adorner

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T AdornerLayer_Adorner<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null) where T : Avalonia.Visual 
   => control._set(func, Avalonia.Controls.Primitives.AdornerLayer.AdornerProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T AdornerLayer_Adorner<T>(this T control, ISignal<Avalonia.Controls.Control> signal, Action<Avalonia.Controls.Control>? onChanged = null) where T : Avalonia.Visual 
   => control._set(signal, Avalonia.Controls.Primitives.AdornerLayer.AdornerProperty!, onChanged);



//================= Styles ======================//
 // DefaultFocusAdorner

/*ValueStyleSetterGenerator*/
public static Style<T> DefaultFocusAdorner<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.Primitives.AdornerLayer 
=> style._addSetter(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DefaultFocusAdorner<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.AdornerLayer 
=> style._addSetter(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty, binding);



}
