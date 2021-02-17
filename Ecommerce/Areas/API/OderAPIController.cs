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
    [Route("/api/OderAPI")]
    [ApiController]
    public class OderAPIController : ControllerBase
    {
        private readonly CarContext _context;

        public OderAPIController(CarContext context)
        {
            _context = context;
        }

        // GET: api/OderAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Oder>>> Getoders()
        {
            return await _context.oders.ToListAsync();
        }

        // GET: api/OderAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Oder>> GetOder(int id)
        {
            var oder = await _context.oders.FindAsync(id);

            if (oder == null)
            {
                return NotFound();
            }

            return oder;
        }

        // PUT: api/OderAPI/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOder(int id, Oder oder)
        {
            if (id != oder.Id)
            {
                return BadRequest();
            }

            _context.Entry(oder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OderExists(id))
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

        // POST: api/OderAPI
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Oder>> PostOder(Oder oder)
        {
            _context.oders.Add(oder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOder", new { id = oder.Id }, oder);
        }

        // DELETE: api/OderAPI/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Oder>> DeleteOder(int id)
        {
            var oder = await _context.oders.FindAsync(id);
            if (oder == null)
            {
                return NotFound();
            }

            _context.oders.Remove(oder);
            await _context.SaveChangesAsync();

            return oder;
        }

        private bool OderExists(int id)
        {
            return _context.oders.Any(e => e.Id == id);
        }
    }
}
