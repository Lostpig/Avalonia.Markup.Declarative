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
public static partial class Panel_MarkupExtensions
{
//================= Properties ======================//
 // Background

/*ValueSetterGenerator*/
public static T Background<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Panel 
=> control._set(() => control.Background = value!);

/*BindFromFuncSetterGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Panel 
   => control._set(func, Avalonia.Controls.Panel.BackgroundProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Background<T>(this T control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null) where T : Avalonia.Controls.Panel 
   => control._set(signal, Avalonia.Controls.Panel.BackgroundProperty!, onChanged);



//================= Styles ======================//
 // Background

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Panel 
=> style._addSetter(Avalonia.Controls.Panel.BackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Panel 
=> style._addSetter(Avalonia.Controls.Panel.BackgroundProperty, binding);



}
