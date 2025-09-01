using Mearii.Mvu;

namespace AvaloniaMarkupSample.MvuSample;

public class Component : MvuComponent
{
    protected override object Build() =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Text("This is nested MVU Component"),

                new TextBlock()
                    .Text(() => InnerContent),

                new Button()
                    .Content("Change border to yellow")
                    .OnClick(args =>
                    {
                        InnerContent = "Button clicked!";
                        ButtonClicked?.Invoke();
                    })

            );

    public event Action? ButtonClicked; 
    public event EventHandler? Button1Clicked;
    public event EventHandler<bool>? Button2Clicked;
    public event Action<int>? Button3Clicked;

    private readonly Signal<string> _innerContent = new ("Parameter value");
    public string InnerContent 
    { 
        get => _innerContent.Get(); 
        set => _innerContent.Set(value); 
    } 
}