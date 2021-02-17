using Ecommerce.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Data
{
    public class CarContext:DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<OderDetail>().HasKey(table => new
            {
                table.OderId,
                table.Id
            });
        }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Oder> oders { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<OderDetail> oderDetails { get; set; }

    }
}
