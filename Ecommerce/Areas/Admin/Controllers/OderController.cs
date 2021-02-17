using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Areas.Admin.Models;
using Ecommerce.Data;

namespace Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OderController : Controller
    {
        private readonly CarContext _context;

        public OderController(CarContext context)
        {
            _context = context;
        }

        // GET: Admin/Oder
        public async Task<IActionResult> Index()
        {
            var carContext = _context.oders.Include(o => o.User);
            return View(await carContext.ToListAsync());
        }

        // GET: Admin/Oder/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oder = await _context.oders
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oder == null)
            {
                return NotFound();
            }

            return View(oder);
        }

        // GET: Admin/Oder/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.users, "ID", "Address");
            return View();
        }

        // POST: Admin/Oder/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OderDate,UserId,Status,TotalPrice")] Oder oder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(oder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.users, "ID", "Address", oder.UserId);
            return View(oder);
        }

        // GET: Admin/Oder/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oder = await _context.oders.FindAsync(id);
            if (oder == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.users, "ID", "Address", oder.UserId);
            return View(oder);
        }

        // POST: Admin/Oder/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OderDate,UserId,Status,TotalPrice")] Oder oder)
        {
            if (id != oder.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(oder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OderExists(oder.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.users, "ID", "Address", oder.UserId);
            return View(oder);
        }

        // GET: Admin/Oder/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oder = await _context.oders
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oder == null)
            {
                return NotFound();
            }

            return View(oder);
        }

        // POST: Admin/Oder/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var oder = await _context.oders.FindAsync(id);
            _context.oders.Remove(oder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OderExists(int id)
        {
            return _context.oders.Any(e => e.Id == id);
        }
    }
}
