using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StickyAspnet.Models
{
    public class List
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public List Parent { get; set; }
    }
}