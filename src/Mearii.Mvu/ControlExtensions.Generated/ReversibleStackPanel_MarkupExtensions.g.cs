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
public static partial class ReversibleStackPanel_MarkupExtensions
{
//================= Properties ======================//
 // ReverseOrder

/*ValueSetterGenerator*/
public static T ReverseOrder<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ReversibleStackPanel 
=> control._set(() => control.ReverseOrder = value!);

/*BindFromFuncSetterGenerator*/
public static T ReverseOrder<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ReversibleStackPanel 
   => control._set(func, Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ReverseOrder<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.ReversibleStackPanel 
   => control._set(signal, Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty!, onChanged);



//================= Styles ======================//
 // ReverseOrder

/*ValueStyleSetterGenerator*/
public static Style<T> ReverseOrder<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ReversibleStackPanel 
=> style._addSetter(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ReverseOrder<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ReversibleStackPanel 
=> style._addSetter(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty, binding);



}
