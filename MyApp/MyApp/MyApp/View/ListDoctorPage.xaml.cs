using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListDoctorPage : ContentPage
	{
        private class lista
        {
            public string url { get; set; }
            public string nombre { get; set; }
            public string correo { get; set; }
            public string direccion { get; set; }
            public string estrella { get; set; }
        }

	    private void getlist()
	    {
	        ObservableCollection<lista> listas = new ObservableCollection<lista>();
            listas.Add(new lista
            {
                url = "https://randomuser.me/api/portraits/women/34.jpg",
                nombre = "carlos",
                correo = "ryankar90@hotmail.com",
                direccion="conocido esta cerca",
                estrella = "4.5"
            });
	        listas.Add(new lista
	        {
	            url = "https://randomuser.me/api/portraits/women/34.jpg",
	            nombre = "carlos",
	            correo = "ryankar90@hotmail.com",
	            direccion="conocido esta cerca",
	            estrella = "4.5"
	        });
	        listas.Add(new lista
	        {
	            url = "https://randomuser.me/api/portraits/women/34.jpg",
	            nombre = "carlos",
	            correo = "ryankar90@hotmail.com",
	            direccion="conocido esta cerca",
	            estrella = "4.5"
	        });
	        listas.Add(new lista
	        {
	            url = "https://randomuser.me/api/portraits/women/34.jpg",
	            nombre = "carlos",
	            correo = "ryankar90@hotmail.com",
	            direccion="conocido esta cerca",
	            estrella = "4.5"
	        });
	        listas.Add(new lista
	        {
	            url = "https://randomuser.me/api/portraits/women/34.jpg",
	            nombre = "carlos",
	            correo = "ryankar90@hotmail.com",
	            direccion="conocido esta cerca",
	            estrella = "4.5"
	        });
	        listas.Add(new lista
	        {
	            url = "https://randomuser.me/api/portraits/women/34.jpg",
	            nombre = "carlos",
	            correo = "ryankar90@hotmail.com",
	            direccion="conocido esta cerca",
	            estrella = "4.5"
	        });
	        ListMen.ItemsSource = listas;
	    }
		public ListDoctorPage ()
		{
			InitializeComponent ();
		    getlist();
		    this.BindingContext = new ListDoctorPageViewModel();
		}
	}
}