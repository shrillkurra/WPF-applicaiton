using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISTEpage.Models;
using System.Net.Http;

namespace ISTEpage.Services
{
    public class MinorsDataService
    {
        public Minors initializeMinors()
        {
            Minors minors = new Minors();
            try
            {
                using (var client = new HttpClient())
                {
                    string uri = $"http://ist.rit.edu/api/minors";
                    var response = client.GetAsync(uri).Result;
                    var content = response.Content.ReadAsStringAsync().Result;
                    dynamic item = Newtonsoft.Json.JsonConvert.DeserializeObject(content);

                    var minor_resp = item.UgMinors;
                    foreach (var single_minor in minor_resp)
                    {
                        UgMinor ugm = new UgMinor();
                        ugm.name = single_minor.name;
                        ugm.title = single_minor.title;
                        ugm.description = single_minor.description;
                        ugm.note = single_minor.note;
                        var minors_courses = single_minor.courses;
                        List<String> courses = new List<string>();
                        foreach (var course in minors_courses)
                        {
                            courses.Add(course.Value);
                        }
                        ugm.courses = courses;
                        minors.UgMinors.Add(ugm);
                    }
                }
                    return minors;
            }
            catch (Exception exx)
            { return null; }
        }
    }
}
