using Microsoft.UI.Xaml.Controls;

using WinUI3_HomeTools.ViewModels;

namespace WinUI3_HomeTools.Views;

public sealed partial class DownloadPage : Page
{
    public DownloadViewModel ViewModel
    {
        get;
    }

    public DownloadPage()
    {
        ViewModel = App.GetService<DownloadViewModel>();
        InitializeComponent();
    }
}
