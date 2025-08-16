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
public static partial class DrawingImage_MarkupExtensions
{
//================= Properties ======================//
 // Drawing

/*ValueSetterGenerator*/
public static T Drawing<T>(this T control, Avalonia.Media.Drawing value) where T : Avalonia.Media.DrawingImage 
=> control._set(() => control.Drawing = value!);

/*BindFromFuncSetterGenerator*/
public static T Drawing<T>(this T control, Func<Avalonia.Media.Drawing> func, Action<Avalonia.Media.Drawing>? onChanged = null) where T : Avalonia.Media.DrawingImage 
   => control._set(func, Avalonia.Media.DrawingImage.DrawingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Drawing<T>(this T control, ISignal<Avalonia.Media.Drawing> signal, Action<Avalonia.Media.Drawing>? onChanged = null) where T : Avalonia.Media.DrawingImage 
   => control._set(signal, Avalonia.Media.DrawingImage.DrawingProperty!, onChanged);



//================= Events ======================//
 // Invalidated

/*ActionToEventGenerator*/
public static T OnInvalidated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Media.DrawingImage  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Invalidated += h);



}
