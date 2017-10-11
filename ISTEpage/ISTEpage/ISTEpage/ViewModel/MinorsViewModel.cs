using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISTEpage.Services;
using ISTEpage.Models;

namespace ISTEpage.ViewModel
{
    public class MinorsViewModel
    {
        MinorsDataService mds;

        public List<string> MinorTitle { get; set; }
        public Minors AllMinors { get; set; }
        public MinorsViewModel()
        {
            mds = new MinorsDataService();
        }
        internal void GetData()
        {
            AllMinors = mds.initializeMinors();
            MinorTitle = new List<string>();
            for (int i = 0; i <= 7; i++)
            {
                MinorTitle.Add(AllMinors.UgMinors[i].name);
            }
            
        }
    }
}
