using Microsoft.EntityFrameworkCore;
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



        /**
         * Calls the context to add the product entity
         * then it saves the changes and returns the product.
         */
        public Product Create(Product product)
        {
            var prod = _ctx.Products.Add(product).Entity;
            _ctx.SaveChanges();
            return prod;
        }
        /**
         * Deletes the product with the given id.
         */
        public Product Delete(int id)
        {
            var prodRemoved = _ctx.Remove(new Product { Id = id }).Entity;
            _ctx.SaveChanges();
            return prodRemoved;
        }
        /**
         * Makes a new list of products with the ones containing
         * the given string category and then returns them.
         */
        public List<Product> ReadByCategory(string category)
        {
            var productsByCategory = new List<Product>();
            productsByCategory.AddRange(_ctx.Products.Where(p => p.Category == category));
            return productsByCategory;
        }
        /**
         * READS all the products in the context.
         */
        public IEnumerable<Product> ReadAll()
        {
            return _ctx.Products;
        }
        /**
         * Reads the products in the context and returns the first one with matching Id
         *   *Returns the only one with matching id.
         */
        public Product ReadById(int id)
        {
            return _ctx.Products.FirstOrDefault(p => p.Id == id);
        }
        /**
         * Updates the product
         */
        public Product Update(Product productUpdate)
        {
            _ctx.Attach(productUpdate).State = EntityState.Modified;
            _ctx.SaveChanges();
            return productUpdate;
        }
    }
}
