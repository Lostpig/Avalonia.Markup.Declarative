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
public static partial class Canvas_MarkupExtensions
{
//================= Attached Properties ======================//
 // Left

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T Canvas_Left<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.Canvas.LeftProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T Canvas_Left<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.Canvas.LeftProperty!, onChanged);


 // Top

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T Canvas_Top<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.Canvas.TopProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T Canvas_Top<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.Canvas.TopProperty!, onChanged);


 // Right

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T Canvas_Right<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.Canvas.RightProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T Canvas_Right<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.Canvas.RightProperty!, onChanged);


 // Bottom

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T Canvas_Bottom<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.Canvas.BottomProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T Canvas_Bottom<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.Canvas.BottomProperty!, onChanged);



}
