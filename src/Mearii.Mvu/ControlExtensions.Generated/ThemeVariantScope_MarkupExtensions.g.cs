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
public static partial class ThemeVariantScope_MarkupExtensions
{
//================= Properties ======================//
 // RequestedThemeVariant

/*ValueSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Avalonia.Styling.ThemeVariant value) where T : Avalonia.Controls.ThemeVariantScope 
=> control._set(() => control.RequestedThemeVariant = value!);

/*BindFromFuncSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Func<Avalonia.Styling.ThemeVariant> func, Action<Avalonia.Styling.ThemeVariant>? onChanged = null) where T : Avalonia.Controls.ThemeVariantScope 
   => control._set(func, Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, ISignal<Avalonia.Styling.ThemeVariant> signal, Action<Avalonia.Styling.ThemeVariant>? onChanged = null) where T : Avalonia.Controls.ThemeVariantScope 
   => control._set(signal, Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty!, onChanged);



//================= Styles ======================//
 // RequestedThemeVariant

/*ValueStyleSetterGenerator*/
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, Avalonia.Styling.ThemeVariant value) where T : Avalonia.Controls.ThemeVariantScope 
=> style._addSetter(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ThemeVariantScope 
=> style._addSetter(Avalonia.Controls.ThemeVariantScope.RequestedThemeVariantProperty, binding);



}
