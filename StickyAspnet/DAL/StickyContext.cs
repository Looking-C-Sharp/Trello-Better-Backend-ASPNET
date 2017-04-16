using StickyAspnet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StickyAspnet.DAL
{
    public class StickyContext : DbContext
    {
        public StickyContext() : base ("StickContext")
        {

        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<PrivateChat> PrivateChats { get; set; }
    }
}