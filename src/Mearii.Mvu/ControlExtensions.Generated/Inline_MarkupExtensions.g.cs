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
public static partial class Inline_MarkupExtensions
{
//================= Properties ======================//
 // TextDecorations

/*ValueSetterGenerator*/
public static T TextDecorations<T>(this T control, Avalonia.Media.TextDecorationCollection value) where T : Avalonia.Controls.Documents.Inline 
=> control._set(() => control.TextDecorations = value!);

/*BindFromFuncSetterGenerator*/
public static T TextDecorations<T>(this T control, Func<Avalonia.Media.TextDecorationCollection> func, Action<Avalonia.Media.TextDecorationCollection>? onChanged = null) where T : Avalonia.Controls.Documents.Inline 
   => control._set(func, Avalonia.Controls.Documents.Inline.TextDecorationsProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TextDecorations<T>(this T control, ISignal<Avalonia.Media.TextDecorationCollection> signal, Action<Avalonia.Media.TextDecorationCollection>? onChanged = null) where T : Avalonia.Controls.Documents.Inline 
   => control._set(signal, Avalonia.Controls.Documents.Inline.TextDecorationsProperty!, onChanged);


 // BaselineAlignment

/*ValueSetterGenerator*/
public static T BaselineAlignment<T>(this T control, Avalonia.Media.BaselineAlignment value) where T : Avalonia.Controls.Documents.Inline 
=> control._set(() => control.BaselineAlignment = value!);

/*BindFromFuncSetterGenerator*/
public static T BaselineAlignment<T>(this T control, Func<Avalonia.Media.BaselineAlignment> func, Action<Avalonia.Media.BaselineAlignment>? onChanged = null) where T : Avalonia.Controls.Documents.Inline 
   => control._set(func, Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T BaselineAlignment<T>(this T control, ISignal<Avalonia.Media.BaselineAlignment> signal, Action<Avalonia.Media.BaselineAlignment>? onChanged = null) where T : Avalonia.Controls.Documents.Inline 
   => control._set(signal, Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty!, onChanged);



//================= Styles ======================//
 // TextDecorations

/*ValueStyleSetterGenerator*/
public static Style<T> TextDecorations<T>(this Style<T> style, Avalonia.Media.TextDecorationCollection value) where T : Avalonia.Controls.Documents.Inline 
=> style._addSetter(Avalonia.Controls.Documents.Inline.TextDecorationsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextDecorations<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.Inline 
=> style._addSetter(Avalonia.Controls.Documents.Inline.TextDecorationsProperty, binding);


 // BaselineAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> BaselineAlignment<T>(this Style<T> style, Avalonia.Media.BaselineAlignment value) where T : Avalonia.Controls.Documents.Inline 
=> style._addSetter(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BaselineAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.Inline 
=> style._addSetter(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty, binding);



}
