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
public static partial class KeyBinding_MarkupExtensions
{
//================= Properties ======================//
 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand value) where T : Avalonia.Input.KeyBinding 
=> control._set(() => control.Command = value!);

/*BindFromFuncSetterGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null) where T : Avalonia.Input.KeyBinding 
   => control._set(func, Avalonia.Input.KeyBinding.CommandProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Command<T>(this T control, ISignal<System.Windows.Input.ICommand> signal, Action<System.Windows.Input.ICommand>? onChanged = null) where T : Avalonia.Input.KeyBinding 
   => control._set(signal, Avalonia.Input.KeyBinding.CommandProperty!, onChanged);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object value) where T : Avalonia.Input.KeyBinding 
=> control._set(() => control.CommandParameter = value!);

/*BindFromFuncSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.Input.KeyBinding 
   => control._set(func, Avalonia.Input.KeyBinding.CommandParameterProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T CommandParameter<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.Input.KeyBinding 
   => control._set(signal, Avalonia.Input.KeyBinding.CommandParameterProperty!, onChanged);


 // Gesture

/*ValueSetterGenerator*/
public static T Gesture<T>(this T control, Avalonia.Input.KeyGesture value) where T : Avalonia.Input.KeyBinding 
=> control._set(() => control.Gesture = value!);

/*BindFromFuncSetterGenerator*/
public static T Gesture<T>(this T control, Func<Avalonia.Input.KeyGesture> func, Action<Avalonia.Input.KeyGesture>? onChanged = null) where T : Avalonia.Input.KeyBinding 
   => control._set(func, Avalonia.Input.KeyBinding.GestureProperty!, onChanged);

/*BindFromSignalSetterGenerator*/
public static T Gesture<T>(this T control, ISignal<Avalonia.Input.KeyGesture> signal, Action<Avalonia.Input.KeyGesture>? onChanged = null) where T : Avalonia.Input.KeyBinding 
   => control._set(signal, Avalonia.Input.KeyBinding.GestureProperty!, onChanged);



}
