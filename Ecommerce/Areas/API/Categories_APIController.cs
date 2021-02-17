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
    public class Categories_APIController : ControllerBase
    {
        private readonly CarContext _context;

        public Categories_APIController(CarContext context)
        {
            _context = context;
        }

        // GET: api/Categories_API
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> Getcategories()
        {
            return await _context.categories.ToListAsync();
        }
        public class Category_Update_STT
        {
            public int ma { get; set; }
            public bool stt { get; set; }
        }
        [HttpPost]
        public string UpdateStatus(Category_Update_STT req)
        {
            req.stt = !req.stt;
            (from p in _context.categories where p.ID == req.ma select p).ToList().ForEach(x => x.Status = req.stt);
            _context.SaveChanges();
            return "{\"id\":" + req.ma + ",\"stt\":\"" + req.stt + "\"}";
        }
        [HttpGet]
        public string a()
        {
            return "abc";
        }
        // GET: api/Categories_API/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            var category = await _context.categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }

        // PUT: api/Categories_API/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<string> PutCategory(int id, Category category)
        {
            if (id != category.ID)
            {
                return "0";
            }

            _context.Entry(category).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(id))
                {
                    return "0";
                }
                else
                {
                    throw;
                }
            }
            _context.SaveChanges();
            return "{\"id\":" + id + ",\"stt\":\"" + category.Status + "\"}";
        }

        // POST: api/Categories_API
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
            _context.categories.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategory", new { id = category.ID }, category);
        }

        // DELETE: api/Categories_API/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Category>> DeleteCategory(int id)
        {
            var category = await _context.categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.categories.Remove(category);
            await _context.SaveChangesAsync();

            return category;
        }

        private bool CategoryExists(int id)
        {
            return _context.categories.Any(e => e.ID == id);
        }
    }
}
