using StreamingWebshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StreamingWebshop.Core.ApplicationService
{
    public interface IProductService
    {
        //New Product
        Product NewProduct(string name,
            string description,
            double retailPrice,
            double wholeSalePrice,
            string category,
            int stock,
            string picUrl);

        //Post
        Product CreateProduct(Product prod);

        //get
        Product FindProductById(int id);

        List<Product> GetAllProducts();


        //Put
        Product UpdateProduct(Product productUpdate);


        //Delete
        Product DeleteProduct(int id);
    }
}
