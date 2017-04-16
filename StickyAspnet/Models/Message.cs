using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StickyAspnet.Models
{
    public class Message
    {
        public long Id { get; set; }
        public ApplicationUser Author { get; set; }
        public string Body { get; set; }
        public List<string> Attachments { get; set; }
        public List<Emoji> Emoji { get; set; }
    }
}