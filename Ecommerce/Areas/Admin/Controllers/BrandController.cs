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
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        private readonly CarContext _context;

        public BrandController(CarContext context)
        {
            _context = context;
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            ViewBag.listBrand = _context.brands.ToList();
            base.OnActionExecuted(context);
        }
        // GET: Admin/Brand
        public async Task<IActionResult> Index(int? id)
        {
            TempData["StatusMessage"] = "Create brand successfully";
            TempData["EditMessage"] = "Edit brand successfully";
            Brand brand = null;
            if (id != null)
            {
                brand = await _context.brands.FirstOrDefaultAsync(m => m.Id == id);
            }
            return View(brand);
        }

        // GET: Admin/Brand/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var brand = await _context.brands
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (brand == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(brand);
        //}

        // GET: Admin/Brand/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // POST: Admin/Brand/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Status")] Brand brand ,IFormFile? ful)
            
        {
            var idd = _context.brands.Count() + 1;
            if (ModelState.IsValid)
            {
                if (ful != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/pro", idd + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await ful.CopyToAsync(stream);
                    }
                    
                    brand.Logo = idd + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                }
                else
                {
                    brand.Logo = "no-image.png";
                }
                
                _context.Add(brand);
               

                await _context.SaveChangesAsync();
                
                return RedirectToAction(nameof(Index));
            }
            return View("Index");
        }

       // GET: Admin/Brand/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var brand = await _context.brands.FindAsync(id);
        //    if (brand == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(brand);
        //}

        // POST: Admin/Brand/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Logo,Status")] Brand brand,IFormFile ful)
        {
            if (id != brand.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (ful != null)
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/pro", brand.Logo);
                        if (System.IO.File.Exists(path))
                        {
                            System.IO.File.Delete(path);
                        }
                        path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/pro", brand.Id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await ful.CopyToAsync(stream);
                        }
                        brand.Logo = brand.Id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                    }
     
                
                    _context.Update(brand);
                 
                    await _context.SaveChangesAsync();
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrandExists(brand.Id))
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

        // GET: Admin/Brand/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var brand = await _context.brands
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (brand == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(brand);
        //}

        //// POST: Admin/Brand/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var brand = await _context.brands.FindAsync(id);
        //    _context.brands.Remove(brand);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool BrandExists(int id)
        {
            return _context.brands.Any(e => e.Id == id);
        }
    }
}
