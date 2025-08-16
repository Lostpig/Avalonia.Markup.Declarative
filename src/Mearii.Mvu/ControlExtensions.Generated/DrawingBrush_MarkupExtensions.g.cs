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
public static partial class DrawingBrush_MarkupExtensions
{
//================= Properties ======================//
 // Drawing

/*ValueSetterGenerator*/
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control, Avalonia.Media.Drawing value)  
=> control._set(() => control.Drawing = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control, Func<Avalonia.Media.Drawing> func, Action<Avalonia.Media.Drawing>? onChanged = null)  
   => control._set(func, Avalonia.Media.DrawingBrush.DrawingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control, ISignal<Avalonia.Media.Drawing> signal, Action<Avalonia.Media.Drawing>? onChanged = null)  
   => control._set(signal, Avalonia.Media.DrawingBrush.DrawingProperty!, onChanged);



}
