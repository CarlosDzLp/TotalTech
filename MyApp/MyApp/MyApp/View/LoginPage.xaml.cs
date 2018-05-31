﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		    this.BindingContext = new LoginPageViewModel();
		}
	}
}