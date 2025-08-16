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
public static partial class InlineUIContainer_MarkupExtensions
{
//================= Properties ======================//
 // Child

/*ValueSetterGenerator*/
public static T Child<T>(this T control, Avalonia.Controls.Control value) where T : Avalonia.Controls.Documents.InlineUIContainer 
=> control._set(() => control.Child = value!);

/*BindFromFuncSetterGenerator*/
public static T Child<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null) where T : Avalonia.Controls.Documents.InlineUIContainer 
   => control._set(func, Avalonia.Controls.Documents.InlineUIContainer.ChildProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Child<T>(this T control, ISignal<Avalonia.Controls.Control> signal, Action<Avalonia.Controls.Control>? onChanged = null) where T : Avalonia.Controls.Documents.InlineUIContainer 
   => control._set(signal, Avalonia.Controls.Documents.InlineUIContainer.ChildProperty!, onChanged);



//================= Styles ======================//
 // Child

/*ValueStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Documents.InlineUIContainer 
=> style._addSetter(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.InlineUIContainer 
=> style._addSetter(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty, binding);



}
