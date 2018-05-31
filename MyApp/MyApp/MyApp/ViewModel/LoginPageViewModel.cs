using System;
using System.Collections.Generic;
using System.Text;
using MyApp.DbContext;
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
            DoLogin = new Command(DoLoginoperation);
            login = new AppLogin();
        }

        private void DoLoginoperation()
        {
            if (login.Email != null)
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
                    //logca para mandar error
                }
            }
            else
            {
                //logca para mandar error
            }
        }
    }
}
