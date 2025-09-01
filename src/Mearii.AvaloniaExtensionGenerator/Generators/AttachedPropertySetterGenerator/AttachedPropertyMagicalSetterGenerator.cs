using Mearii.AvaloniaExtensionGenerator.ExtensionInfos;

namespace Mearii.AvaloniaExtensionGenerator.Generators.AttachedPropertySetterGenerator;

public class AttachedPropertyMagicalSetterGenerator : ExtensionGeneratorBase<AttachedPropertyExtensionInfo>
{
    protected override string? GetExtension(AttachedPropertyExtensionInfo info) =>
        $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, {info.ValueTypeSource} value, Action<{info.ValueTypeSource}>? onChanged = null)" +
        $" where T : {info.AttachedPropertyHostTypeName} {Environment.NewLine}" +
        $"   => control._set(() => value, {info.ControlTypeName}.{info.FieldInfo.Name}!, onChanged);";

}