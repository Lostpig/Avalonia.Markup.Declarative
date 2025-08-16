using System.Collections;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace Mearii.Mvu.Tests.ControlsTests.Controls;
public class ColorPalette : MvuComponent
{
    #region AvaloniaProperties
    private CollectionSignal<Color> _colors = new([]);
    public ICollection<Color> Colors
    {
        get => _colors.Value;
        set => _colors.Set([..value]);
    }

    private Signal<Color> _colorToAdd = new(Color.FromArgb(0,0,0,0));
    public Color ColorToAdd
    {
        get => _colorToAdd.Value;
        set => _colorToAdd.Set(value);
    }

    private Signal<bool> _canAddColor = new(false);
    public bool CanAddColor
    {
        get => _canAddColor.Value;
        set => _canAddColor.Set(value);
    }
    #endregion

    public event Action<Color>? ColorSelected;
    public event Action<Color>? ColorAdded;
    public event Action<Color>? ColorRemoved;

    protected override object Build() =>
        new Grid()
            .Children(
                new ItemsControl()
                    .Ref(out _itemsControl)
                    .ItemsSource(Colors)
                    .ItemTemplate(new FuncDataTemplate<Color>((itemVm, _) =>
                            itemVm == Color.FromArgb(0, 0, 0, 0)
                                ? new Button() //ADD COLOR BUTTON
                                    .OnClick(OnAddColorClicked)
                                    .Margin(6)
                                    .Width(32)
                                    .Height(32)
                                    .CornerRadius(32)
                                    .Content("+")
                                : new Button() // COLOR ITEM
                                    .Background(itemVm.ToBrush())
                                    .BorderThickness(1)
                                    .OnClick(_ => OnColorItemClicked(itemVm))
                                    .Width(32)
                                    .Height(32)
                                    .CornerRadius(32)
                                    .Margin(6)
                                    .ContextFlyout(
                                        new MenuFlyout()
                                            .Placement(PlacementMode.Bottom)
                                            .ItemsSource(new[]{
                                                new MenuItem()
                                                    .Header("Delete color")
                                                    .OnClick(_ => ColorRemoved?.Invoke(itemVm))
                                            })
                                    )
                        )
                    )

            );

    private ItemsControl _itemsControl = null!;

    private IList<Color>? _sourceColorsCollection;

    private void OnAddColorClicked(RoutedEventArgs obj) => ColorAdded?.Invoke(ColorToAdd);

    private void OnColorItemClicked(Color newColor) => ColorSelected?.Invoke(newColor);
}