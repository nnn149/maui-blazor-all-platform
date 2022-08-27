using MauiAppTest.Service;

using Microsoft.Extensions.DependencyInjection;

using MudBlazor.Services;

using RazoribraryTest.Data;
using RazoribraryTest.Service;

namespace MauiAppTest;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddMauiBlazorWebView();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif
        //mud 控件库所需
        builder.Services.AddMudServices();

        //系统组件注入
        //https://docs.microsoft.com/zh-cn/dotnet/maui/platform-integration/communication/networking
        builder.Services.AddSingleton(Connectivity.Current);

        //自定义Service
        builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services.AddSingleton<IPlatformsService>(new PlatformsService());


        //设置ViewModel，用于构造函数依赖注入
        builder.Services.AddSingleton<View.MyTask.MainPage>();
        builder.Services.AddSingleton<ViewModel.MyTask.MainViewModel>();

        builder.Services.AddTransient<View.MyTask.DetailPage>();
        builder.Services.AddTransient<ViewModel.MyTask.DetailViewModel>();

        return builder.Build();
    }
}
