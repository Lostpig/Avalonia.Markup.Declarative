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
public static partial class PopupRoot_MarkupExtensions
{
//================= Properties ======================//
 // Transform

/*ValueSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control, Avalonia.Media.Transform value)  
=> control._set(() => control.Transform = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control, Func<Avalonia.Media.Transform> func, Action<Avalonia.Media.Transform>? onChanged = null)  
   => control._set(func, Avalonia.Controls.Primitives.PopupRoot.TransformProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control, ISignal<Avalonia.Media.Transform> signal, Action<Avalonia.Media.Transform>? onChanged = null)  
   => control._set(signal, Avalonia.Controls.Primitives.PopupRoot.TransformProperty!, onChanged);


 // WindowManagerAddShadowHint

/*ValueSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control, System.Boolean value)  
=> control._set(() => control.WindowManagerAddShadowHint = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null)  
   => control._set(func, Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null)  
   => control._set(signal, Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty!, onChanged);



//================= Styles ======================//
 // Transform

/*ValueStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.PopupRoot> Transform(this Style<Avalonia.Controls.Primitives.PopupRoot> style, Avalonia.Media.Transform value)  
=> style._addSetter(Avalonia.Controls.Primitives.PopupRoot.TransformProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.PopupRoot> Transform(this Style<Avalonia.Controls.Primitives.PopupRoot> style, IBinding binding)  
=> style._addSetter(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, binding);


 // WindowManagerAddShadowHint

/*ValueStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.PopupRoot> WindowManagerAddShadowHint(this Style<Avalonia.Controls.Primitives.PopupRoot> style, System.Boolean value)  
=> style._addSetter(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.PopupRoot> WindowManagerAddShadowHint(this Style<Avalonia.Controls.Primitives.PopupRoot> style, IBinding binding)  
=> style._addSetter(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty, binding);



}
