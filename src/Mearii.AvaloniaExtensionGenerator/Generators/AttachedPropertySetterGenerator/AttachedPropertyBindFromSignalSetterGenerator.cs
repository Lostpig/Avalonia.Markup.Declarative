using Mearii.AvaloniaExtensionGenerator.ExtensionInfos;

namespace Mearii.AvaloniaExtensionGenerator.Generators.AttachedPropertySetterGenerator;

public class AttachedPropertyBindFromSignalSetterGenerator : ExtensionGeneratorBase<AttachedPropertyExtensionInfo>
{
    protected override string? GetExtension(AttachedPropertyExtensionInfo info) =>
        $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, ISignal<{info.ValueTypeSource}> signal, Action<{info.ValueTypeSource}>? onChanged = null)" +
        $" where T : {info.AttachedPropertyHostTypeName} {Environment.NewLine}" +
        $"   => control._set(signal, {info.ControlTypeName}.{info.FieldInfo.Name}!, onChanged);";

}