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
public static partial class ImageDrawing_MarkupExtensions
{
//================= Properties ======================//
 // ImageSource

/*ValueSetterGenerator*/
public static Avalonia.Media.ImageDrawing ImageSource(this Avalonia.Media.ImageDrawing control, Avalonia.Media.IImage value)  
=> control._set(() => control.ImageSource = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.ImageDrawing ImageSource(this Avalonia.Media.ImageDrawing control, Func<Avalonia.Media.IImage> func, Action<Avalonia.Media.IImage>? onChanged = null)  
   => control._set(func, Avalonia.Media.ImageDrawing.ImageSourceProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.ImageDrawing ImageSource(this Avalonia.Media.ImageDrawing control, ISignal<Avalonia.Media.IImage> signal, Action<Avalonia.Media.IImage>? onChanged = null)  
   => control._set(signal, Avalonia.Media.ImageDrawing.ImageSourceProperty!, onChanged);


 // Rect

/*ValueSetterGenerator*/
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Avalonia.Rect value)  
=> control._set(() => control.Rect = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Func<Avalonia.Rect> func, Action<Avalonia.Rect>? onChanged = null)  
   => control._set(func, Avalonia.Media.ImageDrawing.RectProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, ISignal<Avalonia.Rect> signal, Action<Avalonia.Rect>? onChanged = null)  
   => control._set(signal, Avalonia.Media.ImageDrawing.RectProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, System.Double x = default!, System.Double y = default!, System.Double width = default!, System.Double height = default!)  
   => control._set(() => control.Rect = new Avalonia.Rect(x, y, width, height));
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Avalonia.Size size = default!)  
   => control._set(() => control.Rect = new Avalonia.Rect(size));
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Avalonia.Point position = default!, Avalonia.Size size = default!)  
   => control._set(() => control.Rect = new Avalonia.Rect(position, size));
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Avalonia.Point topLeft = default!, Avalonia.Point bottomRight = default!)  
   => control._set(() => control.Rect = new Avalonia.Rect(topLeft, bottomRight));



}
