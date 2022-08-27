using System.Windows;

using Microsoft.Extensions.DependencyInjection;

using MudBlazor.Services;

using RazoribraryTest;
using RazoribraryTest.Data;
using RazoribraryTest.Service;

using WpfAppTest.Service;

namespace WpfAppTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var r = new Microsoft.AspNetCore.Components.WebView.Wpf.RootComponent();
            r.Selector = "#app";
            r.ComponentType = typeof(Main);
            blazorWebView1.RootComponents.Add(r);

            var services = new ServiceCollection();
            services.AddWpfBlazorWebView();
            services.AddMudServices();
            services.AddSingleton<WeatherForecastService>();
            services.AddSingleton<IPlatformsService>(new PlatformsService());
            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = services.BuildServiceProvider();



        }
    }
}
