using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISTEpage.Models;
using System.Net.Http;

namespace ISTEpage.Services
{
    public class EmploymentDataService
    {
        public Employment intializeEmploy()
        {
            Employment employ = new Employment();
            try
            {
                using (var client = new HttpClient())
                {
                    string uri = $"http://ist.rit.edu/api/employment/";
                    var response = client.GetAsync(uri).Result;
                    var content = response.Content.ReadAsStringAsync().Result;
                    dynamic item = Newtonsoft.Json.JsonConvert.DeserializeObject(content);

                    var employ_resp = item.introduction;
                    employ.title = employ_resp.title;
                    employ.description0 = employ_resp.content[0].description;
                    employ.description1 = employ_resp.content[1].description;
                    


                }
            }
            catch (Exception exXx)
            { return employ; }
            return employ;
        }
    }
}
