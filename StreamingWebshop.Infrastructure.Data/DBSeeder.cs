﻿using System;
using System.Collections.Generic;
using System.Text;
using StreamingWebshop.Infrastructure.Data;
using StreamingWebshop.Core.Entity;

namespace StreamingWebshop.Infrastructure.Data
{
    public class DBSeeder
    {
        public static void SeedDB(Context ctx)
        {
            //This ensures that the DB is deleted. before seeding
            //MAKE SURE TO BE UNDER THE SECTION "env.IsDevelopment()" 
            //else it can delete complete production DB !!!DØD BABY!!!

            ctx.Database.EnsureDeleted();

            //Ensures the DB is created with the startup customers and orders
            //Seeds the Data into the DB - stacks with each startup
            ctx.Database.EnsureCreated();

            //Fake Products
            var prod1 = ctx.Products.Add(new Product()
            {
                Name = "GTX1018TI",
                Description = "Super Awesome GPU",
                Price = 4000.00
            }).Entity;

            var prod2 = ctx.Products.Add(new Product()
            {
                Name = "WebCam",
                Description = "Super Awesome GPU",
                Price = 850.95
            }).Entity;

            var prod3 = ctx.Products.Add(new Product()
            {
                Name = "MSI Monitor",
                Description = "Super Awesome GPU",
                Price = 2299.95
            }).Entity;
            ctx.SaveChanges();
        }
        
    }
}