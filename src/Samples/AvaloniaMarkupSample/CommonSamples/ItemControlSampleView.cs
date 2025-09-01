using Mearii.Mvu;

namespace AvaloniaMarkupSample.CommonSamples;

public class ItemControlSampleView : MvuComponent
{
    protected override object Build() =>
        new StackPanel()
            .Children(
                new ListBox()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .ItemsSource(() => Items.Value)
                    .ItemTemplate<string>(item =>
                         new TextBlock()
                         {
                             Background = Brushes.Beige,
                            Text = item
                         }
                    )
                    .SelectedItem(() => SelectedItem, v => SelectedItem = (string)v),

                new TextBlock()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .Text(() => SelectedItem)
                
                //,
                //new TextBlock()
                //    .HorizontalAlignment(HorizontalAlignment.Center)
                //    .Text(Items2.Count.ToString())
            );

    private readonly Signal<string> _selectedItem = new("one");
    public string SelectedItem
    {
        get => _selectedItem.Get();
        set => _selectedItem.Set(value);
    }

    public List<string> Items2 { get; set; } = null!;

    public CollectionSignal<string> Items  = new(
    [
        "one",
        "two",
        "four"
    ]);
}