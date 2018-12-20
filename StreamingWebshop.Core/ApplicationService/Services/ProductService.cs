using StreamingWebshop.Core.DomainService;
using StreamingWebshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.IO;
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

        
        public Product NewProduct(string Name, 
            string Description, double RetailPrice, double WholeSalePrice,
            string Category, int Stock, string PicUrl)
        {
            var prod = new Product()
            {
                Name = Name,
                Description = Description,
                RetailPrice = RetailPrice,
                WholeSalePrice = WholeSalePrice,
                Category = Category,
                Stock = Stock,
                PicUrl = PicUrl
                
            };
            return prod;
        }
        /**
         * Checks if product contains Name, Category and description.
         * As well as making sure the price is more than 1.
         * Then sends the product to the product repository
         * and returns the product created.
         */
        public Product CreateProduct(Product prod)
        {
            if (prod.Name == null)
                throw new InvalidDataException("Product needs a Name");
            if (prod.Category == null)
                throw new InvalidDataException("Product needs a Type");
            if (Math.Abs(prod.RetailPrice) < 1)
                throw new InvalidDataException("Product Price needs to be more than 1");
            if (prod.Description == null)
                throw new InvalidDataException("Product needs a description");
            return _productRepository.Create(prod);
        }
        /**
         * Forwards the product id to the repository
         * and returns the product deleted
         */
        public Product DeleteProduct(int id)
        {
            return _productRepository.Delete(id);
        }
        /**
         * Forwards the Id to the repository
         * and returns the product found.
         */
        public Product FindProductById(int id)
        {
            return _productRepository.ReadById(id);
        }
        /**
         * Returns all products and turns them into a list.
         */
        public List<Product> GetAllProducts()
        {
            return _productRepository.ReadAll().ToList();
        }
        /**
         * Returns all products with the matching category string
         */
        public List<Product> GetProductsByCategory(string category)
        {
            return _productRepository.ReadByCategory(category);
        }
        /**
         * Checks for missing attributes and then returns updated product.
         */
        public Product UpdateProduct(Product productUpdate)
        {
            if (productUpdate.Name == null)
                throw new InvalidDataException("Product needs a Name");
            if (productUpdate.Category == null)
                throw new InvalidDataException("Product needs a Type");
            if (Math.Abs(productUpdate.RetailPrice) < 1)
                throw new InvalidDataException("Product Price needs to be more than 1");
            if (productUpdate.Description == null)
                throw new InvalidDataException("Product needs a description");
            return _productRepository.Update(productUpdate);
        }
    }
}
