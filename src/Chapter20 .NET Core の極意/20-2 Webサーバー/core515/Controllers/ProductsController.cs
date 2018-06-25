using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using core515.Models;

namespace core515.Controllers
{
    [Produces("application/xml")]
    [Route("api/Products")]
    public class ProductsController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var lst = new List<Product>();
            lst.Add(new Product() { Id = 1, Name = "商品1", Price = 1000 });
            lst.Add(new Product() { Id = 2, Name = "商品2", Price = 1000 });
            lst.Add(new Product() { Id = 3, Name = "商品3", Price = 1000 });
            return lst;
            // return new string[] { "value1", "value2" };
        }

    }
}