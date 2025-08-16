using Mearii.AvaloniaExtensionGenerator.ExtensionInfos;

namespace Mearii.AvaloniaExtensionGenerator.Generators.AttachedPropertySetterGenerator;

public class AttachedPropertyBindFromFuncSetterGenerator : ExtensionGeneratorBase<AttachedPropertyExtensionInfo>
{
    protected override string? GetExtension(AttachedPropertyExtensionInfo info) =>
        $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, Func<{info.ValueTypeSource}> func, Action<{info.ValueTypeSource}>? onChanged = null)" +
        $" where T : {info.AttachedPropertyHostTypeName} {Environment.NewLine}" +
        $"   => control._set(func, {info.ControlTypeName}.{info.FieldInfo.Name}!, onChanged);";

}