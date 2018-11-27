using StreamingWebshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StreamingWebshop.Core.DomainService
{
    public interface IProductRepository
    {
        //Create
        Product Create(Product product);

        //Read
        Product ReadById(int id);
        IEnumerable<Product> ReadAll();


        //Update
        Product Update(Product ProductUpdate);


        //Delete
        Product Delete(int id);

    }
}
