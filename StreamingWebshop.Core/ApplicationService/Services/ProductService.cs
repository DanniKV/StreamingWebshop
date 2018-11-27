using StreamingWebshop.Core.DomainService;
using StreamingWebshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StreamingWebshop.Core.ApplicationService.Services
{
    public class ProductService : IProductService
    {
        //dep injection
        readonly IProductRepository _productRepository;
        readonly IProductService _productService;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }




        //TODO!
        public Product CreateProduct(Product prod)
        {
            throw new NotImplementedException();
        }

        public Product DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Product FindProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product newProduct(string Name, string Description, double Price)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduct(Product productUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
