using Avalonia.Controls;
using Avalonia.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FluentAssertions;

namespace Mearii.Mvu.Tests.BindingTests;

public class ExpressionBindingTestView : MvuComponent
{
    protected override object Build() =>
        new StackPanel().Children(
            new ToggleSwitch()
                .OnContent("Erase mode: On")
                .OffContent("Erase mode: Off")
                .IsChecked(IsToggleChecked, IsToggleChecked.Set),

            new TextBlock()
                .Ref(out MyTextBlock)
                .Text(() => State.State)
        );

    public TextBlock MyTextBlock = null!;

    public SeparatedViewState State { get; set; } = new();

    private Signal<bool?> IsToggleChecked = new(true);
}

public class SeparatedViewState
{
    private Signal<string> _stateSignal = new("Separate state property");

    public string State
    {
        get => _stateSignal.Get();
        set => _stateSignal.Set(value);
    }
}

public class ExpressionBindingTests : AvaloniaTestBase
{
    [Fact]
    public void TextBlock_Binding_TextShouldBeUpdatedOnStateHasChanged()
    {
        var view = new ExpressionBindingTestView();
        // Attach to visual tree to ensure template is applied
        var window = new Window { Content = view };
        window.Show();
        // Process layout and rendering
        Dispatcher.UIThread.RunJobs();

        var state = view.State;
        state.State = "Updated!";

        var textBlock = view.MyTextBlock;
        Assert.NotNull(textBlock);

        textBlock.Text.Should().Be("Updated!");
    }

    [Fact]
    public void TextBlock_Binding_TextShouldBeUpdatedOnPropertyChanged()
    {
        var view = new ExpressionBindingTestView();
        // Attach to visual tree to ensure template is applied
        var window = new Window { Content = view };
        window.Show();
        // Process layout and rendering
        Dispatcher.UIThread.RunJobs();

        var state = view.State;
        state.State = "Notified!";

        var textBlock = view.MyTextBlock;
        Assert.NotNull(textBlock);

        textBlock.Text.Should().Be("Notified!");
    }

}