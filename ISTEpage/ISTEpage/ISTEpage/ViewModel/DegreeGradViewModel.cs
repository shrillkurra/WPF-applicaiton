using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISTEpage.Services;
using ISTEpage.Models;

namespace ISTEpage.ViewModel
{
    public class DegreeGradViewModel
    {
        DegreeGradDataService dgs;
        public List<string> Titlegrad { get; set; }

        public DegreeGrad AllDegreeGrad { get; set; }
        public DegreeGradViewModel()
        {
            dgs = new DegreeGradDataService();
        }
        internal void GetData()
        {
            AllDegreeGrad = dgs.intializeDegreeGrad();
            Titlegrad = new List<string>();
            for (int i = 0; i <= 2; i++)
            {
                Titlegrad.Add(AllDegreeGrad.graduate[i].title);
            }

        }
    }
}
