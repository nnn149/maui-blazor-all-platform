using MauiAppTest.View.MyTask;

namespace MauiAppTest;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute($"mytask/{nameof(DetailPage)}", typeof(DetailPage));
    }
}
