using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MyApp.Model.ModelService
{
    public class Location
    {
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int postcode { get; set; }
    }
}
