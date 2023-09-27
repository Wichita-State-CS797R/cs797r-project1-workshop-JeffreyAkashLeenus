namespace MonkeyFinder.View;
using System.Net.Http.Json;


public partial class MainPage : ContentPage
{
    public MainPage(MonkeysViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}

