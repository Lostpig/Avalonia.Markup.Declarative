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
public static partial class HyperlinkButton_MarkupExtensions
{
//================= Properties ======================//
 // IsVisited

/*ValueSetterGenerator*/
public static T IsVisited<T>(this T control, System.Boolean value) where T : Avalonia.Controls.HyperlinkButton 
=> control._set(() => control.IsVisited = value!);

/*BindFromFuncSetterGenerator*/
public static T IsVisited<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.HyperlinkButton 
   => control._set(func, Avalonia.Controls.HyperlinkButton.IsVisitedProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsVisited<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.HyperlinkButton 
   => control._set(signal, Avalonia.Controls.HyperlinkButton.IsVisitedProperty!, onChanged);


 // NavigateUri

/*ValueSetterGenerator*/
public static T NavigateUri<T>(this T control, System.Uri value) where T : Avalonia.Controls.HyperlinkButton 
=> control._set(() => control.NavigateUri = value!);

/*BindFromFuncSetterGenerator*/
public static T NavigateUri<T>(this T control, Func<System.Uri> func, Action<System.Uri>? onChanged = null) where T : Avalonia.Controls.HyperlinkButton 
   => control._set(func, Avalonia.Controls.HyperlinkButton.NavigateUriProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T NavigateUri<T>(this T control, ISignal<System.Uri> signal, Action<System.Uri>? onChanged = null) where T : Avalonia.Controls.HyperlinkButton 
   => control._set(signal, Avalonia.Controls.HyperlinkButton.NavigateUriProperty!, onChanged);



//================= Styles ======================//
 // IsVisited

/*ValueStyleSetterGenerator*/
public static Style<T> IsVisited<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.HyperlinkButton 
=> style._addSetter(Avalonia.Controls.HyperlinkButton.IsVisitedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsVisited<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.HyperlinkButton 
=> style._addSetter(Avalonia.Controls.HyperlinkButton.IsVisitedProperty, binding);


 // NavigateUri

/*ValueStyleSetterGenerator*/
public static Style<T> NavigateUri<T>(this Style<T> style, System.Uri value) where T : Avalonia.Controls.HyperlinkButton 
=> style._addSetter(Avalonia.Controls.HyperlinkButton.NavigateUriProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> NavigateUri<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.HyperlinkButton 
=> style._addSetter(Avalonia.Controls.HyperlinkButton.NavigateUriProperty, binding);



}
