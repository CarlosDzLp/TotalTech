using System;
using System.Collections.Generic;
using System.Text;
using MyApp.DbContext;
using MyApp.Model;
using MyApp.View;
using Xamarin.Forms;

namespace MyApp.ViewModel
{
    public class DetailDoctorViewModel
    {
        public CollectionDoctor collectionDoctor { get; set; }
        public Command Logout { get; set; }
        private string urlplace = "https://www.google.com/maps/search/";
        public DetailDoctorViewModel(CollectionDoctor collection)
        {
            try
            {
                var result = collection.street.Replace(' ', '+');
                collectionDoctor = new CollectionDoctor();
                collectionDoctor.ranking = collection.ranking;
                collectionDoctor.street = collection.street;
                collectionDoctor.state = collection.state;
                collectionDoctor.city = collection.city;
                collectionDoctor.postcode = collection.postcode;
                collectionDoctor.phone = collection.phone;
                collectionDoctor.email = collection.email;
                collectionDoctor.name = collection.name;
                collectionDoctor.image = collection.image;
                collectionDoctor.streetFromat = urlplace + result;

                Logout = new Command(DoLogout);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private async void DoLogout()
        {
            try
            {
                DbMyApp db = new DbMyApp();
                var result = await db.DeleteLogin();
                App.Current.MainPage = new LoginPage();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
