using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wsei.lab3.Models;

namespace Wsei.lab3.Controllers
{
    [Route("api/products")]
    public class ProductsApiController : Controller
    {
        [HttpPost]
        public IActionResult Add(ProductModel product)
        {
            return Ok();
        }
    }
}
