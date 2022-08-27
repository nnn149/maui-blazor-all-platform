using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiAppTest.ViewModel.MyTask
{
    [QueryProperty(nameof(Text), "Text")]
    public partial class DetailViewModel : ObservableObject
    {
        [ObservableProperty]
        string _text;

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
