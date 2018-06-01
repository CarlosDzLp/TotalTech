using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.DbContext;
using MyApp.Entities;
using MyApp.Helper;
using MyApp.Model;
using MyApp.Services;
using MyApp.View;
using Plugin.Connectivity;
using Xamarin.Forms;

namespace MyApp.ViewModel
{
    public class ListDoctorPageViewModel : BaseModel
    {
        private CollectionDoctor _collection;

        public CollectionDoctor ItemCollection
        {
            get { return _collection; }
            set { SetValue(ref _collection, value); }
        }
        public List<CollectionDoctor> collectiondoctor { get; set; }
        public Command logOut { get; set; }
        public Command Itemselected { get; set; }
        private DbMyApp db;

        public ListDoctorPageViewModel()
        {
            try
            {
                db = new DbMyApp();
                logOut = new Command(DoLogOut);
                Itemselected = new Command(ItemSelectedClick);
                getAllDoctor();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        
        private void ItemSelectedClick()
        {
            try
            {
                App.Current.MainPage.Navigation.PushAsync(new DetailDoctorPage(ItemCollection));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private async void DoLogOut()
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

        private async void getAllDoctor()
        {
            try
            {
                var result = await db.GetAlldoctor();
                collectiondoctor = result.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
