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
public static partial class AutoCompleteBox_MarkupExtensions
{
//================= Properties ======================//
 // CaretIndex

/*ValueSetterGenerator*/
public static T CaretIndex<T>(this T control, System.Int32 value) where T : Avalonia.Controls.AutoCompleteBox 
=> control._set(() => control.CaretIndex = value!);

/*BindFromFuncSetterGenerator*/
public static T CaretIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(func, Avalonia.Controls.AutoCompleteBox.CaretIndexProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CaretIndex<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(signal, Avalonia.Controls.AutoCompleteBox.CaretIndexProperty!, onChanged);


 // Watermark

/*ValueSetterGenerator*/
public static T Watermark<T>(this T control, System.String value) where T : Avalonia.Controls.AutoCompleteBox 
=> control._set(() => control.Watermark = value!);

/*BindFromFuncSetterGenerator*/
public static T Watermark<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(func, Avalonia.Controls.AutoCompleteBox.WatermarkProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Watermark<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(signal, Avalonia.Controls.AutoCompleteBox.WatermarkProperty!, onChanged);


 // MinimumPrefixLength

/*ValueSetterGenerator*/
public static T MinimumPrefixLength<T>(this T control, System.Int32 value) where T : Avalonia.Controls.AutoCompleteBox 
=> control._set(() => control.MinimumPrefixLength = value!);

/*BindFromFuncSetterGenerator*/
public static T MinimumPrefixLength<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(func, Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MinimumPrefixLength<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(signal, Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty!, onChanged);


 // MinimumPopulateDelay

/*ValueSetterGenerator*/
public static T MinimumPopulateDelay<T>(this T control, System.TimeSpan value) where T : Avalonia.Controls.AutoCompleteBox 
=> control._set(() => control.MinimumPopulateDelay = value!);

/*BindFromFuncSetterGenerator*/
public static T MinimumPopulateDelay<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(func, Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MinimumPopulateDelay<T>(this T control, ISignal<System.TimeSpan> signal, Action<System.TimeSpan>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(signal, Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty!, onChanged);


 // MaxDropDownHeight

/*ValueSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.AutoCompleteBox 
=> control._set(() => control.MaxDropDownHeight = value!);

/*BindFromFuncSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(func, Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, ISignal<System.Double> signal, Action<System.Double>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(signal, Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty!, onChanged);


 // IsTextCompletionEnabled

/*ValueSetterGenerator*/
public static T IsTextCompletionEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.AutoCompleteBox 
=> control._set(() => control.IsTextCompletionEnabled = value!);

/*BindFromFuncSetterGenerator*/
public static T IsTextCompletionEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(func, Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsTextCompletionEnabled<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(signal, Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty!, onChanged);


 // ItemTemplate

/*ValueSetterGenerator*/
public static T ItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.AutoCompleteBox 
=> control._set(() => control.ItemTemplate = value!);

/*BindFromFuncSetterGenerator*/
public static T ItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(func, Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ItemTemplate<T>(this T control, ISignal<Avalonia.Controls.Templates.IDataTemplate> signal, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(signal, Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty!, onChanged);


 // IsDropDownOpen

/*ValueSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.AutoCompleteBox 
=> control._set(() => control.IsDropDownOpen = value!);

/*BindFromFuncSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(func, Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(signal, Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty!, onChanged);


 // SelectedItem

/*ValueSetterGenerator*/
public static T SelectedItem<T>(this T control, System.Object value) where T : Avalonia.Controls.AutoCompleteBox 
=> control._set(() => control.SelectedItem = value!);

/*BindFromFuncSetterGenerator*/
public static T SelectedItem<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(func, Avalonia.Controls.AutoCompleteBox.SelectedItemProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T SelectedItem<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(signal, Avalonia.Controls.AutoCompleteBox.SelectedItemProperty!, onChanged);


 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String value) where T : Avalonia.Controls.AutoCompleteBox 
=> control._set(() => control.Text = value!);

/*BindFromFuncSetterGenerator*/
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(func, Avalonia.Controls.AutoCompleteBox.TextProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Text<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(signal, Avalonia.Controls.AutoCompleteBox.TextProperty!, onChanged);


 // FilterMode

/*ValueSetterGenerator*/
public static T FilterMode<T>(this T control, Avalonia.Controls.AutoCompleteFilterMode value) where T : Avalonia.Controls.AutoCompleteBox 
=> control._set(() => control.FilterMode = value!);

/*BindFromFuncSetterGenerator*/
public static T FilterMode<T>(this T control, Func<Avalonia.Controls.AutoCompleteFilterMode> func, Action<Avalonia.Controls.AutoCompleteFilterMode>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(func, Avalonia.Controls.AutoCompleteBox.FilterModeProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FilterMode<T>(this T control, ISignal<Avalonia.Controls.AutoCompleteFilterMode> signal, Action<Avalonia.Controls.AutoCompleteFilterMode>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(signal, Avalonia.Controls.AutoCompleteBox.FilterModeProperty!, onChanged);


 // ItemFilter

/*ValueSetterGenerator*/
public static T ItemFilter<T>(this T control, Avalonia.Controls.AutoCompleteFilterPredicate<System.Object> value) where T : Avalonia.Controls.AutoCompleteBox 
=> control._set(() => control.ItemFilter = value!);

/*BindFromFuncSetterGenerator*/
public static T ItemFilter<T>(this T control, Func<Avalonia.Controls.AutoCompleteFilterPredicate<System.Object>> func, Action<Avalonia.Controls.AutoCompleteFilterPredicate<System.Object>>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(func, Avalonia.Controls.AutoCompleteBox.ItemFilterProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ItemFilter<T>(this T control, ISignal<Avalonia.Controls.AutoCompleteFilterPredicate<System.Object>> signal, Action<Avalonia.Controls.AutoCompleteFilterPredicate<System.Object>>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(signal, Avalonia.Controls.AutoCompleteBox.ItemFilterProperty!, onChanged);


 // TextFilter

/*ValueSetterGenerator*/
public static T TextFilter<T>(this T control, Avalonia.Controls.AutoCompleteFilterPredicate<System.String> value) where T : Avalonia.Controls.AutoCompleteBox 
=> control._set(() => control.TextFilter = value!);

/*BindFromFuncSetterGenerator*/
public static T TextFilter<T>(this T control, Func<Avalonia.Controls.AutoCompleteFilterPredicate<System.String>> func, Action<Avalonia.Controls.AutoCompleteFilterPredicate<System.String>>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(func, Avalonia.Controls.AutoCompleteBox.TextFilterProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TextFilter<T>(this T control, ISignal<Avalonia.Controls.AutoCompleteFilterPredicate<System.String>> signal, Action<Avalonia.Controls.AutoCompleteFilterPredicate<System.String>>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(signal, Avalonia.Controls.AutoCompleteBox.TextFilterProperty!, onChanged);


 // ItemSelector

/*ValueSetterGenerator*/
public static T ItemSelector<T>(this T control, Avalonia.Controls.AutoCompleteSelector<System.Object> value) where T : Avalonia.Controls.AutoCompleteBox 
=> control._set(() => control.ItemSelector = value!);

/*BindFromFuncSetterGenerator*/
public static T ItemSelector<T>(this T control, Func<Avalonia.Controls.AutoCompleteSelector<System.Object>> func, Action<Avalonia.Controls.AutoCompleteSelector<System.Object>>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(func, Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ItemSelector<T>(this T control, ISignal<Avalonia.Controls.AutoCompleteSelector<System.Object>> signal, Action<Avalonia.Controls.AutoCompleteSelector<System.Object>>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(signal, Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty!, onChanged);


 // TextSelector

/*ValueSetterGenerator*/
public static T TextSelector<T>(this T control, Avalonia.Controls.AutoCompleteSelector<System.String> value) where T : Avalonia.Controls.AutoCompleteBox 
=> control._set(() => control.TextSelector = value!);

/*BindFromFuncSetterGenerator*/
public static T TextSelector<T>(this T control, Func<Avalonia.Controls.AutoCompleteSelector<System.String>> func, Action<Avalonia.Controls.AutoCompleteSelector<System.String>>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(func, Avalonia.Controls.AutoCompleteBox.TextSelectorProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T TextSelector<T>(this T control, ISignal<Avalonia.Controls.AutoCompleteSelector<System.String>> signal, Action<Avalonia.Controls.AutoCompleteSelector<System.String>>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(signal, Avalonia.Controls.AutoCompleteBox.TextSelectorProperty!, onChanged);


 // ItemsSource

/*ValueSetterGenerator*/
public static T ItemsSource<T>(this T control, System.Collections.IEnumerable value) where T : Avalonia.Controls.AutoCompleteBox 
=> control._set(() => control.ItemsSource = value!);

/*BindFromFuncSetterGenerator*/
public static T ItemsSource<T>(this T control, Func<System.Collections.IEnumerable> func, Action<System.Collections.IEnumerable>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(func, Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ItemsSource<T>(this T control, ISignal<System.Collections.IEnumerable> signal, Action<System.Collections.IEnumerable>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(signal, Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty!, onChanged);


 // AsyncPopulator

/*ValueSetterGenerator*/
public static T AsyncPopulator<T>(this T control, System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>> value) where T : Avalonia.Controls.AutoCompleteBox 
=> control._set(() => control.AsyncPopulator = value!);

/*BindFromFuncSetterGenerator*/
public static T AsyncPopulator<T>(this T control, Func<System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>>> func, Action<System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>>>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(func, Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T AsyncPopulator<T>(this T control, ISignal<System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>>> signal, Action<System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>>>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(signal, Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty!, onChanged);


 // MaxLength

/*ValueSetterGenerator*/
public static T MaxLength<T>(this T control, System.Int32 value) where T : Avalonia.Controls.AutoCompleteBox 
=> control._set(() => control.MaxLength = value!);

/*BindFromFuncSetterGenerator*/
public static T MaxLength<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(func, Avalonia.Controls.AutoCompleteBox.MaxLengthProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T MaxLength<T>(this T control, ISignal<System.Int32> signal, Action<System.Int32>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(signal, Avalonia.Controls.AutoCompleteBox.MaxLengthProperty!, onChanged);


 // InnerLeftContent

/*ValueSetterGenerator*/
public static T InnerLeftContent<T>(this T control, System.Object value) where T : Avalonia.Controls.AutoCompleteBox 
=> control._set(() => control.InnerLeftContent = value!);

/*BindFromFuncSetterGenerator*/
public static T InnerLeftContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(func, Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T InnerLeftContent<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(signal, Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty!, onChanged);


 // InnerRightContent

/*ValueSetterGenerator*/
public static T InnerRightContent<T>(this T control, System.Object value) where T : Avalonia.Controls.AutoCompleteBox 
=> control._set(() => control.InnerRightContent = value!);

/*BindFromFuncSetterGenerator*/
public static T InnerRightContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(func, Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T InnerRightContent<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(signal, Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty!, onChanged);



//================= Events ======================//
 // TextChanged

/*ActionToEventGenerator*/
public static T OnTextChanged<T>(this T control, Action<Avalonia.Controls.TextChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.AutoCompleteBox 
{
  control.AddHandler(Avalonia.Controls.AutoCompleteBox.TextChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.AutoCompleteBox.TextChangedEvent.RoutingStrategies);
  return control;
}



 // Populating

/*ActionToEventGenerator*/
public static T OnPopulating<T>(this T control, Action<Avalonia.Controls.PopulatingEventArgs> action) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.PopulatingEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Populating += h);


 // Populated

/*ActionToEventGenerator*/
public static T OnPopulated<T>(this T control, Action<Avalonia.Controls.PopulatedEventArgs> action) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.PopulatedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Populated += h);


 // DropDownOpening

/*ActionToEventGenerator*/
public static T OnDropDownOpening<T>(this T control, Action<System.ComponentModel.CancelEventArgs> action) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler<System.ComponentModel.CancelEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DropDownOpening += h);


 // DropDownOpened

/*ActionToEventGenerator*/
public static T OnDropDownOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DropDownOpened += h);


 // DropDownClosing

/*ActionToEventGenerator*/
public static T OnDropDownClosing<T>(this T control, Action<System.ComponentModel.CancelEventArgs> action) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler<System.ComponentModel.CancelEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DropDownClosing += h);


 // DropDownClosed

/*ActionToEventGenerator*/
public static T OnDropDownClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DropDownClosed += h);


 // SelectionChanged

/*ActionToEventGenerator*/
public static T OnSelectionChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.AutoCompleteBox 
{
  control.AddHandler(Avalonia.Controls.AutoCompleteBox.SelectionChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.AutoCompleteBox.SelectionChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // CaretIndex

/*ValueStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty, binding);


 // Watermark

/*ValueStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.WatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.WatermarkProperty, binding);


 // MinimumPrefixLength

/*ValueStyleSetterGenerator*/
public static Style<T> MinimumPrefixLength<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinimumPrefixLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty, binding);


 // MinimumPopulateDelay

/*ValueStyleSetterGenerator*/
public static Style<T> MinimumPopulateDelay<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinimumPopulateDelay<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty, binding);


 // MaxDropDownHeight

/*ValueStyleSetterGenerator*/
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty, binding);


 // IsTextCompletionEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsTextCompletionEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTextCompletionEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty, binding);


 // ItemTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ItemTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty, binding);


 // IsDropDownOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty, binding);


 // SelectedItem

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedItem<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedItem<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextProperty, binding);


 // FilterMode

/*ValueStyleSetterGenerator*/
public static Style<T> FilterMode<T>(this Style<T> style, Avalonia.Controls.AutoCompleteFilterMode value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.FilterModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FilterMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.FilterModeProperty, binding);


 // ItemFilter

/*ValueStyleSetterGenerator*/
public static Style<T> ItemFilter<T>(this Style<T> style, Avalonia.Controls.AutoCompleteFilterPredicate<System.Object> value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemFilter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty, binding);


 // TextFilter

/*ValueStyleSetterGenerator*/
public static Style<T> TextFilter<T>(this Style<T> style, Avalonia.Controls.AutoCompleteFilterPredicate<System.String> value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextFilterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextFilter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextFilterProperty, binding);


 // ItemSelector

/*ValueStyleSetterGenerator*/
public static Style<T> ItemSelector<T>(this Style<T> style, Avalonia.Controls.AutoCompleteSelector<System.Object> value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemSelector<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty, binding);


 // TextSelector

/*ValueStyleSetterGenerator*/
public static Style<T> TextSelector<T>(this Style<T> style, Avalonia.Controls.AutoCompleteSelector<System.String> value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TextSelector<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty, binding);


 // ItemsSource

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsSource<T>(this Style<T> style, System.Collections.IEnumerable value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsSource<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty, binding);


 // AsyncPopulator

/*ValueStyleSetterGenerator*/
public static Style<T> AsyncPopulator<T>(this Style<T> style, System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>> value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AsyncPopulator<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty, binding);


 // MaxLength

/*ValueStyleSetterGenerator*/
public static Style<T> MaxLength<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty, binding);


 // InnerLeftContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty, binding);


 // InnerRightContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty, binding);



}
