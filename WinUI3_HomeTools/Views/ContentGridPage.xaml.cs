using Microsoft.UI.Xaml.Controls;

using WinUI3_HomeTools.ViewModels;

namespace WinUI3_HomeTools.Views;

public sealed partial class ContentGridPage : Page
{
    public ContentGridViewModel ViewModel
    {
        get;
    }

    public ContentGridPage()
    {
        ViewModel = App.GetService<ContentGridViewModel>();
        InitializeComponent();
    }
}
