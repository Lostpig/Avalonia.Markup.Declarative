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
public static partial class AccessText_MarkupExtensions
{
//================= Properties ======================//
 // ShowAccessKey

/*ValueSetterGenerator*/
public static T ShowAccessKey<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.AccessText 
=> control._set(() => control.ShowAccessKey = value!);

/*BindFromFuncSetterGenerator*/
public static T ShowAccessKey<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.AccessText 
   => control._set(func, Avalonia.Controls.Primitives.AccessText.ShowAccessKeyProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ShowAccessKey<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.Primitives.AccessText 
   => control._set(signal, Avalonia.Controls.Primitives.AccessText.ShowAccessKeyProperty!, onChanged);



//================= Styles ======================//
 // ShowAccessKey

/*ValueStyleSetterGenerator*/
public static Style<T> ShowAccessKey<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.AccessText 
=> style._addSetter(Avalonia.Controls.Primitives.AccessText.ShowAccessKeyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowAccessKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.AccessText 
=> style._addSetter(Avalonia.Controls.Primitives.AccessText.ShowAccessKeyProperty, binding);



}
