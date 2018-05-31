using System;
using MyApp.DbContext;
using MyApp.Helper;
using MyApp.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace MyApp
{
	public partial class App : Application
	{
	    public App()
	    {
	        InitializeComponent();
	        DbMyApp db = new DbMyApp();
	        var result = db.getLogin();
	        if (result > 0)
	        {
	            MainPage = getNavigation(new ListDoctorPage());
	        }
	        else
	        {
	            MainPage = new View.LoginPage();
	        }
	    }

	    public static Page getNavigation(Page page)
	    {
	        var result = new NavigationPage(page);
	        result.BarBackgroundColor = Color.FromHex("#00DC45");
	        result.BarTextColor = Color.White;
	        return result;
	    }
	    protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
