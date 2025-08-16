using Avalonia.Controls;
using Avalonia.Threading;
using Mearii.Mvu;
using System.Collections.ObjectModel;
using Xunit.Abstractions;
using Color = Avalonia.Media.Color;
using Mearii.Mvu.Tests.ControlsTests.Controls;

namespace Mearii.Mvu.Tests.ControlsTests;

public class ColorPickerView : MvuComponent
{
    protected override object Build() =>
        new TabControl()
            .SelectedIndex(() => ColorTypeIndex, v => ColorTypeIndex = v)
            .Items(
                new TabItem() //PALETTE EDITOR
                    .Content(
                        new ColorPalette().Row(1)
                            .Colors(() => Colors)
                            .OnColorSelected(c =>
                            {
                                SelectedColor = c;
                            })
                    ),

                new TabItem() //HEX EDITOR
                    .Content(
                        new TextBox().Text(_hexValue)
                    )
            );
    protected override void OnCreated()
    {
        base.OnCreated();
        _hexValue = new(() => ColorToHex(SelectedColor));
    }

    private List<Color> Colors { get; set; } = [];

    private Signal<Color?> _selectedColor = new(null);
    public Color? SelectedColor { get => _selectedColor.Value; set => _selectedColor.Set(value); }

    private ComputedSignal<string> _hexValue;
    public string HexValue => _hexValue.Value;

    private static string ColorToHex(Color? color)
    {
        if (color == null)
            return "#00000000"; // Default to transparent if color is null
        return $"#{color.Value.A:X2}{color.Value.R:X2}{color.Value.G:X2}{color.Value.B:X2}";
    }

    public ColorPickerColorType ColorType { get; set; }
    public int ColorTypeIndex
    {
        get => (int)ColorType;
        set
        {
            ColorType = (ColorPickerColorType)value;
        }
    }

    public enum ColorPickerColorType : byte
    {
        Hex = 1,
        Hsv = 2,
        Rgb = 3,
    }
}

public class NestedComponentStateTest(ITestOutputHelper testOutputHelper) : AvaloniaTestBase
{
    [Fact]
    public async Task ColorPickerView_BindingStateChanges_PreventInfiniteRecursion()
    {
        var view = new ColorPickerView();
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        view.SelectedColor = Color.FromArgb(255, 255, 255, 0);
        view.SelectedColor = Color.FromArgb(255, 255, 0, 255);
        view.SelectedColor = Color.FromArgb(255, 255, 0, 0);

        //Should not throw exceptions after run

        var viewHexValue = view.HexValue;
        testOutputHelper.WriteLine($"Hex value: {viewHexValue}");
        Assert.Equal("#FFFF0000", viewHexValue);
    }
}