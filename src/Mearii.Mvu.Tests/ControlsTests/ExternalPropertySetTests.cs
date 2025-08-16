using Avalonia.Controls;
using Avalonia.Threading;
using Xunit.Abstractions;

namespace Mearii.Mvu.Tests.ControlsTests;

public class SliderWithLabel : MvuComponent
{
    protected override object Build() =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Ref(out _labelTextBlock)
                    .Text(_label),

                new Slider()
                    .Ref(out _slider)
                    .Value(_value, _value.Set)
            );

    private TextBlock _labelTextBlock = null!;
    private Slider _slider = null!;

    private Signal<double> _value = new(0.0);
    public double Value
    {
        get => _value.Value;
        set => _value.Set(value);
    }
    public Signal<string> _label = new("");
    public string Label
    {
        get => _label.Value;
        set => _label.Set(value);
    }

    public string GetRealLabelValue() => _labelTextBlock.Text ?? "Not set";

    public void ChangeSliderValue(double value)
    {
        _slider.Value = value;
    }
}
public class ExternalPropertySetTestView : MvuComponent
{
    protected override object Build() => new SliderWithLabel()
        .Ref(out SliderWithLabel)
        .Label(() => "Hello world") // Initial label value with lazy evaluation
        .Value(() => Value, v => Value = v);


    public SliderWithLabel SliderWithLabel = null!;
    public double Value { get; set; } = 1;

    public string? GetRealLabelValue() => SliderWithLabel.GetRealLabelValue();

    protected override void OnAfterInitialized()
    {
        base.OnAfterInitialized();
    }
}

public class ExternalPropertySetTest(ITestOutputHelper testOutputHelper) : AvaloniaTestBase
{
    [Fact]
    public void ExternalPropertySetTestView_ExpressionBinding_Applied_AfterCreation()
    {
        var view = new ExternalPropertySetTestView();

        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        var realLabelValue = view.GetRealLabelValue();
        Assert.Equal("Hello world", realLabelValue);
    }

    [Fact]
    public void ExternalPropertySetTestView_InnerValueChangePoppedToParentComponent()
    {
        var view = new ExternalPropertySetTestView();

        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        Assert.Equal(1, view.Value);

        var expectedValue = 50;
        view.SliderWithLabel.ChangeSliderValue(expectedValue);

        var realValue = view.Value;
        Assert.Equal(expectedValue, realValue);
    }

    [Fact]
    public void ExternalPropertySetTestView_BindPropertyChangeInnerValue()
    {
        var view = new ExternalPropertySetTestView();

        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        var expectedValue = 100;
        view.Value = expectedValue;

        var realParentValue = view.Value;
        var realInnerValue = view.SliderWithLabel.Value;
        Assert.Equal(expectedValue, realParentValue);
        Assert.Equal(expectedValue, realInnerValue);
    }

}