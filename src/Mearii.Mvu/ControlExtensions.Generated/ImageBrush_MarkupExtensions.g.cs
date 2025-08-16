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
public static partial class ImageBrush_MarkupExtensions
{
//================= Properties ======================//
 // Source

/*ValueSetterGenerator*/
public static Avalonia.Media.ImageBrush Source(this Avalonia.Media.ImageBrush control, Avalonia.Media.IImageBrushSource value)  
=> control._set(() => control.Source = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.ImageBrush Source(this Avalonia.Media.ImageBrush control, Func<Avalonia.Media.IImageBrushSource> func, Action<Avalonia.Media.IImageBrushSource>? onChanged = null)  
   => control._set(func, Avalonia.Media.ImageBrush.SourceProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.ImageBrush Source(this Avalonia.Media.ImageBrush control, ISignal<Avalonia.Media.IImageBrushSource> signal, Action<Avalonia.Media.IImageBrushSource>? onChanged = null)  
   => control._set(signal, Avalonia.Media.ImageBrush.SourceProperty!, onChanged);



}
