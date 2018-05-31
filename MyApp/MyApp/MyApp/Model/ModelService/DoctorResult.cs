using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MyApp.Model.ModelService
{
    public class DoctorResult
    {
        public Name name { get; set; }
        public Location location { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string cell { get; set; }
        public Picture picture { get; set; }
    }
}
