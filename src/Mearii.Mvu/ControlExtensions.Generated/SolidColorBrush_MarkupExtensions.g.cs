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
public static partial class SolidColorBrush_MarkupExtensions
{
//================= Properties ======================//
 // Color

/*ValueSetterGenerator*/
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, Avalonia.Media.Color value)  
=> control._set(() => control.Color = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, Func<Avalonia.Media.Color> func, Action<Avalonia.Media.Color>? onChanged = null)  
   => control._set(func, Avalonia.Media.SolidColorBrush.ColorProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, ISignal<Avalonia.Media.Color> signal, Action<Avalonia.Media.Color>? onChanged = null)  
   => control._set(signal, Avalonia.Media.SolidColorBrush.ColorProperty!, onChanged);



}
