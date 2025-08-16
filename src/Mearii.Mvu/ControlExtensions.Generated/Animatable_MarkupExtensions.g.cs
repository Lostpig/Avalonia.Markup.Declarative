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
public static partial class Animatable_MarkupExtensions
{
//================= Properties ======================//
 // Transitions

/*ValueSetterGenerator*/
public static T Transitions<T>(this T control, Avalonia.Animation.Transitions value) where T : Avalonia.Animation.Animatable 
=> control._set(() => control.Transitions = value!);

/*BindFromFuncSetterGenerator*/
public static T Transitions<T>(this T control, Func<Avalonia.Animation.Transitions> func, Action<Avalonia.Animation.Transitions>? onChanged = null) where T : Avalonia.Animation.Animatable 
   => control._set(func, Avalonia.Animation.Animatable.TransitionsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Transitions<T>(this T control, ISignal<Avalonia.Animation.Transitions> signal, Action<Avalonia.Animation.Transitions>? onChanged = null) where T : Avalonia.Animation.Animatable 
   => control._set(signal, Avalonia.Animation.Animatable.TransitionsProperty!, onChanged);



}
