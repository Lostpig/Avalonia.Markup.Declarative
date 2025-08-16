using Mearii.AvaloniaExtensionGenerator.ExtensionInfos;

namespace Mearii.AvaloniaExtensionGenerator.Generators.SetterGenerators;

public class BindFromSignalSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info) =>
        $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, ISignal<{info.ValueTypeSource}> signal, Action<{info.ValueTypeSource}>? onChanged = null) {info.GenericConstraint} {Environment.NewLine}" +
        $"   => control._set(signal, {info.ControlTypeName}.{info.FieldInfo.Name}!, onChanged);";

}
