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
public static partial class ItemsControl_MarkupExtensions
{
//================= Properties ======================//
 // ItemContainerTheme

/*ValueSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, Avalonia.Styling.ControlTheme value) where T : Avalonia.Controls.ItemsControl 
=> control._set(() => control.ItemContainerTheme = value!);

/*BindFromFuncSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme> func, Action<Avalonia.Styling.ControlTheme>? onChanged = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(func, Avalonia.Controls.ItemsControl.ItemContainerThemeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, ISignal<Avalonia.Styling.ControlTheme> signal, Action<Avalonia.Styling.ControlTheme>? onChanged = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(signal, Avalonia.Controls.ItemsControl.ItemContainerThemeProperty!, onChanged);


 // ItemsPanel

/*ValueSetterGenerator*/
public static T ItemsPanel<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value) where T : Avalonia.Controls.ItemsControl 
=> control._set(() => control.ItemsPanel = value!);

/*BindFromFuncSetterGenerator*/
public static T ItemsPanel<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>>? onChanged = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(func, Avalonia.Controls.ItemsControl.ItemsPanelProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ItemsPanel<T>(this T control, ISignal<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> signal, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>>? onChanged = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(signal, Avalonia.Controls.ItemsControl.ItemsPanelProperty!, onChanged);


 // ItemsSource

/*ValueSetterGenerator*/
public static T ItemsSource<T>(this T control, System.Collections.IEnumerable value) where T : Avalonia.Controls.ItemsControl 
=> control._set(() => control.ItemsSource = value!);

/*BindFromFuncSetterGenerator*/
public static T ItemsSource<T>(this T control, Func<System.Collections.IEnumerable> func, Action<System.Collections.IEnumerable>? onChanged = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(func, Avalonia.Controls.ItemsControl.ItemsSourceProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ItemsSource<T>(this T control, ISignal<System.Collections.IEnumerable> signal, Action<System.Collections.IEnumerable>? onChanged = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(signal, Avalonia.Controls.ItemsControl.ItemsSourceProperty!, onChanged);


 // ItemTemplate

/*ValueSetterGenerator*/
public static T ItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ItemsControl 
=> control._set(() => control.ItemTemplate = value!);

/*BindFromFuncSetterGenerator*/
public static T ItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(func, Avalonia.Controls.ItemsControl.ItemTemplateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ItemTemplate<T>(this T control, ISignal<Avalonia.Controls.Templates.IDataTemplate> signal, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(signal, Avalonia.Controls.ItemsControl.ItemTemplateProperty!, onChanged);


 // DisplayMemberBinding

/*ValueSetterGenerator*/
public static T DisplayMemberBinding<T>(this T control, Avalonia.Data.IBinding value) where T : Avalonia.Controls.ItemsControl 
=> control._set(() => control.DisplayMemberBinding = value!);

/*BindFromFuncSetterGenerator*/
public static T DisplayMemberBinding<T>(this T control, Func<Avalonia.Data.IBinding> func, Action<Avalonia.Data.IBinding>? onChanged = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(func, Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T DisplayMemberBinding<T>(this T control, ISignal<Avalonia.Data.IBinding> signal, Action<Avalonia.Data.IBinding>? onChanged = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(signal, Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty!, onChanged);



//================= Events ======================//
 // PreparingContainer

/*ActionToEventGenerator*/
public static T OnPreparingContainer<T>(this T control, Action<Avalonia.Controls.ContainerPreparedEventArgs> action) where T : Avalonia.Controls.ItemsControl  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ContainerPreparedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PreparingContainer += h);


 // ContainerPrepared

/*ActionToEventGenerator*/
public static T OnContainerPrepared<T>(this T control, Action<Avalonia.Controls.ContainerPreparedEventArgs> action) where T : Avalonia.Controls.ItemsControl  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ContainerPreparedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ContainerPrepared += h);


 // ContainerIndexChanged

/*ActionToEventGenerator*/
public static T OnContainerIndexChanged<T>(this T control, Action<Avalonia.Controls.ContainerIndexChangedEventArgs> action) where T : Avalonia.Controls.ItemsControl  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ContainerIndexChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ContainerIndexChanged += h);


 // ContainerClearing

/*ActionToEventGenerator*/
public static T OnContainerClearing<T>(this T control, Action<Avalonia.Controls.ContainerClearingEventArgs> action) where T : Avalonia.Controls.ItemsControl  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ContainerClearingEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ContainerClearing += h);



//================= Styles ======================//
 // ItemContainerTheme

/*ValueStyleSetterGenerator*/
public static Style<T> ItemContainerTheme<T>(this Style<T> style, Avalonia.Styling.ControlTheme value) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemContainerTheme<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, binding);


 // ItemsPanel

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsPanel<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemsPanelProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsPanel<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemsPanelProperty, binding);


 // ItemsSource

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsSource<T>(this Style<T> style, System.Collections.IEnumerable value) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemsSourceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsSource<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemsSourceProperty, binding);


 // ItemTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ItemTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemTemplateProperty, binding);


 // DisplayMemberBinding

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayMemberBinding<T>(this Style<T> style, Avalonia.Data.IBinding value) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped DisplayMemberBinding because already exist in value setters



}
