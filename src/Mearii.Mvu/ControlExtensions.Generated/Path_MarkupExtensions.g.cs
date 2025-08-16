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
public static partial class Path_MarkupExtensions
{
//================= Properties ======================//
 // Data

/*ValueSetterGenerator*/
public static T Data<T>(this T control, Avalonia.Media.Geometry value) where T : Avalonia.Controls.Shapes.Path 
=> control._set(() => control.Data = value!);

/*BindFromFuncSetterGenerator*/
public static T Data<T>(this T control, Func<Avalonia.Media.Geometry> func, Action<Avalonia.Media.Geometry>? onChanged = null) where T : Avalonia.Controls.Shapes.Path 
   => control._set(func, Avalonia.Controls.Shapes.Path.DataProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Data<T>(this T control, ISignal<Avalonia.Media.Geometry> signal, Action<Avalonia.Media.Geometry>? onChanged = null) where T : Avalonia.Controls.Shapes.Path 
   => control._set(signal, Avalonia.Controls.Shapes.Path.DataProperty!, onChanged);



//================= Styles ======================//
 // Data

/*ValueStyleSetterGenerator*/
public static Style<T> Data<T>(this Style<T> style, Avalonia.Media.Geometry value) where T : Avalonia.Controls.Shapes.Path 
=> style._addSetter(Avalonia.Controls.Shapes.Path.DataProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Data<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Path 
=> style._addSetter(Avalonia.Controls.Shapes.Path.DataProperty, binding);



}
