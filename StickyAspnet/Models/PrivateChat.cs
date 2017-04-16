using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StickyAspnet.Models
{
    public class PrivateChat
    {
        public int Id { get; set; }
        public List<ApplicationUser> Members { get; set; }
        public List<Message> Messages { get; set; }
    }
}