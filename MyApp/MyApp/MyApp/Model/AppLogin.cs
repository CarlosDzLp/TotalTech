using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using MyApp.Annotations;

namespace MyApp.Model
{
    public class AppLogin : BaseModel
    {
        private string _email;
        private string _password;

        public string Email
        {
            get { return _email; }
            set { SetValue(ref _email, value); }
        }

        public string Password
        {
            get { return _password; }
            set { SetValue(ref _password, value); }
        }
    }
}
