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
public static partial class Image_MarkupExtensions
{
//================= Properties ======================//
 // Source

/*ValueSetterGenerator*/
public static T Source<T>(this T control, Avalonia.Media.IImage value) where T : Avalonia.Controls.Image 
=> control._set(() => control.Source = value!);

/*BindFromFuncSetterGenerator*/
public static T Source<T>(this T control, Func<Avalonia.Media.IImage> func, Action<Avalonia.Media.IImage>? onChanged = null) where T : Avalonia.Controls.Image 
   => control._set(func, Avalonia.Controls.Image.SourceProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Source<T>(this T control, ISignal<Avalonia.Media.IImage> signal, Action<Avalonia.Media.IImage>? onChanged = null) where T : Avalonia.Controls.Image 
   => control._set(signal, Avalonia.Controls.Image.SourceProperty!, onChanged);


 // BlendMode

/*ValueSetterGenerator*/
public static T BlendMode<T>(this T control, Avalonia.Media.Imaging.BitmapBlendingMode value) where T : Avalonia.Controls.Image 
=> control._set(() => control.BlendMode = value!);

/*BindFromFuncSetterGenerator*/
public static T BlendMode<T>(this T control, Func<Avalonia.Media.Imaging.BitmapBlendingMode> func, Action<Avalonia.Media.Imaging.BitmapBlendingMode>? onChanged = null) where T : Avalonia.Controls.Image 
   => control._set(func, Avalonia.Controls.Image.BlendModeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T BlendMode<T>(this T control, ISignal<Avalonia.Media.Imaging.BitmapBlendingMode> signal, Action<Avalonia.Media.Imaging.BitmapBlendingMode>? onChanged = null) where T : Avalonia.Controls.Image 
   => control._set(signal, Avalonia.Controls.Image.BlendModeProperty!, onChanged);


 // Stretch

/*ValueSetterGenerator*/
public static T Stretch<T>(this T control, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Image 
=> control._set(() => control.Stretch = value!);

/*BindFromFuncSetterGenerator*/
public static T Stretch<T>(this T control, Func<Avalonia.Media.Stretch> func, Action<Avalonia.Media.Stretch>? onChanged = null) where T : Avalonia.Controls.Image 
   => control._set(func, Avalonia.Controls.Image.StretchProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Stretch<T>(this T control, ISignal<Avalonia.Media.Stretch> signal, Action<Avalonia.Media.Stretch>? onChanged = null) where T : Avalonia.Controls.Image 
   => control._set(signal, Avalonia.Controls.Image.StretchProperty!, onChanged);


 // StretchDirection

/*ValueSetterGenerator*/
public static T StretchDirection<T>(this T control, Avalonia.Media.StretchDirection value) where T : Avalonia.Controls.Image 
=> control._set(() => control.StretchDirection = value!);

/*BindFromFuncSetterGenerator*/
public static T StretchDirection<T>(this T control, Func<Avalonia.Media.StretchDirection> func, Action<Avalonia.Media.StretchDirection>? onChanged = null) where T : Avalonia.Controls.Image 
   => control._set(func, Avalonia.Controls.Image.StretchDirectionProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T StretchDirection<T>(this T control, ISignal<Avalonia.Media.StretchDirection> signal, Action<Avalonia.Media.StretchDirection>? onChanged = null) where T : Avalonia.Controls.Image 
   => control._set(signal, Avalonia.Controls.Image.StretchDirectionProperty!, onChanged);



//================= Styles ======================//
 // Source

/*ValueStyleSetterGenerator*/
public static Style<T> Source<T>(this Style<T> style, Avalonia.Media.IImage value) where T : Avalonia.Controls.Image 
=> style._addSetter(Avalonia.Controls.Image.SourceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Source<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Image 
=> style._addSetter(Avalonia.Controls.Image.SourceProperty, binding);


 // BlendMode

/*ValueStyleSetterGenerator*/
public static Style<T> BlendMode<T>(this Style<T> style, Avalonia.Media.Imaging.BitmapBlendingMode value) where T : Avalonia.Controls.Image 
=> style._addSetter(Avalonia.Controls.Image.BlendModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BlendMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Image 
=> style._addSetter(Avalonia.Controls.Image.BlendModeProperty, binding);


 // Stretch

/*ValueStyleSetterGenerator*/
public static Style<T> Stretch<T>(this Style<T> style, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Image 
=> style._addSetter(Avalonia.Controls.Image.StretchProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Stretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Image 
=> style._addSetter(Avalonia.Controls.Image.StretchProperty, binding);


 // StretchDirection

/*ValueStyleSetterGenerator*/
public static Style<T> StretchDirection<T>(this Style<T> style, Avalonia.Media.StretchDirection value) where T : Avalonia.Controls.Image 
=> style._addSetter(Avalonia.Controls.Image.StretchDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StretchDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Image 
=> style._addSetter(Avalonia.Controls.Image.StretchDirectionProperty, binding);



}
