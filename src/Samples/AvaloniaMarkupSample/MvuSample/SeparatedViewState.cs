using Mearii.Mvu;

namespace AvaloniaMarkupSample.MvuSample;

public class SeparatedViewState
{
    private Signal<string> _stateProperty = new("Separate state property");

    public string StateProperty
    {
        get => _stateProperty.Get();
        set => _stateProperty.Set(value);
    }
}