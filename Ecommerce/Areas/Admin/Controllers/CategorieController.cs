using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Areas.Admin.Models;
using Ecommerce.Data;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategorieController : Controller
    {
        private readonly CarContext _context;

        public CategorieController(CarContext context)
        {
            _context = context;
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            ViewBag.ListCate = _context.categories.ToList();
            base.OnActionExecuted(context);
        }

        // GET: Admin/Categorie
        public async Task<IActionResult> Index(int? id)
        {
            Category category = null;
            if (id != null)
            {
                category = await _context.categories.FirstOrDefaultAsync(m => m.ID == id);
            }
            return View(category);
        }


        // POST: Admin/Categorie/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Status")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("Index");
        }


        // POST: Admin/Categorie/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Status")] Category category)
        {
            if (id != category.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.ID))
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
            return View("Index");
        }


        private bool CategoryExists(int id)
        {
            return _context.categories.Any(e => e.ID == id);
        }
    }
}
