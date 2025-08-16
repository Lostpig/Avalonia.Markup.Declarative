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
public static partial class Run_MarkupExtensions
{
//================= Properties ======================//
 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String value) where T : Avalonia.Controls.Documents.Run 
=> control._set(() => control.Text = value!);

/*BindFromFuncSetterGenerator*/
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.Documents.Run 
   => control._set(func, Avalonia.Controls.Documents.Run.TextProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Text<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.Documents.Run 
   => control._set(signal, Avalonia.Controls.Documents.Run.TextProperty!, onChanged);



//================= Styles ======================//
 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.Documents.Run 
=> style._addSetter(Avalonia.Controls.Documents.Run.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.Run 
=> style._addSetter(Avalonia.Controls.Documents.Run.TextProperty, binding);



}
