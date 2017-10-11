using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTEpage.Models
{
    public class Undergraduate
    {
        public string degreeName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<string> concentrations { get; set; }
        public Undergraduate()
        {
            concentrations = new List<string>();
        }
    }

    

    public class Degrees
    {
        

        public List<Undergraduate> undergradute { get; set; }
        

        public Degrees()
        {
            undergradute = new List<Undergraduate>();
            
        }
    }
}
