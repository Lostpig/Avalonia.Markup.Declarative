using Avalonia.Controls.Templates;
using Mearii.Mvu;

public static class StaticResources
{
    public static class Templates
    {
        public static IControlTemplate MyControlTemplate { get; } = new FuncControlTemplate<MyCustomTemplatedControl>(
            // Using FuncView to generate ViewContext that will be used for binding
            (control, scope) => new FuncComponent(() =>
                new Grid()
                    .Rows("Auto, Auto, *, Auto")
                    .Children(
                        new StackPanel()
                            .Orientation(Orientation.Horizontal)
                            .VerticalAlignment(VerticalAlignment.Center)
                            .Children(
                                new TextBlock().Text("Enter text:")
                                    .VerticalAlignment(VerticalAlignment.Center),
                                new TextBox()
                                    .Text(() => control.NewValue ?? "", v => control.NewValue = v)
                                    .MinWidth(150)
                            ),
                        new StackPanel().Row(1)
                            .Margin(0, 10)
                            .Orientation(Orientation.Horizontal)
                            .VerticalAlignment(VerticalAlignment.Center)
                            .HorizontalAlignment(HorizontalAlignment.Left)
                            .Children(
                                new TextBlock().Text("Saved text:")
                                    .VerticalAlignment(VerticalAlignment.Center),
                                new TextBox()
                                    .Text(() => control.SavedValue ?? "", v => control.SavedValue = v)
                                    .MinWidth(150)
                            ),
                        new StackPanel().Row(3)
                            .Orientation(Orientation.Horizontal)
                            .HorizontalAlignment(HorizontalAlignment.Right)
                            .Children(
                                new Button().Content("Cancel")
                                    .Margin(5, 0)
                                    .IsEnabled(() => control.CanSave)
                                    .OnClick(_ => control.Cancel()),
                                new Button().Content("Save")
                                    .Margin(5, 0)
                                    .IsEnabled(() => control.CanSave)
                                    .OnClick(_ => control.Save())
                            )
                    ))
            );

        public static IControlTemplate MyAnotherControlTemplate { get; } =
            new FuncControlTemplate<MyCustomTemplatedControl>((control, scope) =>
                // Using FuncView to generate ViewContext that will be used for binding
                new FuncComponent(() =>
                    new StackPanel()
                        .Children(
                            new StackPanel()
                                .Orientation(Orientation.Horizontal)
                                .VerticalAlignment(VerticalAlignment.Center)
                                .Children(
                                    new TextBlock()
                                        .Text(() => $"Entered text: {control.NewValue}")
                                        .MinWidth(150)
                                ),
                            new StackPanel()
                                .Margin(0, 10)
                                .Orientation(Orientation.Horizontal)
                                .VerticalAlignment(VerticalAlignment.Center)
                                .HorizontalAlignment(HorizontalAlignment.Left)
                                .Children(
                                    new TextBlock()
                                        .Text(() => $"Saved text: {control.SavedValue}")
                                        .MinWidth(150)
                                )
                        ))
            );
    }
}