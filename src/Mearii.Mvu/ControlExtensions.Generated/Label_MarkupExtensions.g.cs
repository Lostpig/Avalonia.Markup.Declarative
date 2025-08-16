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
public static partial class Label_MarkupExtensions
{
//================= Properties ======================//
 // Target

/*ValueSetterGenerator*/
public static T Target<T>(this T control, Avalonia.Input.IInputElement value) where T : Avalonia.Controls.Label 
=> control._set(() => control.Target = value!);

/*BindFromFuncSetterGenerator*/
public static T Target<T>(this T control, Func<Avalonia.Input.IInputElement> func, Action<Avalonia.Input.IInputElement>? onChanged = null) where T : Avalonia.Controls.Label 
   => control._set(func, Avalonia.Controls.Label.TargetProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Target<T>(this T control, ISignal<Avalonia.Input.IInputElement> signal, Action<Avalonia.Input.IInputElement>? onChanged = null) where T : Avalonia.Controls.Label 
   => control._set(signal, Avalonia.Controls.Label.TargetProperty!, onChanged);



//================= Styles ======================//
 // Target

/*ValueStyleSetterGenerator*/
public static Style<T> Target<T>(this Style<T> style, Avalonia.Input.IInputElement value) where T : Avalonia.Controls.Label 
=> style._addSetter(Avalonia.Controls.Label.TargetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Target<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Label 
=> style._addSetter(Avalonia.Controls.Label.TargetProperty, binding);



}
