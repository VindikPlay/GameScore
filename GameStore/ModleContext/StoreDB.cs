using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameStore.model;
using System.Data.Entity;
using System.Threading.Tasks;

namespace GameStore.ModleContext
{
    class StoreDB : DbContext
    {
        public StoreDB()
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Game> Game { get; set; }
    }
}
