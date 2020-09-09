using Services.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Services.Api.Controllers
{
    public class ProductController : ApiController
    {
        Product[] Products = new Product[]
        {
            new Product { Id = 1, Title = "Air Max XI", Description = "Basketball shoe"},
            new Product { Id = 2, Title = "Icy Hot", Description = "Muscle Pain Reflief"},
            new Product { Id = 3, Title = "Crest", Description = "Tooth paste"}
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return Products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
