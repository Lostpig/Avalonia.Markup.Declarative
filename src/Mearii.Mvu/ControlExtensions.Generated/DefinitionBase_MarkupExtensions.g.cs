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
public static partial class DefinitionBase_MarkupExtensions
{
//================= Properties ======================//
 // SharedSizeGroup

/*ValueSetterGenerator*/
public static T SharedSizeGroup<T>(this T control, System.String value) where T : Avalonia.Controls.DefinitionBase 
=> control._set(() => control.SharedSizeGroup = value!);

/*BindFromFuncSetterGenerator*/
public static T SharedSizeGroup<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.DefinitionBase 
   => control._set(func, Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SharedSizeGroup<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.DefinitionBase 
   => control._set(signal, Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty!, onChanged);



}
