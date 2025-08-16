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
public static partial class MatrixTransform_MarkupExtensions
{
//================= Properties ======================//
 // Matrix

/*ValueSetterGenerator*/
public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, Avalonia.Matrix value)  
=> control._set(() => control.Matrix = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, Func<Avalonia.Matrix> func, Action<Avalonia.Matrix>? onChanged = null)  
   => control._set(func, Avalonia.Media.MatrixTransform.MatrixProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, ISignal<Avalonia.Matrix> signal, Action<Avalonia.Matrix>? onChanged = null)  
   => control._set(signal, Avalonia.Media.MatrixTransform.MatrixProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, System.Double scaleX = default!, System.Double skewY = default!, System.Double skewX = default!, System.Double scaleY = default!, System.Double offsetX = default!, System.Double offsetY = default!)  
   => control._set(() => control.Matrix = new Avalonia.Matrix(scaleX, skewY, skewX, scaleY, offsetX, offsetY));
public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, System.Double scaleX = default!, System.Double skewY = default!, System.Double perspX = default!, System.Double skewX = default!, System.Double scaleY = default!, System.Double perspY = default!, System.Double offsetX = default!, System.Double offsetY = default!, System.Double perspZ = default!)  
   => control._set(() => control.Matrix = new Avalonia.Matrix(scaleX, skewY, perspX, skewX, scaleY, perspY, offsetX, offsetY, perspZ));



}
