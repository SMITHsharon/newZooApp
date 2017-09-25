using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newZooApp.DataModels
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("ZooApp")
        { }

        public DbSet<Animal> Animal { get; set; }
        public DbSet<ZooKeeper> ZooKeeper { get; set; }
        public DbSet<Environment> Environment { get; set; }
    }
}