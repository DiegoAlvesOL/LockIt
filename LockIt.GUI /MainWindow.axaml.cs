using Avalonia.Controls;
using Avalonia.Interactivity;

namespace LockIt.GUI;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnGenerateClicked(object? sender, RoutedEventArgs eventButtonGenerate)
    {
        var generatorWindow = new Window()
        {
            Width = 300,
            Height = 150,
            Title = "Password Generator",
            Content = new TextBlock
            {
                Text = "Aqui será gerada sua senha",
                HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
            }
        };
        generatorWindow.Show();
    }

    private void OnListClicked(object? sender, RoutedEventArgs eventButtonList)
    {
        var listWindow = new Window()
        {
            Width = 300,
            Height = 150,
            Title = "List of Passwords",
            Content = new TextBlock()
            {
                Text = "Sua lista de password",
                HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
            }
        };
        listWindow.Show();
    }
}