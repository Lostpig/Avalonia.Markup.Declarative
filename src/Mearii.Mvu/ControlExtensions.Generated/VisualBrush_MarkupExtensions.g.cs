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
public static partial class VisualBrush_MarkupExtensions
{
//================= Properties ======================//
 // Visual

/*ValueSetterGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, Avalonia.Visual value)  
=> control._set(() => control.Visual = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, Func<Avalonia.Visual> func, Action<Avalonia.Visual>? onChanged = null)  
   => control._set(func, Avalonia.Media.VisualBrush.VisualProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, ISignal<Avalonia.Visual> signal, Action<Avalonia.Visual>? onChanged = null)  
   => control._set(signal, Avalonia.Media.VisualBrush.VisualProperty!, onChanged);



}
