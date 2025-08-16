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
public static partial class PathSegment_MarkupExtensions
{
//================= Properties ======================//
 // IsStroked

/*ValueSetterGenerator*/
public static T IsStroked<T>(this T control, System.Boolean value) where T : Avalonia.Media.PathSegment 
=> control._set(() => control.IsStroked = value!);

/*BindFromFuncSetterGenerator*/
public static T IsStroked<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Media.PathSegment 
   => control._set(func, Avalonia.Media.PathSegment.IsStrokedProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsStroked<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Media.PathSegment 
   => control._set(signal, Avalonia.Media.PathSegment.IsStrokedProperty!, onChanged);



}
