using System;
using System.Collections.Generic;
using System.Text;
using KanBagisiMVC.Kizilay.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace KanBagisiMVC.Kizilay.DataAccess.Concrete.EntityFramework
{
    public class KizilayDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-9P1JTP9\SQLEXPRESS;Database=KanBagisiVerileri;Trusted_Connection=true");
        }

        public DbSet<Bagisci> Bagiscis { get; set; }

        public DbSet<Hasta> Hastas { get; set; }

    }
}
