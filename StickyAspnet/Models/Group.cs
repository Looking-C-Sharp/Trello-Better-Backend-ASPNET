using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StickyAspnet.Models
{
    public class Group
    {
        public long Id { get; set; }
        [Required] 
        public string Name { get; set; }
        public ApplicationUser Author { get; set; }
        public List<ApplicationUser> Administrators { get; set; }
        public List<ApplicationUser> Members { get; set; }
        public List<List> Lists { get; set; }
        public List<Message> Messsages { get; set; }
    }
}