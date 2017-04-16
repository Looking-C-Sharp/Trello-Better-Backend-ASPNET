using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StickyAspnet.Models
{
    public class Comment
    {
        public long Id { get; set; }
        public ApplicationUser Author { get; set; }
        public string Body { get; set; }
        public DateTime Date {get; set; }
    }
}