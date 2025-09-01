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
public static partial class DataValidationErrors_MarkupExtensions
{
//================= Properties ======================//
 // ErrorTemplate

/*ValueSetterGenerator*/
public static T ErrorTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.DataValidationErrors 
=> control._set(() => control.ErrorTemplate = value!);

/*BindFromFuncSetterGenerator*/
public static T ErrorTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.DataValidationErrors 
   => control._set(func, Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T ErrorTemplate<T>(this T control, ISignal<Avalonia.Controls.Templates.IDataTemplate> signal, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null) where T : Avalonia.Controls.DataValidationErrors 
   => control._set(signal, Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty!, onChanged);


 // Owner

/*ValueSetterGenerator*/
public static T Owner<T>(this T control, Avalonia.Controls.Control value) where T : Avalonia.Controls.DataValidationErrors 
=> control._set(() => control.Owner = value!);

/*BindFromFuncSetterGenerator*/
public static T Owner<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null) where T : Avalonia.Controls.DataValidationErrors 
   => control._set(func, Avalonia.Controls.DataValidationErrors.OwnerProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Owner<T>(this T control, ISignal<Avalonia.Controls.Control> signal, Action<Avalonia.Controls.Control>? onChanged = null) where T : Avalonia.Controls.DataValidationErrors 
   => control._set(signal, Avalonia.Controls.DataValidationErrors.OwnerProperty!, onChanged);



//================= Attached Properties ======================//
 // Errors

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T DataValidationErrors_Errors<T>(this T control, Func<System.Collections.Generic.IEnumerable<System.Object>> func, Action<System.Collections.Generic.IEnumerable<System.Object>>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.DataValidationErrors.ErrorsProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T DataValidationErrors_Errors<T>(this T control, ISignal<System.Collections.Generic.IEnumerable<System.Object>> signal, Action<System.Collections.Generic.IEnumerable<System.Object>>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.DataValidationErrors.ErrorsProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T DataValidationErrors_Errors<T>(this T control, System.Collections.Generic.IEnumerable<System.Object> value, Action<System.Collections.Generic.IEnumerable<System.Object>>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.DataValidationErrors.ErrorsProperty!, onChanged);


 // ErrorConverter

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T DataValidationErrors_ErrorConverter<T>(this T control, Func<System.Func<System.Object,System.Object>> func, Action<System.Func<System.Object,System.Object>>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(func, Avalonia.Controls.DataValidationErrors.ErrorConverterProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T DataValidationErrors_ErrorConverter<T>(this T control, ISignal<System.Func<System.Object,System.Object>> signal, Action<System.Func<System.Object,System.Object>>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(signal, Avalonia.Controls.DataValidationErrors.ErrorConverterProperty!, onChanged);

/*AttachedPropertyMagicalSetterGenerator*/
public static T DataValidationErrors_ErrorConverter<T>(this T control, System.Func<System.Object,System.Object> value, Action<System.Func<System.Object,System.Object>>? onChanged = null) where T : Avalonia.Controls.Control 
   => control._set(() => value, Avalonia.Controls.DataValidationErrors.ErrorConverterProperty!, onChanged);



//================= Styles ======================//
 // ErrorTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ErrorTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.DataValidationErrors 
=> style._addSetter(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ErrorTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DataValidationErrors 
=> style._addSetter(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty, binding);



}
