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
public static partial class NativeMenu_MarkupExtensions
{
//================= Attached Properties ======================//
 // Menu

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T NativeMenu_Menu<T>(this T control, Func<Avalonia.Controls.NativeMenu> func, Action<Avalonia.Controls.NativeMenu>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.NativeMenu.MenuProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T NativeMenu_Menu<T>(this T control, ISignal<Avalonia.Controls.NativeMenu> signal, Action<Avalonia.Controls.NativeMenu>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.NativeMenu.MenuProperty!, onChanged);



//================= Events ======================//
 // NeedsUpdate

/*ActionToEventGenerator*/
public static T OnNeedsUpdate<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.NativeMenu  => 
 control._setEvent((System.EventHandler<System.EventArgs>) ((arg0, arg1) => action(arg1)), h => control.NeedsUpdate += h);


 // Opening

/*ActionToEventGenerator*/
public static T OnOpening<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.NativeMenu  => 
 control._setEvent((System.EventHandler<System.EventArgs>) ((arg0, arg1) => action(arg1)), h => control.Opening += h);


 // Closed

/*ActionToEventGenerator*/
public static T OnClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.NativeMenu  => 
 control._setEvent((System.EventHandler<System.EventArgs>) ((arg0, arg1) => action(arg1)), h => control.Closed += h);



}
