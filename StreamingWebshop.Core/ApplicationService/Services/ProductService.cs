using StreamingWebshop.Core.DomainService;
using StreamingWebshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreamingWebshop.Core.ApplicationService.Services
{
    public class ProductService : IProductService
    {
        //dep injection
        readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //TODO!
        public Product NewProduct(string Name, 
            string Description, double Price,
            string Category, int Stock, string PicUrl)
        {
            var prod = new Product()
            {
                Name = Name,
                Description = Description,
                Price = Price,
                Category = Category,
                Stock = Stock,
                PicUrl = PicUrl
                
            };
            return prod;
        }

        public Product CreateProduct(Product prod)
        {
            return _productRepository.Create(prod);
        }

        public Product DeleteProduct(int id)
        {
            return _productRepository.Delete(id);
        }

        public Product FindProductById(int id)
        {
            return _productRepository.ReadById(id);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.ReadAll().ToList();
        }

        public Product UpdateProduct(Product productUpdate)
        {
            return _productRepository.Update(productUpdate);
        }
    }
}
