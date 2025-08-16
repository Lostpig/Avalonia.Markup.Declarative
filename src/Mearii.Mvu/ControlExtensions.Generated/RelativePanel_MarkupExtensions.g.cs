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
public static partial class RelativePanel_MarkupExtensions
{
//================= Attached Properties ======================//
 // Above

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T RelativePanel_Above<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.RelativePanel.AboveProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T RelativePanel_Above<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.RelativePanel.AboveProperty!, onChanged);


 // AlignBottomWithPanel

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T RelativePanel_AlignBottomWithPanel<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.RelativePanel.AlignBottomWithPanelProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T RelativePanel_AlignBottomWithPanel<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.RelativePanel.AlignBottomWithPanelProperty!, onChanged);


 // AlignBottomWith

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T RelativePanel_AlignBottomWith<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.RelativePanel.AlignBottomWithProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T RelativePanel_AlignBottomWith<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.RelativePanel.AlignBottomWithProperty!, onChanged);


 // AlignHorizontalCenterWithPanel

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T RelativePanel_AlignHorizontalCenterWithPanel<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithPanelProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T RelativePanel_AlignHorizontalCenterWithPanel<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithPanelProperty!, onChanged);


 // AlignHorizontalCenterWith

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T RelativePanel_AlignHorizontalCenterWith<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T RelativePanel_AlignHorizontalCenterWith<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.RelativePanel.AlignHorizontalCenterWithProperty!, onChanged);


 // AlignLeftWithPanel

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T RelativePanel_AlignLeftWithPanel<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.RelativePanel.AlignLeftWithPanelProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T RelativePanel_AlignLeftWithPanel<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.RelativePanel.AlignLeftWithPanelProperty!, onChanged);


 // AlignLeftWith

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T RelativePanel_AlignLeftWith<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.RelativePanel.AlignLeftWithProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T RelativePanel_AlignLeftWith<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.RelativePanel.AlignLeftWithProperty!, onChanged);


 // AlignRightWithPanel

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T RelativePanel_AlignRightWithPanel<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.RelativePanel.AlignRightWithPanelProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T RelativePanel_AlignRightWithPanel<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.RelativePanel.AlignRightWithPanelProperty!, onChanged);


 // AlignRightWith

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T RelativePanel_AlignRightWith<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.RelativePanel.AlignRightWithProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T RelativePanel_AlignRightWith<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.RelativePanel.AlignRightWithProperty!, onChanged);


 // AlignTopWithPanel

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T RelativePanel_AlignTopWithPanel<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.RelativePanel.AlignTopWithPanelProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T RelativePanel_AlignTopWithPanel<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.RelativePanel.AlignTopWithPanelProperty!, onChanged);


 // AlignTopWith

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T RelativePanel_AlignTopWith<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.RelativePanel.AlignTopWithProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T RelativePanel_AlignTopWith<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.RelativePanel.AlignTopWithProperty!, onChanged);


 // AlignVerticalCenterWithPanel

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T RelativePanel_AlignVerticalCenterWithPanel<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.RelativePanel.AlignVerticalCenterWithPanelProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T RelativePanel_AlignVerticalCenterWithPanel<T>(this T control, ISignal<System.Boolean> signal, Action<System.Boolean>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.RelativePanel.AlignVerticalCenterWithPanelProperty!, onChanged);


 // AlignVerticalCenterWith

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T RelativePanel_AlignVerticalCenterWith<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.RelativePanel.AlignVerticalCenterWithProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T RelativePanel_AlignVerticalCenterWith<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.RelativePanel.AlignVerticalCenterWithProperty!, onChanged);


 // Below

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T RelativePanel_Below<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.RelativePanel.BelowProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T RelativePanel_Below<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.RelativePanel.BelowProperty!, onChanged);


 // LeftOf

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T RelativePanel_LeftOf<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.RelativePanel.LeftOfProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T RelativePanel_LeftOf<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.RelativePanel.LeftOfProperty!, onChanged);


 // RightOf

/*AttachedPropertyBindFromFuncSetterGenerator*/
public static T RelativePanel_RightOf<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(func, Avalonia.Controls.RelativePanel.RightOfProperty!, onChanged);

/*AttachedPropertyBindFromSignalSetterGenerator*/
public static T RelativePanel_RightOf<T>(this T control, ISignal<System.Object> signal, Action<System.Object>? onChanged = null) where T : Avalonia.AvaloniaObject 
   => control._set(signal, Avalonia.Controls.RelativePanel.RightOfProperty!, onChanged);



}
