using System;
using System.Threading.Tasks;
using MyApp.DbContext;
using MyApp.Entities;
using MyApp.Helper;
using MyApp.Services;
using MyApp.View;
using Plugin.Connectivity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace MyApp
{
	public partial class App : Application
	{
	    DbMyApp db = new DbMyApp();
	    public App()
	    {
	        InitializeComponent();
	        try
	        {
	            getApiService();        
	            var result = db.getLogin();
	            if (result > 0)
	            {
	                MainPage = getNavigation(new ListDoctorPage());
	            }
	            else
	            {
	                MainPage = new LoginPage();
	            }
	        }
	        catch (Exception e)
	        {
	            Console.WriteLine(e);
	            throw;
	        }
	    }
	    private void getApiService()
	    {
	        Task.Run(() =>
	        {
	            try
	            {
	                if (CrossConnectivity.Current.IsConnected)
	                {
	                    if (db.Getcountdoctor().Result == 0)
	                    {
	                        ApiService service = new ApiService();
	                        var resultado = service.getService();
	                        if (resultado.Result != null)
	                        {
	                            foreach (var item in resultado.Result.results)
	                            {
	                                Doctor doctor = new Doctor();
	                                doctor.image = item.picture.large;
	                                doctor.name = item.name.first +" "+ item.name.last;
	                                doctor.email = item.email;
	                                doctor.street = item.location.street;
	                                doctor.state = item.location.state;
	                                doctor.city = item.location.city;
	                                doctor.postcode = item.location.postcode;
	                                doctor.phone = item.phone;
	                                doctor.ranking = Ranking.getRanking().ToString();
	                                db.Insertdoctor(doctor);
	                            }
	                        }
	                    }
	                }
	            }
	            catch (Exception e)
	            {
	                Console.WriteLine(e);
	                throw;
	            }
            });
        }
	    public static Page getNavigation(Page page)
	    {
	        try
	        {
	            var result = new NavigationPage(page);
	            result.BarBackgroundColor = Color.FromHex("#00DC45");
	            result.BarTextColor = Color.White;
	            return result;
	        }
	        catch (Exception e)
	        {
	            Console.WriteLine(e);
	            throw;
	        }
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
