using Ecommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.ViewComponents
{
    public class LoginViewComponent : ViewComponent
    {
        string view = "default";
        public  IViewComponentResult Invoke(string x)
        {

            if (x != null)
            {
                view = "login";
            }

            return View(view);
        }
    }
}
