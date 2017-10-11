using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISTEpage.Services;

namespace ISTEpage.ViewModel
{
    public class AboutViewModel
    {
        AboutDataService ads;
        public string ItemTitle { get; set; } //Binding illustration
        public string ItemDescription { get; set; }
        public string ItemQuote { get; set; }
        public string ItemQuoteAuthor { get; set; }


        public AboutViewModel()
        {
            ads = new AboutDataService();
        }
        internal void GetData()
        {
            var item = ads.GetItemDetails();
            
            ItemTitle = item.title;
            ItemDescription = item.description;
            ItemQuote = item.quote;
            ItemQuoteAuthor = item.quoteAuthor;

        }
    }
}
