using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using Moq;
using StreamingWebshop.Core.ApplicationService;
using StreamingWebshop.Core.ApplicationService.Services;
using StreamingWebshop.Core.DomainService;
using StreamingWebshop.Core.Entity;
using Xunit;

namespace xUnitTests.ApplicationService.Services
{
    public class ProductServiceTest
    {


        public void Dispose()
        {
            //Dispose Stuff we dont need anymore
        }
        
        
        [Fact]
        public void CreateProductWithoutName()
        {
            var productRepo = new Mock<IProductRepository>();
            IProductService service = 
                new ProductService(productRepo.Object);
            var product = new Product()
            
            {
                Id = 1,
              //  Name = "Hollaballoon----------------",
                Category = "balloon animal",
                Images = null,
                Price = 200,
                Stock = 20,
                Description = "test"
            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateProduct(product));
            
            Assert.Equal("Product needs a Name", ex.Message);
        }
        
        
        [Fact]
        public void CreateProductWithoutCategory()
        {
            var productRepo = new Mock<IProductRepository>();
            IProductService service = 
                new ProductService(productRepo.Object);
            var product = new Product()
            {
                Id = 2,
                Name = "Holla123123balloon",
              //Category = "balloo123n animal----------------",
                Images = null,
                Price = 200,
                Stock = 20,
                Description = "test"
            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateProduct(product));
            
            Assert.Equal("Product needs a Type", ex.Message);
        }
        
        [Fact]
        public void CreateProductWithoutDescription()
        {
            var productRepo = new Mock<IProductRepository>();
            IProductService service = 
                new ProductService(productRepo.Object);
            var product = new Product()
            {
                Id = 2,
                Name = "testtestetsetsetest",
                Category = "basdfasdfasdf",
                Images = null,
                Price = 200,
                Stock = 20,
                //Description = "test"
            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateProduct(product));
            
            Assert.Equal("Product needs a description", ex.Message);
        }
        

        
        [Fact]
        public void CreateProductShouldCallProductRepoCreateProductOnce()
        {
            var productRepo = new Mock<IProductRepository>();
            IProductService service =
                new ProductService(productRepo.Object);
            var product = new Product()
            {
                Id = 1,
                Name = "Hollaballoon",
                Category = "balloon animal",
                Images = null,
                Price = 200,
                Stock = 20,
                Description = "test"
            };

            service.CreateProduct(product);
            productRepo.Verify(x => x.Create(It.IsAny<Product>()), Times.Once);
        }

    }
}