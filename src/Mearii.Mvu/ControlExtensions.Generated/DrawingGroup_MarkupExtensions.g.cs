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
public static partial class DrawingGroup_MarkupExtensions
{
//================= Properties ======================//
 // Opacity

/*ValueSetterGenerator*/
public static Avalonia.Media.DrawingGroup Opacity(this Avalonia.Media.DrawingGroup control, System.Double value)  
=> control._set(() => control.Opacity = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.DrawingGroup Opacity(this Avalonia.Media.DrawingGroup control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.DrawingGroup.OpacityProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.DrawingGroup Opacity(this Avalonia.Media.DrawingGroup control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.DrawingGroup.OpacityProperty!, onChanged);


 // Transform

/*ValueSetterGenerator*/
public static Avalonia.Media.DrawingGroup Transform(this Avalonia.Media.DrawingGroup control, Avalonia.Media.Transform value)  
=> control._set(() => control.Transform = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.DrawingGroup Transform(this Avalonia.Media.DrawingGroup control, Func<Avalonia.Media.Transform> func, Action<Avalonia.Media.Transform>? onChanged = null)  
   => control._set(func, Avalonia.Media.DrawingGroup.TransformProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.DrawingGroup Transform(this Avalonia.Media.DrawingGroup control, ISignal<Avalonia.Media.Transform> signal, Action<Avalonia.Media.Transform>? onChanged = null)  
   => control._set(signal, Avalonia.Media.DrawingGroup.TransformProperty!, onChanged);


 // ClipGeometry

/*ValueSetterGenerator*/
public static Avalonia.Media.DrawingGroup ClipGeometry(this Avalonia.Media.DrawingGroup control, Avalonia.Media.Geometry value)  
=> control._set(() => control.ClipGeometry = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.DrawingGroup ClipGeometry(this Avalonia.Media.DrawingGroup control, Func<Avalonia.Media.Geometry> func, Action<Avalonia.Media.Geometry>? onChanged = null)  
   => control._set(func, Avalonia.Media.DrawingGroup.ClipGeometryProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.DrawingGroup ClipGeometry(this Avalonia.Media.DrawingGroup control, ISignal<Avalonia.Media.Geometry> signal, Action<Avalonia.Media.Geometry>? onChanged = null)  
   => control._set(signal, Avalonia.Media.DrawingGroup.ClipGeometryProperty!, onChanged);


 // OpacityMask

/*ValueSetterGenerator*/
public static Avalonia.Media.DrawingGroup OpacityMask(this Avalonia.Media.DrawingGroup control, Avalonia.Media.IBrush value)  
=> control._set(() => control.OpacityMask = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.DrawingGroup OpacityMask(this Avalonia.Media.DrawingGroup control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null)  
   => control._set(func, Avalonia.Media.DrawingGroup.OpacityMaskProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.DrawingGroup OpacityMask(this Avalonia.Media.DrawingGroup control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null)  
   => control._set(signal, Avalonia.Media.DrawingGroup.OpacityMaskProperty!, onChanged);


 // Children

/*ValueSetterGenerator*/
public static Avalonia.Media.DrawingGroup Children(this Avalonia.Media.DrawingGroup control, Avalonia.Media.DrawingCollection value)  
=> control._set(() => control.Children = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.DrawingGroup Children(this Avalonia.Media.DrawingGroup control, Func<Avalonia.Media.DrawingCollection> func, Action<Avalonia.Media.DrawingCollection>? onChanged = null)  
   => control._set(func, Avalonia.Media.DrawingGroup.ChildrenProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.DrawingGroup Children(this Avalonia.Media.DrawingGroup control, ISignal<Avalonia.Media.DrawingCollection> signal, Action<Avalonia.Media.DrawingCollection>? onChanged = null)  
   => control._set(signal, Avalonia.Media.DrawingGroup.ChildrenProperty!, onChanged);



}
