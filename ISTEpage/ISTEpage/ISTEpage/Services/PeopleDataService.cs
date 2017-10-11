using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using ISTEpage.Models;

namespace ISTEpage.Services
{
    public class PeopleDataService
    {
        public People GetItemDetails()
        {
            People invItem = new People();
            try
            {
                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Add("X-API-Key", "9ef8ddfc6d254dc3a7b2cac337c6d837");
                    string uri = $"http://ist.rit.edu/api/people";
                    //client.DefaultRequestHeaders.Add("X-API-Key", "9ef8ddfc6d254dc3a7b2cac337c6d837");
                    var response = client.GetAsync(uri).Result;
                    var content = response.Content.ReadAsStringAsync().Result;
                    dynamic item = Newtonsoft.Json.JsonConvert.DeserializeObject(content);

                    var all_faculty = item.faculty;
                    foreach (var single_faculty in all_faculty)
                    {
                        Faculty fc = new Faculty();
                        fc.name = single_faculty.name;
                        fc.imagePath = single_faculty.imagePath;
                        fc.title = single_faculty.imagePath;
                        fc.interestArea = single_faculty.interestArea;
                        fc.phone = single_faculty.phone;
                        fc.email = single_faculty.email;
                    }

                }
            }
            catch (System.Exception exep)
            {
                return invItem;
            }
            return invItem;
        }
    }
}
