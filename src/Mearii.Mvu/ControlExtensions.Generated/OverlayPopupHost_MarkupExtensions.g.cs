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
public static partial class OverlayPopupHost_MarkupExtensions
{
//================= Properties ======================//
 // Transform

/*ValueSetterGenerator*/
public static T Transform<T>(this T control, Avalonia.Media.Transform value) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
=> control._set(() => control.Transform = value!);

/*BindFromFuncSetterGenerator*/
public static T Transform<T>(this T control, Func<Avalonia.Media.Transform> func, Action<Avalonia.Media.Transform>? onChanged = null) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
   => control._set(func, Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Transform<T>(this T control, ISignal<Avalonia.Media.Transform> signal, Action<Avalonia.Media.Transform>? onChanged = null) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
   => control._set(signal, Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty!, onChanged);



//================= Styles ======================//
 // Transform

/*ValueStyleSetterGenerator*/
public static Style<T> Transform<T>(this Style<T> style, Avalonia.Media.Transform value) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
=> style._addSetter(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Transform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
=> style._addSetter(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty, binding);



}
