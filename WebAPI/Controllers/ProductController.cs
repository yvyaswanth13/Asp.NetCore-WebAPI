using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductContext _context;

        public ProductController(ProductContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public List<Product> Get()
        {
            return _context.products.ToList();
        }
        [HttpPost]
        public async Task<ActionResult>insertProduct(Product p)
        {
            _context.products.Add(p);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> updateProduct(Product p)
        {
            _context.products.Update(p);
            _context.SaveChanges();
            return Ok();
        }

    }
}
