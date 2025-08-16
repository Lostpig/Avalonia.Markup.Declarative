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
public static partial class Span_MarkupExtensions
{
//================= Properties ======================//
 // Inlines

/*ValueSetterGenerator*/
public static T Inlines<T>(this T control, Avalonia.Controls.Documents.InlineCollection value) where T : Avalonia.Controls.Documents.Span 
=> control._set(() => control.Inlines = value!);

/*BindFromFuncSetterGenerator*/
public static T Inlines<T>(this T control, Func<Avalonia.Controls.Documents.InlineCollection> func, Action<Avalonia.Controls.Documents.InlineCollection>? onChanged = null) where T : Avalonia.Controls.Documents.Span 
   => control._set(func, Avalonia.Controls.Documents.Span.InlinesProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Inlines<T>(this T control, ISignal<Avalonia.Controls.Documents.InlineCollection> signal, Action<Avalonia.Controls.Documents.InlineCollection>? onChanged = null) where T : Avalonia.Controls.Documents.Span 
   => control._set(signal, Avalonia.Controls.Documents.Span.InlinesProperty!, onChanged);



//================= Styles ======================//
 // Inlines

/*ValueStyleSetterGenerator*/
public static Style<T> Inlines<T>(this Style<T> style, Avalonia.Controls.Documents.InlineCollection value) where T : Avalonia.Controls.Documents.Span 
=> style._addSetter(Avalonia.Controls.Documents.Span.InlinesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Inlines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.Span 
=> style._addSetter(Avalonia.Controls.Documents.Span.InlinesProperty, binding);



}
