using Ecommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.ViewComponents
{
    public class MuaViewComponent:ViewComponent
    {
        string view = "dafault";
        public  IViewComponentResult Invoke(string x)
        {

            if (x != null)
            {
                view = "Login";
            }

            return View(view);
        }
    }
}
