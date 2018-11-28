using StreamingWebshop.Core.DomainService;
using StreamingWebshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var prod = _ctx.Products.Add(product).Entity;
            _ctx.SaveChanges();
            return prod;
        }

        public Product Delete(int id)
        {
            var prodRemoved = _ctx.Remove(new Product { Id = id }).Entity;
            _ctx.SaveChanges();
            return prodRemoved;
        }

        public IEnumerable<Product> ReadAll()
        {
            return _ctx.Products;
        }

        public Product ReadById(int id)
        {
            return _ctx.Products.FirstOrDefault(p => p.Id == id);
        }

        public Product Update(Product productUpdate)
        {
            _ctx.Attach(productUpdate).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _ctx.SaveChanges();
            return productUpdate;
        }
    }
}
