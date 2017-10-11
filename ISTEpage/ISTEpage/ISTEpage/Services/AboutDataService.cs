using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISTEpage.Models;
using System.Net.Http;

namespace ISTEpage.Services
{
    public class AboutDataService
    {
        public About GetItemDetails()
        {
            About invItem = new About();
            try
            {
                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Add("X-API-Key", "9ef8ddfc6d254dc3a7b2cac337c6d837");
                    string uri = $"http://ist.rit.edu/api/about";
                    //client.DefaultRequestHeaders.Add("X-API-Key", "9ef8ddfc6d254dc3a7b2cac337c6d837");
                    var response = client.GetAsync(uri).Result;
                    var content = response.Content.ReadAsStringAsync().Result;
                    dynamic item = Newtonsoft.Json.JsonConvert.DeserializeObject(content);

                    var retItem = item;
                    invItem.title = retItem.title;
                    invItem.description = retItem.description;
                    invItem.quote = retItem.quote;
                    invItem.quoteAuthor = retItem.quoteAuthor;
                }
            }
            catch (System.Exception ex)
            {
                return invItem;
            }
            return invItem;
        }
    }
}
