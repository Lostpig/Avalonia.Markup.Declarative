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
public static partial class GlyphRunDrawing_MarkupExtensions
{
//================= Properties ======================//
 // Foreground

/*ValueSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, Avalonia.Media.IBrush value)  
=> control._set(() => control.Foreground = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null)  
   => control._set(func, Avalonia.Media.GlyphRunDrawing.ForegroundProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null)  
   => control._set(signal, Avalonia.Media.GlyphRunDrawing.ForegroundProperty!, onChanged);


 // GlyphRun

/*ValueSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, Avalonia.Media.GlyphRun value)  
=> control._set(() => control.GlyphRun = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, Func<Avalonia.Media.GlyphRun> func, Action<Avalonia.Media.GlyphRun>? onChanged = null)  
   => control._set(func, Avalonia.Media.GlyphRunDrawing.GlyphRunProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, ISignal<Avalonia.Media.GlyphRun> signal, Action<Avalonia.Media.GlyphRun>? onChanged = null)  
   => control._set(signal, Avalonia.Media.GlyphRunDrawing.GlyphRunProperty!, onChanged);



}
