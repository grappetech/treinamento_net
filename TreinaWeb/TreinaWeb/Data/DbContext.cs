using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TreinaWeb.Models;

namespace TreinaWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("banco")
        {

        }

        public DbSet<Tasks> Tasks { get; set; }
    }
}