using Mearii.Mvu;

namespace AvaloniaMarkupSample.MvvmSample;

public class MvvmSampleView : MvuComponent
{
    MvvmSampleViewModel vm = new();
    protected override object Build() =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Text(() => vm?.MyObject.MyProperty ?? ""),

                new Button()
                    .Content("Execute Command")
                    .OnClick(args => vm.MyCommand(vm))
            );
}