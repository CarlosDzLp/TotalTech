using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using MyApp.Helper;
using MyApp.iOS.Helper;
using UIKit;
using Xamarin.Forms;

[assembly:Dependency(typeof(FilePath))]
namespace MyApp.iOS.Helper
{
    public class FilePath : IGetPath
    {
        public string getPath()
        {
            try
            {
                string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

                if (!Directory.Exists(libFolder))
                {
                    Directory.CreateDirectory(libFolder);
                }

                return Path.Combine(libFolder, "MyApp.db3");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}