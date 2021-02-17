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
    public class OderDetailController : Controller
    {
        private readonly CarContext _context;

        public OderDetailController(CarContext context)
        {
            _context = context;
        }

        // GET: Admin/OderDetail
        public async Task<IActionResult> Index()
        {
            var carContext = _context.oderDetails.Include(o => o.oder).Include(o => o.product);
            return View(await carContext.ToListAsync());
        }

        // GET: Admin/OderDetail/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oderDetail = await _context.oderDetails
                .Include(o => o.oder)
                .Include(o => o.product)
                .FirstOrDefaultAsync(m => m.OderId == id);
            if (oderDetail == null)
            {
                return NotFound();
            }

            return View(oderDetail);
        }

        // GET: Admin/OderDetail/Create
        public IActionResult Create()
        {
            ViewData["OderId"] = new SelectList(_context.oders, "Id", "Id");
            ViewData["ProductId"] = new SelectList(_context.products, "ID", "Color");
            return View();
        }

        // POST: Admin/OderDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Quantity,price,OderId,ProductId")] OderDetail oderDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(oderDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OderId"] = new SelectList(_context.oders, "Id", "Id", oderDetail.OderId);
            ViewData["ProductId"] = new SelectList(_context.products, "ID", "Color", oderDetail.ProductId);
            return View(oderDetail);
        }

        // GET: Admin/OderDetail/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oderDetail = await _context.oderDetails.FindAsync(id);
            if (oderDetail == null)
            {
                return NotFound();
            }
            ViewData["OderId"] = new SelectList(_context.oders, "Id", "Id", oderDetail.OderId);
            ViewData["ProductId"] = new SelectList(_context.products, "ID", "Color", oderDetail.ProductId);
            return View(oderDetail);
        }

        // POST: Admin/OderDetail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Quantity,price,OderId,ProductId")] OderDetail oderDetail)
        {
            if (id != oderDetail.OderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(oderDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OderDetailExists(oderDetail.OderId))
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
            ViewData["OderId"] = new SelectList(_context.oders, "Id", "Id", oderDetail.OderId);
            ViewData["ProductId"] = new SelectList(_context.products, "ID", "Color", oderDetail.ProductId);
            return View(oderDetail);
        }

        // GET: Admin/OderDetail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oderDetail = await _context.oderDetails
                .Include(o => o.oder)
                .Include(o => o.product)
                .FirstOrDefaultAsync(m => m.OderId == id);
            if (oderDetail == null)
            {
                return NotFound();
            }

            return View(oderDetail);
        }

        // POST: Admin/OderDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var oderDetail = await _context.oderDetails.FindAsync(id);
            _context.oderDetails.Remove(oderDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OderDetailExists(int id)
        {
            return _context.oderDetails.Any(e => e.OderId == id);
        }
    }
}
