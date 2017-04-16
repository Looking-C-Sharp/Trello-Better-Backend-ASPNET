using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StickyAspnet.Models
{
    public class Emoji
    {
        public long ID { get; set; }
        public ApplicationUser Author { get; set; }
        public string Character { get; set; }
    }
}