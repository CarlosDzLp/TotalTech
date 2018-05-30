using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MyApp.Droid.Helper;
using MyApp.Helper;
using Xamarin.Forms;

[assembly:Dependency(typeof(FilePath))]
namespace MyApp.Droid.Helper
{
    public class FilePath : IGetPath
    {
        public string getPath()
        {
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return System.IO.Path.Combine(path, "MyApp.db3");
        }
    }
}