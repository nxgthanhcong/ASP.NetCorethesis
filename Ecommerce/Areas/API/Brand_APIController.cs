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
    public class Brand_APIController : ControllerBase
    {
        private readonly CarContext _context;

        public Brand_APIController(CarContext context)
        {
            _context = context;
        }

        // GET: api/Brand_API
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brand>>> Getbrands()
        {
            return await _context.brands.ToListAsync();
        }
        public struct Brand_Update_STT
        {
            public int ma { get; set; }
            public bool stt { get; set; }
        }
        [HttpPost]
        public string UpdateStatus(Brand_Update_STT req)
        {
            req.stt = !req.stt;
            (from p in _context.brands where p.Id == req.ma select p).ToList().ForEach(x => x.Status = req.stt);
            _context.SaveChanges();
            return "{\"id\":" + req.ma + ",\"stt\":\"" + req.stt + "\"}";
        }
        [HttpGet]
        public string a()
        {
            return "abc";
        }
        // GET: api/Brand_API/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Brand>> GetBrand(int id)
        {
            var brand = await _context.brands.FindAsync(id);

            if (brand == null)
            {
                return NotFound();
            }

            return brand;
        }

        // PUT: api/Brand_API/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<string> PutBrand(int id, Brand brand)
        {

            if (id != brand.Id)
            {
                return "0";
            }

            _context.Entry(brand).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BrandExists(id))
                {
                    return "0";
                }
                else
                {
                    throw;
                }
            }
            _context.SaveChanges();
            return "{\"id\":"+id+",\"stt\":\""+brand.Status+"\"}";
        }

        // POST: api/Brand_API
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Brand>> PostBrand(Brand brand)
        {
            _context.brands.Add(brand);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBrand", new { id = brand.Id }, brand);
        }

        // DELETE: api/Brand_API/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Brand>> DeleteBrand(int id)
        {
            var brand = await _context.brands.FindAsync(id);
            if (brand == null)
            {
                return NotFound();
            }

            _context.brands.Remove(brand);
            await _context.SaveChangesAsync();

            return brand;
        }

        private bool BrandExists(int id)
        {
            return _context.brands.Any(e => e.Id == id);
        }
    }
}
