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
public static partial class RadioButton_MarkupExtensions
{
//================= Properties ======================//
 // GroupName

/*ValueSetterGenerator*/
public static T GroupName<T>(this T control, System.String value) where T : Avalonia.Controls.RadioButton 
=> control._set(() => control.GroupName = value!);

/*BindFromFuncSetterGenerator*/
public static T GroupName<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.RadioButton 
   => control._set(func, Avalonia.Controls.RadioButton.GroupNameProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T GroupName<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.RadioButton 
   => control._set(signal, Avalonia.Controls.RadioButton.GroupNameProperty!, onChanged);



//================= Styles ======================//
 // GroupName

/*ValueStyleSetterGenerator*/
public static Style<T> GroupName<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.RadioButton 
=> style._addSetter(Avalonia.Controls.RadioButton.GroupNameProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> GroupName<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.RadioButton 
=> style._addSetter(Avalonia.Controls.RadioButton.GroupNameProperty, binding);



}
