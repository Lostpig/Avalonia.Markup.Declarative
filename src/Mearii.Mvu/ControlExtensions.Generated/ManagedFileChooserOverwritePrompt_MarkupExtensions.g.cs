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
public static partial class ManagedFileChooserOverwritePrompt_MarkupExtensions
{
//================= Properties ======================//
 // FileName

/*ValueSetterGenerator*/
public static T FileName<T>(this T control, System.String value) where T : Avalonia.Dialogs.ManagedFileChooserOverwritePrompt 
=> control._set(() => control.FileName = value!);

/*BindFromFuncSetterGenerator*/
public static T FileName<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null) where T : Avalonia.Dialogs.ManagedFileChooserOverwritePrompt 
   => control._set(func, Avalonia.Dialogs.ManagedFileChooserOverwritePrompt.FileNameProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T FileName<T>(this T control, ISignal<System.String> signal, Action<System.String>? onChanged = null) where T : Avalonia.Dialogs.ManagedFileChooserOverwritePrompt 
   => control._set(signal, Avalonia.Dialogs.ManagedFileChooserOverwritePrompt.FileNameProperty!, onChanged);



}
