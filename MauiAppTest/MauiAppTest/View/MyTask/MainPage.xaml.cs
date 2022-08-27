using MauiAppTest.ViewModel.MyTask;

namespace MauiAppTest.View.MyTask;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel mainViewModel)
    {
        InitializeComponent();
        BindingContext = mainViewModel;
    }
}