using Microsoft.EntityFrameworkCore;
using StreamingWebshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StreamingWebshop.Infrastructure.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> Opt) : base(Opt)
        {

        }
        //Fluint API Model-Builder
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }

        

    }
}
