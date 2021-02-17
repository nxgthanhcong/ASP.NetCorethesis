using Ecommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.ViewComponents
{
    public class BrandViewComponent:ViewComponent

    {
        private CarContext _carContext;
        public BrandViewComponent (CarContext carContext)
        {
            _carContext = carContext;
        }
     
        public async Task<IViewComponentResult> InvokeAsync()
        {
          var  brands = await _carContext.brands.ToListAsync();
            return View(brands);
        } 
    }
}
