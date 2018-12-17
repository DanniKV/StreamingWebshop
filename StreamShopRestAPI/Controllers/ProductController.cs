using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StreamingWebshop.Core.ApplicationService;
using StreamingWebshop.Core.Entity;

namespace StreamShopRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _ProductService;

        public ProductController(IProductService productService)
        {
            _ProductService = productService;
        }

        // GET api/Products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return _ProductService.GetAllProducts();
        }

        // GET api/Products/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            //Exceptions!


            return _ProductService.FindProductById(id);
            
        }

        // POST api/Products
        [HttpPost]
        public ActionResult<Product> Post([FromBody] Product product)
        {
            //Exceptions!


            return _ProductService.CreateProduct(product);
        }

        // PUT api/Products/5
        [HttpPut("{id}")]
        public ActionResult<Product> Put(int id, [FromBody] Product product)
        {
            //Exceptions!


            return _ProductService.UpdateProduct(product);
        }

        // DELETE api/Products/5
        [HttpDelete("{id}")]
        public ActionResult<Product> Delete(int id)
        {
            var prod = _ProductService.DeleteProduct(id);
            //Exceptions!


            return Ok($"Product with the Id of: {id} is deleted!");
        }
    }
}
