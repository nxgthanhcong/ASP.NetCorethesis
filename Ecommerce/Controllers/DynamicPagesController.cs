using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using Ecommerce.Areas.Admin.Models;
using Ecommerce.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers
{
    public class DynamicPagesController : Controller
    {
        private readonly CarContext _context;
        public DynamicPagesController(CarContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.ListCate = _context.categories.Take(4).ToList();
            ViewBag.ListPros = _context.products.ToList();
            ViewBag.Cong = HttpContext.Session.GetString("user");
            return View("Index");
        }
        public IActionResult Blog()
        {
            return View("Blog");
        }
        public IActionResult About()
        {
            return View("About");
        }
        public IActionResult Shop()
        {
            return View("Shop");
        }
        public async Task<IActionResult> ShopSingleAsync(int? id)
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
            ViewBag.ListPros = _context.products.Take(3).ToList();
            ViewBag.Id = product.ID;
            ViewBag.Cong = HttpContext.Session.GetString("user");
           
            return View(product);
        }

        [HttpGet]
        public string Translate(string data, string la1, string la2)
        {

           
            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={la1}&tl={la2}&dt=t&q={HttpUtility.UrlEncode(data)}";
            var webClient = new WebClient
            {
                Encoding = System.Text.Encoding.UTF8
            };
            var resultKQ = webClient.DownloadString(url);
            try
            {
                resultKQ = resultKQ.Substring(4, resultKQ.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
                return resultKQ;
            }
            catch
            {
                return "test";
            }
        }
        public async Task<IActionResult> Mua(int? id)
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
            Oder oder = new Oder();
            OderDetail oderDetail = new OderDetail();
           
            oder.OderDate = DateTime.Now;
            oder.Status = true;
            oder.TotalPrice = product.Price;
            oder.UserId = HttpContext.Session.GetInt32("userId");
            _context.Add(oder);
            _context.SaveChanges();
            oderDetail.Quantity = 1;
            oderDetail.price = product.Price;
            oderDetail.OderId = oder.Id;
            oderDetail.ProductId = product.ID;
            _context.Add(oderDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            //return View(product);
        }
    }
}