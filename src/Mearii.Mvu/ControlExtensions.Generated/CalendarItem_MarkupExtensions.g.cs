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
public static partial class CalendarItem_MarkupExtensions
{
//================= Properties ======================//
 // HeaderBackground

/*ValueSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground(this Avalonia.Controls.Primitives.CalendarItem control, Avalonia.Media.IBrush value)  
=> control._set(() => control.HeaderBackground = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground(this Avalonia.Controls.Primitives.CalendarItem control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null)  
   => control._set(func, Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground(this Avalonia.Controls.Primitives.CalendarItem control, ISignal<Avalonia.Media.IBrush> signal, Action<Avalonia.Media.IBrush>? onChanged = null)  
   => control._set(signal, Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty!, onChanged);


 // DayTitleTemplate

/*ValueSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate(this Avalonia.Controls.Primitives.CalendarItem control, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value)  
=> control._set(() => control.DayTitleTemplate = value!);

/*BindFromFuncSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate(this Avalonia.Controls.Primitives.CalendarItem control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>? onChanged = null)  
   => control._set(func, Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate(this Avalonia.Controls.Primitives.CalendarItem control, ISignal<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> signal, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>? onChanged = null)  
   => control._set(signal, Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty!, onChanged);



//================= Styles ======================//
 // HeaderBackground

/*ValueStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.CalendarItem> HeaderBackground(this Style<Avalonia.Controls.Primitives.CalendarItem> style, Avalonia.Media.IBrush value)  
=> style._addSetter(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.CalendarItem> HeaderBackground(this Style<Avalonia.Controls.Primitives.CalendarItem> style, IBinding binding)  
=> style._addSetter(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, binding);


 // DayTitleTemplate

/*ValueStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.CalendarItem> DayTitleTemplate(this Style<Avalonia.Controls.Primitives.CalendarItem> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value)  
=> style._addSetter(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.CalendarItem> DayTitleTemplate(this Style<Avalonia.Controls.Primitives.CalendarItem> style, IBinding binding)  
=> style._addSetter(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, binding);



}
