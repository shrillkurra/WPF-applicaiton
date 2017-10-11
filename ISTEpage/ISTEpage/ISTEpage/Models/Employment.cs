using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTEpage.Models
{
    public class Content
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class Introduction
    {
        public string title { get; set; }
        public List<Content> content { get; set; }
        
    }
    public class Employment
    {
        public string title{get;set;}
        public string description0 { get; set; }
        public string description1 { get; set; }
        
        public Introduction introduction { get; set; }
    }
}
