using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISTEpage.Models;
using System.Net.Http;

namespace ISTEpage.Services
{
    public class DegreeGradDataService
    {
        public DegreeGrad intializeDegreeGrad()
        {
            DegreeGrad degreesGrad = new DegreeGrad();
            try
            {
                using (var client = new HttpClient())
                {
                    string uri = $"http://ist.rit.edu/api/degrees";
                    var response = client.GetAsync(uri).Result;
                    var content = response.Content.ReadAsStringAsync().Result;
                    dynamic item1 = Newtonsoft.Json.JsonConvert.DeserializeObject(content);

                    var grad_resp = item1.graduate; //List of graduates
                    foreach (var single_grad in grad_resp)
                    {
                        Graduate g = new Graduate();
                        g.degreeName = single_grad.degreeName;
                        g.title = single_grad.title;
                        g.description = single_grad.description;

                        if (single_grad.concentrations != null)
                        {

                            var grad_concentrations = single_grad.concentrations;//list of grad concentrations
                            List<String> concentrations = new List<string>();
                            foreach (var gradConcen in grad_concentrations)
                            {
                                concentrations.Add(gradConcen.Value);
                            }
                            g.concentrations = concentrations;
                        }
                        else
                        {
                            var grad_active = single_grad.availableCertificates;
                            List<String> active = new List<string>();
                            foreach (var act in grad_active)
                            {
                                active.Add(act.Value);
                            }
                            g.availableCertificates = active;
                        }
                        degreesGrad.graduate.Add(g);

                    }
                    return degreesGrad;
                }
            }

            catch (Exception exp)
            {
                return null;
            }
        }
    }
}
    
