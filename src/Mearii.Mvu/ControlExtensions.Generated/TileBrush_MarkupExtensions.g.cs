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
public static partial class TileBrush_MarkupExtensions
{
//================= Properties ======================//
 // AlignmentX

/*ValueSetterGenerator*/
public static T AlignmentX<T>(this T control, Avalonia.Media.AlignmentX value) where T : Avalonia.Media.TileBrush 
=> control._set(() => control.AlignmentX = value!);

/*BindFromFuncSetterGenerator*/
public static T AlignmentX<T>(this T control, Func<Avalonia.Media.AlignmentX> func, Action<Avalonia.Media.AlignmentX>? onChanged = null) where T : Avalonia.Media.TileBrush 
   => control._set(func, Avalonia.Media.TileBrush.AlignmentXProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T AlignmentX<T>(this T control, ISignal<Avalonia.Media.AlignmentX> signal, Action<Avalonia.Media.AlignmentX>? onChanged = null) where T : Avalonia.Media.TileBrush 
   => control._set(signal, Avalonia.Media.TileBrush.AlignmentXProperty!, onChanged);


 // AlignmentY

/*ValueSetterGenerator*/
public static T AlignmentY<T>(this T control, Avalonia.Media.AlignmentY value) where T : Avalonia.Media.TileBrush 
=> control._set(() => control.AlignmentY = value!);

/*BindFromFuncSetterGenerator*/
public static T AlignmentY<T>(this T control, Func<Avalonia.Media.AlignmentY> func, Action<Avalonia.Media.AlignmentY>? onChanged = null) where T : Avalonia.Media.TileBrush 
   => control._set(func, Avalonia.Media.TileBrush.AlignmentYProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T AlignmentY<T>(this T control, ISignal<Avalonia.Media.AlignmentY> signal, Action<Avalonia.Media.AlignmentY>? onChanged = null) where T : Avalonia.Media.TileBrush 
   => control._set(signal, Avalonia.Media.TileBrush.AlignmentYProperty!, onChanged);


 // DestinationRect

/*ValueSetterGenerator*/
public static T DestinationRect<T>(this T control, Avalonia.RelativeRect value) where T : Avalonia.Media.TileBrush 
=> control._set(() => control.DestinationRect = value!);

/*BindFromFuncSetterGenerator*/
public static T DestinationRect<T>(this T control, Func<Avalonia.RelativeRect> func, Action<Avalonia.RelativeRect>? onChanged = null) where T : Avalonia.Media.TileBrush 
   => control._set(func, Avalonia.Media.TileBrush.DestinationRectProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T DestinationRect<T>(this T control, ISignal<Avalonia.RelativeRect> signal, Action<Avalonia.RelativeRect>? onChanged = null) where T : Avalonia.Media.TileBrush 
   => control._set(signal, Avalonia.Media.TileBrush.DestinationRectProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T DestinationRect<T>(this T control, System.Double x = default!, System.Double y = default!, System.Double width = default!, System.Double height = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.DestinationRect = new Avalonia.RelativeRect(x, y, width, height, unit));
public static T DestinationRect<T>(this T control, Avalonia.Rect rect = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.DestinationRect = new Avalonia.RelativeRect(rect, unit));
public static T DestinationRect<T>(this T control, Avalonia.Size size = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.DestinationRect = new Avalonia.RelativeRect(size, unit));
public static T DestinationRect<T>(this T control, Avalonia.Point position = default!, Avalonia.Size size = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.DestinationRect = new Avalonia.RelativeRect(position, size, unit));
public static T DestinationRect<T>(this T control, Avalonia.Point topLeft = default!, Avalonia.Point bottomRight = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.DestinationRect = new Avalonia.RelativeRect(topLeft, bottomRight, unit));


 // SourceRect

/*ValueSetterGenerator*/
public static T SourceRect<T>(this T control, Avalonia.RelativeRect value) where T : Avalonia.Media.TileBrush 
=> control._set(() => control.SourceRect = value!);

/*BindFromFuncSetterGenerator*/
public static T SourceRect<T>(this T control, Func<Avalonia.RelativeRect> func, Action<Avalonia.RelativeRect>? onChanged = null) where T : Avalonia.Media.TileBrush 
   => control._set(func, Avalonia.Media.TileBrush.SourceRectProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SourceRect<T>(this T control, ISignal<Avalonia.RelativeRect> signal, Action<Avalonia.RelativeRect>? onChanged = null) where T : Avalonia.Media.TileBrush 
   => control._set(signal, Avalonia.Media.TileBrush.SourceRectProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T SourceRect<T>(this T control, System.Double x = default!, System.Double y = default!, System.Double width = default!, System.Double height = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.SourceRect = new Avalonia.RelativeRect(x, y, width, height, unit));
public static T SourceRect<T>(this T control, Avalonia.Rect rect = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.SourceRect = new Avalonia.RelativeRect(rect, unit));
public static T SourceRect<T>(this T control, Avalonia.Size size = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.SourceRect = new Avalonia.RelativeRect(size, unit));
public static T SourceRect<T>(this T control, Avalonia.Point position = default!, Avalonia.Size size = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.SourceRect = new Avalonia.RelativeRect(position, size, unit));
public static T SourceRect<T>(this T control, Avalonia.Point topLeft = default!, Avalonia.Point bottomRight = default!, Avalonia.RelativeUnit unit = default!) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.SourceRect = new Avalonia.RelativeRect(topLeft, bottomRight, unit));


 // Stretch

/*ValueSetterGenerator*/
public static T Stretch<T>(this T control, Avalonia.Media.Stretch value) where T : Avalonia.Media.TileBrush 
=> control._set(() => control.Stretch = value!);

/*BindFromFuncSetterGenerator*/
public static T Stretch<T>(this T control, Func<Avalonia.Media.Stretch> func, Action<Avalonia.Media.Stretch>? onChanged = null) where T : Avalonia.Media.TileBrush 
   => control._set(func, Avalonia.Media.TileBrush.StretchProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Stretch<T>(this T control, ISignal<Avalonia.Media.Stretch> signal, Action<Avalonia.Media.Stretch>? onChanged = null) where T : Avalonia.Media.TileBrush 
   => control._set(signal, Avalonia.Media.TileBrush.StretchProperty!, onChanged);


 // TileMode

/*ValueSetterGenerator*/
public static T TileMode<T>(this T control, Avalonia.Media.TileMode value) where T : Avalonia.Media.TileBrush 
=> control._set(() => control.TileMode = value!);

/*BindFromFuncSetterGenerator*/
public static T TileMode<T>(this T control, Func<Avalonia.Media.TileMode> func, Action<Avalonia.Media.TileMode>? onChanged = null) where T : Avalonia.Media.TileBrush 
   => control._set(func, Avalonia.Media.TileBrush.TileModeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TileMode<T>(this T control, ISignal<Avalonia.Media.TileMode> signal, Action<Avalonia.Media.TileMode>? onChanged = null) where T : Avalonia.Media.TileBrush 
   => control._set(signal, Avalonia.Media.TileBrush.TileModeProperty!, onChanged);



}
