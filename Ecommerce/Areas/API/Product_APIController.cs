using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Areas.Admin.Models;
using Ecommerce.Data;

namespace Ecommerce.Areas.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Product_APIController : ControllerBase
    {
        private readonly CarContext _context;

        public Product_APIController(CarContext context)
        {
            _context = context;
        }

        public class Product_Update_STT
        {
            public int ma { get; set; }
            public bool stt { get; set; }
        }
        [HttpPost]
        public string UpdateStatus(Product_Update_STT req)
        {
            req.stt = !req.stt;
            (from p in _context.products where p.ID == req.ma select p).ToList().ForEach(x => x.Status = req.stt);
            _context.SaveChanges();
            return "{\"id\":" + req.ma + ",\"stt\":\"" + req.stt + "\"}";
        }
        // GET: api/Product_API
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Getproducts()
        {
            return await _context.products.ToListAsync();
        }
        [HttpGet]
        public string GetTrans(int id)
        {
           
            (from p in _context.products select p.Description).ToList();

            return "aa";
        }
        // GET: api/Product_API/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // PUT: api/Product_API/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.ID)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Product_API
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.ID }, product);
        }

        // DELETE: api/Product_API/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var product = await _context.products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.products.Remove(product);
            await _context.SaveChangesAsync();

            return product;
        }

        private bool ProductExists(int id)
        {
            return _context.products.Any(e => e.ID == id);
        }
    }
}
