using MauiAppTest.ViewModel.MyTask;

namespace MauiAppTest.View.MyTask;

public partial class DetailPage : ContentPage
{
    public DetailPage(DetailViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}