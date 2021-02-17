using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Areas.Admin.Models;
using Ecommerce.Data;

namespace Ecommerce.Areas.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Users_APIController : ControllerBase
    {
        private readonly CarContext _context;

        public Users_APIController(CarContext context)
        {
            _context = context;
        }

        // GET: api/Users_API
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Getusers()
        {
            return await _context.users.ToListAsync();
        }
        public class User_Update_STT
        {
            public int ma { get; set; }
            public bool stt { get; set; }
        }
        [HttpPost]
        public string UpdateStatus(User_Update_STT req)
        {
            req.stt = !req.stt;
            (from p in _context.users where p.ID == req.ma select p).ToList().ForEach(x => x.Status = req.stt);
            _context.SaveChanges();
            return "{\"id\":" + req.ma + ",\"stt\":\"" + req.stt + "\"}";
        }
        [HttpGet]
        public string a()
        {
            return "abc";
        }
        // GET: api/Users_API/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/Users_API/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<string> PutUser(int id, User user)
        {
            if (id != user.ID)
            {
                return "0";
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return "0";
                }
                else
                {
                    throw;
                }
            }

            _context.SaveChanges();
            return "{\"id\":" + id + ",\"stt\":\"" + user.Status + "\"}";
        }

        // POST: api/Users_API
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _context.users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.ID }, user);
        }

        // DELETE: api/Users_API/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            var user = await _context.users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.users.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private bool UserExists(int id)
        {
            return _context.users.Any(e => e.ID == id);
        }
    }
}
