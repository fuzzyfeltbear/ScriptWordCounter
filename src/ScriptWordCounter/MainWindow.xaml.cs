using System.Windows;

namespace ScriptWordCounter;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private DocumentViewModel viewModel;

    public MainWindow()
    {
        viewModel = new DocumentViewModel();
        DataContext = viewModel;
        InitializeComponent();
    }
}