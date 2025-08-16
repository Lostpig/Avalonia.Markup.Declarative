using Mearii.AvaloniaExtensionGenerator.ExtensionInfos;
using Mearii.AvaloniaExtensionGenerator.Generators;

namespace Mearii.AvaloniaExtensionGenerator.Generators.SetterGenerators;

public class BindFromFuncSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info) =>
        $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, Func<{info.ValueTypeSource}> func, Action<{info.ValueTypeSource}>? onChanged = null) {info.GenericConstraint} {Environment.NewLine}" +
        $"   => control._set(func, {info.ControlTypeName}.{info.FieldInfo.Name}!, onChanged);";

}