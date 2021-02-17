using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Areas.Admin.Models;
using Ecommerce.Data;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Net;
using System.Web;

namespace Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly CarContext _context;

        public ProductController(CarContext context)
        {
            _context = context;
        }

        // GET: Admin/Product
        public async Task<IActionResult> Index(int? id)
        {
            var carContext = _context.products.Include(p => p.Brand).Include(p => p.Category);
            ViewBag.listProduct = _context.products.ToList();
            return View(await carContext.ToListAsync());

            //Product product = null;
            //if (id != null)
            //{
            //    product = await _context.products.FirstOrDefaultAsync(m => m.ID == id);
            //}
            
            //return View(product);
        }

        // GET: Admin/Product/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.products
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/Product/Create
        public IActionResult Create()
        {
            ViewBag.ListBrand = _context.brands.ToList();
            ViewBag.ListCategory = _context.categories.ToList();
            ViewData["BrandID"] = new SelectList(_context.brands, "Id", "Logo");
            ViewData["CategoryID"] = new SelectList(_context.categories, "ID", "Name");
            return View();
        }

        // POST: Admin/Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,SerialNumber,Description,Content,Color,Price,Status,Imgage,CategoryID,BrandID,Namsx,NgayNhapKhau,TinhTrang,DongCo")] Product product, IFormFile ful)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/pro", product.ID + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ful.CopyToAsync(stream);
                }
                product.Imgage = product.ID + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                _context.Update(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Admin/Product/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.ListBrand = _context.brands.ToList();
            ViewBag.ListCategory = _context.categories.ToList();
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["BrandID"] = new SelectList(_context.brands, "Id", "Logo", product.BrandID);
            ViewData["CategoryID"] = new SelectList(_context.categories, "ID", "Name", product.CategoryID);
            return View(product);
        }

        // POST: Admin/Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,SerialNumber,Description,Content,Color,Price,Status,Imgage,CategoryID,BrandID,Namsx,NgayNhapKhau,TinhTrang,DongCo")] Product product, IFormFile ful)
        {
            if (id != product.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (ful != null) //nếu có chọn hình mới
                    {
                        //xóa hình cũ
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/pro", product.Imgage);
                        if ((System.IO.File.Exists(path)))
                        {
                            System.IO.File.Delete(path);
                        }
                        //lưu hình mới
                        path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/pro", product.ID + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await ful.CopyToAsync(stream);
                        }
                        product.Imgage = product.ID + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                    }
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ID))
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
            return View(product);
        }

        // GET: Admin/Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.products
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.products.FindAsync(id);
            _context.products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        private bool ProductExists(int id)
        {
            return _context.products.Any(e => e.ID == id);
        }
    }
}
