using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StreamingWebshop.Core.Entity
{
    public class Product
    {

        //Possibly need other kinds of product entities mb (pc hardware, cams, screens...)
        public int Id { get; set; }

        public string Name {get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string Category { get; set; }

        public int Stock { get; set; }

        public List<Image> Images { get; set; }

    }
}
