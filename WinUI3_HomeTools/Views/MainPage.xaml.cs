using Microsoft.UI.Xaml.Controls;

using WinUI3_HomeTools.ViewModels;

namespace WinUI3_HomeTools.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
