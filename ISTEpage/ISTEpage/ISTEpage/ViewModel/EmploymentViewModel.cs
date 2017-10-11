using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISTEpage.Services;
using ISTEpage.Models;

namespace ISTEpage.ViewModel
{
    public class EmploymentViewModel
    {
        EmploymentDataService eds;

        public string IntroTitle { get; set; }
        public string Description0 { get; set; }
        public string Description1 { get; set; }
        public Employment allemployes { get; set; }
        public EmploymentViewModel()
        {
            eds = new EmploymentDataService();
        }

        internal void getData()
        {
            allemployes = eds.intializeEmploy();
            IntroTitle = allemployes.title;
            Description0 = allemployes.description0;
            Description1 = allemployes.description1;
            
            

        }
    }

}
