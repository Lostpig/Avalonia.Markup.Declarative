using Avalonia.Controls.Primitives;
using Avalonia.Styling;
using Mearii.Mvu;

namespace AvaloniaMarkupSample.MvuSample;

public class SampleMvuView : MvuComponent
{
    protected override StyleGroup BuildStyles() =>
    [
        //general
        new Style<TextBlock>(x => x.Class("beautiful-textblock"))
            .Foreground(Brushes.CornflowerBlue)
            .TextAlignment(TextAlignment.Center)
            .FontSize(22),

            new Style<ScrollViewer>(s => s.OfType<SampleMvuView>().Descendant().OfType<ScrollViewer>())
                .VerticalScrollBarVisibility(ScrollBarVisibility.Disabled)
                .HorizontalScrollBarVisibility(ScrollBarVisibility.Hidden),
    ];


    protected override object Build() =>
        new ScrollViewer()
            .VerticalScrollBarVisibility(ScrollBarVisibility.Hidden)
            .Content(

                new StackPanel()
                    .Children(
                        new TextBlock()
                            .Classes("beautiful-textblock")
                            .TextWrapping(TextWrapping.Wrap)
                            .Name("NamedTextBlock")
                            .Text("NamedTextBlock"),

                        new TextBlock()
                            .Text(() => MyProperty.Value),

                        new TextBlock()
                            .Text(() => State.StateProperty),

                        new Button()
                            .Content(() => MyNotifiedProperty)
                            .OnClick(OnButtonClick),

                        new Button()
                            .Content("Update separate state")
                            .OnClick(OnButton2Click),

                        new Border()
                            .BorderBrush(() => BorderColor.Value)
                            .BorderThickness(3)
                            .Child(
                                new Component()
                                    .InnerContent(() => MvuComponentParam.Value)
                                    .OnButtonClicked(() =>
                                    {
                                        BorderColor.Set(Colors.Yellow.ToBrush());
                                    })
                            ),

                        new Button()
                            .Content("Change nested component parameter")
                            .OnClick(OnButton3Click),


                        new TextBlock()
                            .Text("lambda binding sample")
                            .FontSize(24),
                        new TextBlock()
                            .Text(() => $"Counter: {(Counter.Value == 0 ? "zero" : Counter.Value)}"),
                        new NumericUpDown()
                            .Value(Counter.Get, Counter.Set)

                    )
            );

    private readonly Signal<decimal?> Counter = new(0);

    private readonly Signal<string> _myNotifiedProperty1 = new("Click me");
    public string MyNotifiedProperty
    {
        get => _myNotifiedProperty1.Get();
        set => _myNotifiedProperty1.Set(value);
    }

    public readonly Signal<Brush> BorderColor = new(Colors.Red.ToBrush());
    public readonly Signal<string> MyProperty = new("Hello MVU");

    public readonly SeparatedViewState State = new();

    public readonly Signal<string> MvuComponentParam = new("Hello nested component");

    private void OnButtonClick(RoutedEventArgs args)
    {
        var tb = this.FindControl<TextBlock>("NamedTextBlock");

        MyProperty.Set("Button was clicked!");
        MyNotifiedProperty = "You clicked me!";
    }
    private void OnButton2Click(RoutedEventArgs obj)
    {
        State.StateProperty = "Value changed!";
    }

    private void OnButton3Click(RoutedEventArgs obj)
    {
        MvuComponentParam.Set("I changed from external view!");
        BorderColor.Set(Colors.Green.ToBrush());
    }
}