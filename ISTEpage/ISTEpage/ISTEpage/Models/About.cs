using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTEpage.Models
{
    public class About
    {
        public string title { get; set; }
        public string description { get; set; }
        public string quote { get; set; }
        public string quoteAuthor { get; set; }
        //return all the things that you need from the api page, that you need to display on your page
        public override string ToString()
        {
            return $"{title}:{description}:{quote}:{quoteAuthor}";
        }
    }
}
