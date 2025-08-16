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
public static partial class DashStyle_MarkupExtensions
{
//================= Properties ======================//
 // Dashes

/*ValueSetterGenerator*/
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control, Avalonia.Collections.AvaloniaList<System.Double> value)  
=> control._set(() => control.Dashes = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null)  
   => control._set(func, Avalonia.Media.DashStyle.DashesProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control, ISignal<Avalonia.Collections.AvaloniaList<System.Double>> signal, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null)  
   => control._set(signal, Avalonia.Media.DashStyle.DashesProperty!, onChanged);


 // Offset

/*ValueSetterGenerator*/
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control, System.Double value)  
=> control._set(() => control.Offset = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control, Func<System.Double> func, Action<System.Double>? onChanged = null)  
   => control._set(func, Avalonia.Media.DashStyle.OffsetProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null)  
   => control._set(signal, Avalonia.Media.DashStyle.OffsetProperty!, onChanged);



}
