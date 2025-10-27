using Avalonia.Controls;
using Avalonia.Interactivity;

namespace LockIt.GUI;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnHelloClicked(object? sender, RoutedEventArgs eventButton)
    {
        var messageBox = new Window
        {
            Width = 220,
            Height = 120,
            Title = "Hello",
            Content = new TextBox
            {
                Text = "Hello, Diego seu lindo",
                VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
                HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
            }
        };
        messageBox.Show();
    }
}