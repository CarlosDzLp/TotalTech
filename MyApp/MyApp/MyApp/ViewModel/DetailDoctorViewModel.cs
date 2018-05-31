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
        public DetailDoctorViewModel(CollectionDoctor collection)
        {
            collectionDoctor = new CollectionDoctor();
            collectionDoctor = collection;
            Logout = new Command(DoLogout);
        }

        private async void DoLogout()
        {
            DbMyApp db = new DbMyApp();
            var result = await db.DeleteLogin();
            App.Current.MainPage = new LoginPage();
        }
    }
}
