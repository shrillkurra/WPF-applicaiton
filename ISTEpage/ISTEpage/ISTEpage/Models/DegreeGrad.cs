using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTEpage.Models
{
    public class Graduate
    {
        public string degreeName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<string> concentrations { get; set; }

        public List<string> availableCertificates { get; set; }
        public Graduate()
        {
            concentrations = new List<string>();
            availableCertificates = new List<string>();
        }
    }
    public class DegreeGrad
    {
        public List<Graduate> graduate { get; set; }
        public DegreeGrad()
        {
            graduate = new List<Graduate>();
        }
    }

    

}
