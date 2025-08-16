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
public static partial class TabItem_MarkupExtensions
{
//================= Properties ======================//
 // IsSelected

/*ValueSetterGenerator*/
public static T IsSelected<T>(this T control, System.Boolean value) where T : Avalonia.Controls.TabItem 
=> control._set(() => control.IsSelected = value!);

/*BindFromFuncSetterGenerator*/
public static T IsSelected<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TabItem 
   => control._set(func, Avalonia.Controls.TabItem.IsSelectedProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsSelected<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.TabItem 
   => control._set(signal, Avalonia.Controls.TabItem.IsSelectedProperty!, onChanged);



//================= Styles ======================//
 // IsSelected

/*ValueStyleSetterGenerator*/
public static Style<T> IsSelected<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TabItem 
=> style._addSetter(Avalonia.Controls.TabItem.IsSelectedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSelected<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabItem 
=> style._addSetter(Avalonia.Controls.TabItem.IsSelectedProperty, binding);



}
