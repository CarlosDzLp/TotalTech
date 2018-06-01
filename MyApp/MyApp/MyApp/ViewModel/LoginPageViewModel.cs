using System;
using System.Collections.Generic;
using System.Text;
using MyApp.DbContext;
using MyApp.Helper;
using MyApp.Model;
using MyApp.View;
using Xamarin.Forms;

namespace MyApp.ViewModel
{
    public class LoginPageViewModel
    {
        public AppLogin login { get; set; }
        public Command DoLogin { get; set; }
        public LoginPageViewModel()
        {
            try
            {
                login = new AppLogin();
                DoLogin = new Command(DoLoginoperation);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }        
        }

        private async void DoLoginoperation()
        {
            try
            {
                if (login.Email != null)
                {
                    if (validateEmail.EntryValidateEmail(login.Email))
                    {
                        if (login.Password != null)
                        {
                            DbMyApp db = new DbMyApp();
                            var result = db.insertLogin();
                            if (result.Result > 0)
                            {
                                App.Current.MainPage = App.getNavigation(new ListDoctorPage());
                            }
                            else
                            {
                                //error al insertar
                            }
                        }
                        else
                        {
                            await App.Current.MainPage.DisplayAlert("Error", "Password vacio", "Ok");
                        }
                    }
                    else
                    {
                        await App.Current.MainPage.DisplayAlert("Error", "Debes escribir un email válido", "Ok");
                    }
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Email vacio", "Ok");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
