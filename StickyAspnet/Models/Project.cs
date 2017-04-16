using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StickyAspnet.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<List> Lists { get; set; }
    }
}