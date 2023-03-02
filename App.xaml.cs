namespace Appus;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Pages.WebViewPage();
	}
}
