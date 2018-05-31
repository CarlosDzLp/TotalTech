using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MyApp.Model.ModelService;
using Newtonsoft.Json;

namespace MyApp.Services
{
    public class ApiService
    {
        public async Task<Listdoctor> getService()
        {
            try
            {
                bool contador = false;
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://randomuser.me/");
                string Url =
                    string.Format("api/?results=5");
                var response = await client.GetAsync(Url);
                var result = response.Content.ReadAsStringAsync().Result;
                var deserializeObject = JsonConvert.DeserializeObject<Listdoctor>(result);
                if (deserializeObject!=null)
                {

                    return deserializeObject;
                }
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
