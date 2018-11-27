using StreamingWebshop.Core.DomainService;
using StreamingWebshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StreamingWebshop.Infrastructure.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        readonly Context _ctx;

        public ProductRepository(Context ctx)
        {
            _ctx = ctx;
        }



        //TODO!
        public Product Create(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Product ReadById(int id)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product ProductUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
