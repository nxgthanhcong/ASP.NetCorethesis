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
    public class UserController : Controller
    {
        private readonly CarContext _context;

        public UserController(CarContext context)
        {
            _context = context;
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            ViewBag.ListUser = _context.users.ToList();
            base.OnActionExecuted(context);
        }

        // GET: Admin/User
        public async Task<IActionResult> Index(int? id)
        {
            User user = null;
            if (id != null)
            {
                user = await _context.users.FirstOrDefaultAsync(m=>m.ID == id);

            }
            return View(user);
        }


        // POST: Admin/User/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UserName,Password,Name,Address,Phone,Status,Gmail,Rule")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("Index");
        }
        // POST: Admin/User/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,UserName,Password,Name,Address,Phone,Status,Gmail,Rule")] User user)
        {
            if (id != user.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.ID))
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
        private bool UserExists(int id)
        {
            return _context.users.Any(e => e.ID == id);
        }
    }
}
