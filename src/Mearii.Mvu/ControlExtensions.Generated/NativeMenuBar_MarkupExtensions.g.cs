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
public static partial class NativeMenuBar_MarkupExtensions
{
//================= Attached Properties ======================//
 // EnableMenuItemClickForwarding

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T NativeMenuBar_EnableMenuItemClickForwarding<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(func, Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T NativeMenuBar_EnableMenuItemClickForwarding<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(signal, Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T NativeMenuBar_EnableMenuItemClickForwarding<T>(this T control, System.Boolean value, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.MenuItem 
   => control._set(() => value, Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty!, onChanged);



}
