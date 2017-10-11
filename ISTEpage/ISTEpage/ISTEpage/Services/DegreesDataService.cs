using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using ISTEpage.Models;

namespace ISTEpage.Services
{
    public class DegreesDataService
    {
        public Degrees initializedegrees()
        {
            Degrees degrees = new Degrees();
            try
            {
                using (var client = new HttpClient())
                {
                    string uri = $"http://ist.rit.edu/api/degrees";
                    var response = client.GetAsync(uri).Result;
                    var content = response.Content.ReadAsStringAsync().Result;
                    dynamic item = Newtonsoft.Json.JsonConvert.DeserializeObject(content);

                    //var retItem = item.undergraduate;
                    //undergrad.undergraduate.title = retItem.undergraduate[index].title;
                    //undergrad.Text = retItem.undergraduate[index].description;

                    var undergrad_resp = item.undergraduate; //List of undergrads
                    foreach (var single_undergrad in undergrad_resp)
                    {
                        Undergraduate ug = new Undergraduate();
                        ug.degreeName = single_undergrad.degreeName;
                        ug.title = single_undergrad.title;
                        ug.description = single_undergrad.description;

                        //ug.concentrations = single_undergrad.concentrations;
                        var undergrad_concentrations = single_undergrad.concentrations;//list of concentrations
                        List<String> concentrations = new List<string>();
                        foreach (var concen in undergrad_concentrations)
                        {
                            concentrations.Add(concen.Value);
                        }
                        ug.concentrations = concentrations;
                        degrees.undergradute.Add(ug);
                    }

                   


                    return degrees;
                }
            }catch(Exception e)
            {
                return null;
            }
        }
    }
}
