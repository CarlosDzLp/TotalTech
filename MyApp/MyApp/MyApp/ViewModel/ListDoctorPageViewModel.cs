using System;
using System.Collections.Generic;
using System.Text;
using MyApp.DbContext;
using MyApp.View;
using Xamarin.Forms;

namespace MyApp.ViewModel
{
    public class ListDoctorPageViewModel
    {
        public Command logOut { get; set; }
        public Command Itemselected { get; set; }
        public ListDoctorPageViewModel()
        {
            logOut = new Command(DoLogOut);
            Itemselected = new Command(ItemSelectedClick);
        }

        
        private void ItemSelectedClick()
        {
            App.Current.MainPage.Navigation.PushAsync(new DetailDoctorPage());
        }

        private async void DoLogOut()
        {
            DbMyApp db = new DbMyApp();
            var result = await db.DeleteLogin();
            App.Current.MainPage = new LoginPage();
        }
    }
}
