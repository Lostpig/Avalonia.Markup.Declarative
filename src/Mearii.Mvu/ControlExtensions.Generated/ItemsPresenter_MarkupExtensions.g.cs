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
public static partial class ItemsPresenter_MarkupExtensions
{
//================= Properties ======================//
 // ItemsPanel

/*ValueSetterGenerator*/
public static T ItemsPanel<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value) where T : Avalonia.Controls.Presenters.ItemsPresenter 
=> control._set(() => control.ItemsPanel = value!);

/*BindFromFuncSetterGenerator*/
public static T ItemsPanel<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>>? onChanged = null) where T : Avalonia.Controls.Presenters.ItemsPresenter 
   => control._set(func, Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ItemsPanel<T>(this T control, ISignal<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> signal, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>>? onChanged = null) where T : Avalonia.Controls.Presenters.ItemsPresenter 
   => control._set(signal, Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty!, onChanged);



//================= Styles ======================//
 // ItemsPanel

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsPanel<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value) where T : Avalonia.Controls.Presenters.ItemsPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsPanel<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ItemsPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ItemsPresenter.ItemsPanelProperty, binding);



}
