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
public static partial class PullGestureRecognizer_MarkupExtensions
{
//================= Properties ======================//
 // PullDirection

/*ValueSetterGenerator*/
public static T PullDirection<T>(this T control, Avalonia.Input.PullDirection value) where T : Avalonia.Input.PullGestureRecognizer 
=> control._set(() => control.PullDirection = value!);

/*BindFromFuncSetterGenerator*/
public static T PullDirection<T>(this T control, Func<Avalonia.Input.PullDirection> func, Action<Avalonia.Input.PullDirection>? onChanged = null) where T : Avalonia.Input.PullGestureRecognizer 
   => control._set(func, Avalonia.Input.PullGestureRecognizer.PullDirectionProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T PullDirection<T>(this T control, ISignal<Avalonia.Input.PullDirection> signal, Action<Avalonia.Input.PullDirection>? onChanged = null) where T : Avalonia.Input.PullGestureRecognizer 
   => control._set(signal, Avalonia.Input.PullGestureRecognizer.PullDirectionProperty!, onChanged);



//================= Styles ======================//
 // PullDirection

/*ValueStyleSetterGenerator*/
public static Style<T> PullDirection<T>(this Style<T> style, Avalonia.Input.PullDirection value) where T : Avalonia.Input.PullGestureRecognizer 
=> style._addSetter(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PullDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.PullGestureRecognizer 
=> style._addSetter(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, binding);



}
