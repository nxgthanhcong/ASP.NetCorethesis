using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Areas.Admin.Models;
using Ecommerce.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Ecommerce.Controllers
{
    public class LoginController : Controller
    {
        private readonly CarContext _context;
        public LoginController(CarContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login([Bind("Gmail,Password")] User user)
        {
            var r = _context.users.Where(m => (m.Gmail == user.Gmail && m.Password ==
             /*StringProcessing.CreateMD5Hash(*/user.Password)).ToList() ;
            if (r.Count == 0)
            {
                return View("Index");
            }
            string str = r[0].Name;
            int tm = r[0].ID;
            HttpContext.Session.SetString("user", str);
            HttpContext.Session.SetInt32("userId", tm);
            if (r[0].Rule == 0)
            {
                var url = Url.RouteUrl("routeArea", new { Controller = "Home", action = "Index", area = "Admin" });
                return Redirect(url);
            }
            if (r[0].Rule == 1)
            {
                int userRule = r[0].Rule;
                HttpContext.Session.SetString("userrule", userRule.ToString());
                return RedirectToAction("index", "DynamicPages");
            }
            return RedirectToAction("index", "DynamicPages");

        }
        public IActionResult Logout()
        {
            if(HttpContext.Session.GetString("userrule") == "1")
            {
                HttpContext.Session.Remove("user");
                HttpContext.Session.Remove("userrule");
                var url = Url.RouteUrl("dafault", new { Controller = "DynamicPages", action = "Index"});
                return Redirect(url);
            }
            HttpContext.Session.Remove("user");
            HttpContext.Session.Remove("userrule");
            return RedirectToAction("index", "login");

        }
    }
}
