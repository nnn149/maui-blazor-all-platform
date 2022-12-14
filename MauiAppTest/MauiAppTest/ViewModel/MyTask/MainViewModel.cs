using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using MauiAppTest.View.MyTask;

//https://github.com/dotnet/maui-samples/tree/main/6.0/Beginners-Series
//https://www.bilibili.com/video/BV1fF411c7xf

namespace MauiAppTest.ViewModel.MyTask
{
    public partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<string> Items { get; } = new();

        IConnectivity connectivity;

        [ObservableProperty]
        string _text;

        [ObservableProperty]
        bool _isLoading = false;

        [ObservableProperty]
        bool _isRefreshing = false;

        public MainViewModel(IConnectivity connectivity)
        {

            this.connectivity = connectivity;
        }

        [RelayCommand]
        async void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                return;
            }

            if (connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("警告:", "无网络连接", "确定");
                return;
            }

            Items.Add(Text);
            Text = string.Empty;
        }

        [RelayCommand]
        void Del(string s)
        {
            if (Items.Contains(s))
            {
                Items.Remove(s);
            }
        }
        [RelayCommand]
        async Task Tap(string str)
        {
            IsLoading = true;
            await Task.Delay(2500);
            await Shell.Current.GoToAsync($"mytask/{nameof(DetailPage)}?Text={str}");
            IsLoading = false;
        }

        [RelayCommand]
        async Task GetNewItems()
        {
            IsRefreshing = true;
            await Task.Delay(2500);
            Items.Add(DateTime.Now.ToString("G"));
            IsRefreshing = false;
        }
    }


}
