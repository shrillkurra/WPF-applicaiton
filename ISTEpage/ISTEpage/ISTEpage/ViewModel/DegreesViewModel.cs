using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISTEpage.Services;
using ISTEpage.Models;

namespace ISTEpage.ViewModel
{
    public class DegreesViewModel
    {
        DegreesDataService ds;
        public List<string> Titleunder { get; set; }
        
        public Degrees AllDegrees{ get; set; }
        public DegreesViewModel()
        {
            ds = new DegreesDataService();
        }
        internal void GetData()
        {
            AllDegrees = ds.initializedegrees();
            Titleunder = new List<string>();
            for (int i = 0; i <= 2; i++)
            {
                Titleunder.Add(AllDegrees.undergradute[i].title);
            }
            


        }

    }
    

}
