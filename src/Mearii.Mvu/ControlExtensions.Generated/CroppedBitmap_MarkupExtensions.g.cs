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
public static partial class CroppedBitmap_MarkupExtensions
{
//================= Properties ======================//
 // Source

/*ValueSetterGenerator*/
public static T Source<T>(this T control, Avalonia.Media.IImage value) where T : Avalonia.Media.Imaging.CroppedBitmap 
=> control._set(() => control.Source = value!);

/*BindFromFuncSetterGenerator*/
public static T Source<T>(this T control, Func<Avalonia.Media.IImage> func, Action<Avalonia.Media.IImage>? onChanged = null) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(func, Avalonia.Media.Imaging.CroppedBitmap.SourceProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Source<T>(this T control, ISignal<Avalonia.Media.IImage> signal, Action<Avalonia.Media.IImage>? onChanged = null) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(signal, Avalonia.Media.Imaging.CroppedBitmap.SourceProperty!, onChanged);


 // SourceRect

/*ValueSetterGenerator*/
public static T SourceRect<T>(this T control, Avalonia.PixelRect value) where T : Avalonia.Media.Imaging.CroppedBitmap 
=> control._set(() => control.SourceRect = value!);

/*BindFromFuncSetterGenerator*/
public static T SourceRect<T>(this T control, Func<Avalonia.PixelRect> func, Action<Avalonia.PixelRect>? onChanged = null) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(func, Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SourceRect<T>(this T control, ISignal<Avalonia.PixelRect> signal, Action<Avalonia.PixelRect>? onChanged = null) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(signal, Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T SourceRect<T>(this T control, System.Int32 x = default!, System.Int32 y = default!, System.Int32 width = default!, System.Int32 height = default!) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(() => control.SourceRect = new Avalonia.PixelRect(x, y, width, height));
public static T SourceRect<T>(this T control, Avalonia.PixelSize size = default!) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(() => control.SourceRect = new Avalonia.PixelRect(size));
public static T SourceRect<T>(this T control, Avalonia.PixelPoint position = default!, Avalonia.PixelSize size = default!) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(() => control.SourceRect = new Avalonia.PixelRect(position, size));
public static T SourceRect<T>(this T control, Avalonia.PixelPoint topLeft = default!, Avalonia.PixelPoint bottomRight = default!) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(() => control.SourceRect = new Avalonia.PixelRect(topLeft, bottomRight));



//================= Events ======================//
 // Invalidated

/*ActionToEventGenerator*/
public static T OnInvalidated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Media.Imaging.CroppedBitmap  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Invalidated += h);



}
