using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class StaticPagesController : Controller
    {
        public IActionResult Contact()
        {
            return View("Contact");
        }
        public IActionResult Single()
        {
            return View("Single");
        }

    }
}