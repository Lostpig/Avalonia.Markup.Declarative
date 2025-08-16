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
public static partial class StyledElement_MarkupExtensions
{
//================= Properties ======================//
 // DataContext

/*ValueSetterGenerator*/
public static T DataContext<T>(this T control, System.Object value) where T : Avalonia.StyledElement 
=> control._set(() => control.DataContext = value!);

/*BindFromFuncSetterGenerator*/
public static T DataContext<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.StyledElement 
   => control._set(func, Avalonia.StyledElement.DataContextProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T DataContext<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.StyledElement 
   => control._set(signal, Avalonia.StyledElement.DataContextProperty!, onChanged);


 // Name

/*ValueSetterGenerator*/
public static T Name<T>(this T control, System.String value) where T : Avalonia.StyledElement 
=> control._set(() => control.Name = value!);

/*BindFromFuncSetterGenerator*/
public static T Name<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.StyledElement 
   => control._set(func, Avalonia.StyledElement.NameProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Name<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.StyledElement 
   => control._set(signal, Avalonia.StyledElement.NameProperty!, onChanged);


 // Theme

/*ValueSetterGenerator*/
public static T Theme<T>(this T control, Avalonia.Styling.ControlTheme value) where T : Avalonia.StyledElement 
=> control._set(() => control.Theme = value!);

/*BindFromFuncSetterGenerator*/
public static T Theme<T>(this T control, Func<Avalonia.Styling.ControlTheme> func, Action<Avalonia.Styling.ControlTheme>? onChanged = null) where T : Avalonia.StyledElement 
   => control._set(func, Avalonia.StyledElement.ThemeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Theme<T>(this T control, ISignal<Avalonia.Styling.ControlTheme> signal, Action<Avalonia.Styling.ControlTheme>? onChanged = null) where T : Avalonia.StyledElement 
   => control._set(signal, Avalonia.StyledElement.ThemeProperty!, onChanged);



//================= Events ======================//
 // AttachedToLogicalTree

/*ActionToEventGenerator*/
public static T OnAttachedToLogicalTree<T>(this T control, Action<Avalonia.LogicalTree.LogicalTreeAttachmentEventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler<Avalonia.LogicalTree.LogicalTreeAttachmentEventArgs>) ((arg0, arg1) => action(arg1)), h => control.AttachedToLogicalTree += h);


 // DetachedFromLogicalTree

/*ActionToEventGenerator*/
public static T OnDetachedFromLogicalTree<T>(this T control, Action<Avalonia.LogicalTree.LogicalTreeAttachmentEventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler<Avalonia.LogicalTree.LogicalTreeAttachmentEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DetachedFromLogicalTree += h);


 // DataContextChanged

/*ActionToEventGenerator*/
public static T OnDataContextChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DataContextChanged += h);


 // Initialized

/*ActionToEventGenerator*/
public static T OnInitialized<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Initialized += h);


 // ResourcesChanged

/*ActionToEventGenerator*/
public static T OnResourcesChanged<T>(this T control, Action<Avalonia.Controls.ResourcesChangedEventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ResourcesChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ResourcesChanged += h);


 // ActualThemeVariantChanged

/*ActionToEventGenerator*/
public static T OnActualThemeVariantChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.ActualThemeVariantChanged += h);



//================= Styles ======================//
 // DataContext

/*ValueStyleSetterGenerator*/
public static Style<T> DataContext<T>(this Style<T> style, System.Object value) where T : Avalonia.StyledElement 
=> style._addSetter(Avalonia.StyledElement.DataContextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DataContext<T>(this Style<T> style, IBinding binding) where T : Avalonia.StyledElement 
=> style._addSetter(Avalonia.StyledElement.DataContextProperty, binding);


 // Theme

/*ValueStyleSetterGenerator*/
public static Style<T> Theme<T>(this Style<T> style, Avalonia.Styling.ControlTheme value) where T : Avalonia.StyledElement 
=> style._addSetter(Avalonia.StyledElement.ThemeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Theme<T>(this Style<T> style, IBinding binding) where T : Avalonia.StyledElement 
=> style._addSetter(Avalonia.StyledElement.ThemeProperty, binding);



}
