using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Model;
using MyApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailDoctorPage : ContentPage
	{
		public DetailDoctorPage (CollectionDoctor collection)
		{
			InitializeComponent ();
		    this.BindingContext = new DetailDoctorViewModel(collection);
		}
	}
}