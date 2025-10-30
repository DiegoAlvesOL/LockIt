using System;
using System.ComponentModel;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace LockIt.GUI;

public partial class MainWindow : Window, INotifyPropertyChanged
{
    private string _passwordDisplay;

    public string PasswordDisplay
    {
        get => _passwordDisplay;
        set
        {
            if (_passwordDisplay != value)
            {
                _passwordDisplay = value;
                OnPropertyChanged(nameof(PasswordDisplay));
            }
        }
    }
    /// <summary>
    /// Construtor da janela principal
    /// </summary>
    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;
        
        PasswordDisplay = "Your password will appear here";
    }
    
    /// <summary>
    /// Evento necesssário para o Binding funcionar corretamente.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    
    /// <summary>
    /// Evento do botão Copy
    /// </summary>
    private void OnCopyClicked(object? sender, RoutedEventArgs eventButtonCopy)
    {
        Console.WriteLine("Copy button clicked!");
    }
    /// <summary>
    /// Evento do botão Reload
    /// </summary>
    private void OnReloadClicked(object? sender, RoutedEventArgs eventButtonReload)
    {
        Console.WriteLine("Reload button clicked!");
        PasswordDisplay = "NewPassword#123";
        DataContext = null;
        DataContext = this;
    }
    
    /// <summary>
    /// Evento do botão Save
    /// </summary>
    private void OnSaveClicked(object? sender, RoutedEventArgs eventButtonSave)
    {
        Console.WriteLine("Save button clicked!");
    }

    private string GeneratePassword(int length)
    {
        
    }
}