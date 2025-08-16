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
public static partial class ExperimentalAcrylicBorder_MarkupExtensions
{
//================= Properties ======================//
 // CornerRadius

/*ValueSetterGenerator*/
public static T CornerRadius<T>(this T control, Avalonia.CornerRadius value) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
=> control._set(() => control.CornerRadius = value!);

/*BindFromFuncSetterGenerator*/
public static T CornerRadius<T>(this T control, Func<Avalonia.CornerRadius> func, Action<Avalonia.CornerRadius>? onChanged = null) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
   => control._set(func, Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CornerRadius<T>(this T control, ISignal<Avalonia.CornerRadius> signal, Action<Avalonia.CornerRadius>? onChanged = null) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
   => control._set(signal, Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty!, onChanged);

/*ValueOverloadsSetterGenerator*/

public static T CornerRadius<T>(this T control, System.Double uniformRadius = default!) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(uniformRadius));
public static T CornerRadius<T>(this T control, System.Double top = default!, System.Double bottom = default!) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(top, bottom));
public static T CornerRadius<T>(this T control, System.Double topLeft = default!, System.Double topRight = default!, System.Double bottomRight = default!, System.Double bottomLeft = default!) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));


 // Material

/*ValueSetterGenerator*/
public static T Material<T>(this T control, Avalonia.Media.ExperimentalAcrylicMaterial value) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
=> control._set(() => control.Material = value!);

/*BindFromFuncSetterGenerator*/
public static T Material<T>(this T control, Func<Avalonia.Media.ExperimentalAcrylicMaterial> func, Action<Avalonia.Media.ExperimentalAcrylicMaterial>? onChanged = null) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
   => control._set(func, Avalonia.Controls.ExperimentalAcrylicBorder.MaterialProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Material<T>(this T control, ISignal<Avalonia.Media.ExperimentalAcrylicMaterial> signal, Action<Avalonia.Media.ExperimentalAcrylicMaterial>? onChanged = null) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
   => control._set(signal, Avalonia.Controls.ExperimentalAcrylicBorder.MaterialProperty!, onChanged);



//================= Styles ======================//
 // CornerRadius

/*ValueStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, Avalonia.CornerRadius value) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
=> style._addSetter(Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
=> style._addSetter(Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, System.Double uniformRadius) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
   => style._addSetter(Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty, new Avalonia.CornerRadius(uniformRadius));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double top, System.Double bottom) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
   => style._addSetter(Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty, new Avalonia.CornerRadius(top, bottom));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double topLeft, System.Double topRight, System.Double bottomRight, System.Double bottomLeft) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
   => style._addSetter(Avalonia.Controls.ExperimentalAcrylicBorder.CornerRadiusProperty, new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));


 // Material

/*ValueStyleSetterGenerator*/
public static Style<T> Material<T>(this Style<T> style, Avalonia.Media.ExperimentalAcrylicMaterial value) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
=> style._addSetter(Avalonia.Controls.ExperimentalAcrylicBorder.MaterialProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Material<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ExperimentalAcrylicBorder 
=> style._addSetter(Avalonia.Controls.ExperimentalAcrylicBorder.MaterialProperty, binding);



}
