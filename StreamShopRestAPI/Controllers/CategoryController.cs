using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StreamingWebshop.Core.ApplicationService;
using StreamingWebshop.Core.ApplicationService.Services;
using StreamingWebshop.Core.Entity;

namespace StreamShopRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IProductService _ProductService;

        public CategoryController(IProductService productService)
        {
            _ProductService = productService;
        }

        // GET: api/Category
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/category
        [HttpGet("{category}")]
        public ActionResult<IEnumerable<Product>> Get(string category)
        {
            return _ProductService.GetProductsByCategory(category);
        }

        // POST: api/Category
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
