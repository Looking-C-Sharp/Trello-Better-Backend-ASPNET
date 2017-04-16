using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StickyAspnet.Models
{
    public class Item
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<String> Attachments { get; set; }
        public ApplicationUser Assignee { get; set; }
        public string History { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Emoji> Emoji { get; set; }
    }
}