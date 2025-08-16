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
public static partial class TransformGroup_MarkupExtensions
{
//================= Properties ======================//
 // Children

/*ValueSetterGenerator*/
public static Avalonia.Media.TransformGroup Children(this Avalonia.Media.TransformGroup control, Avalonia.Media.Transforms value)  
=> control._set(() => control.Children = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.TransformGroup Children(this Avalonia.Media.TransformGroup control, Func<Avalonia.Media.Transforms> func, Action<Avalonia.Media.Transforms>? onChanged = null)  
   => control._set(func, Avalonia.Media.TransformGroup.ChildrenProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.TransformGroup Children(this Avalonia.Media.TransformGroup control, ISignal<Avalonia.Media.Transforms> signal, Action<Avalonia.Media.Transforms>? onChanged = null)  
   => control._set(signal, Avalonia.Media.TransformGroup.ChildrenProperty!, onChanged);



}
