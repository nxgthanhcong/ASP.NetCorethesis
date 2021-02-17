using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Ecommerce.Hubs;
using Ecommerce.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace Ecommerce
{
    public class Startup
   
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(300);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddDbContext<CarContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CarShopContext")));
            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStaticFiles(new StaticFileOptions
                {
                    OnPrepareResponse = context =>
                        context.Context.Response.Headers.Add("Cache-Control", "no-cache")
                });
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();
            app.UseMiddleware<AuthenticationMiddleware>();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "routeArea",
                    pattern: "{area:exists}/{controller=category}/{action=Index}/{id?}"); 
                endpoints.MapControllerRoute(
                   name: "dafault",
                   pattern: "{controller=DynamicPages}/{action=Index}/{id?}");
                endpoints.MapHub<ChatHub>("/chathub");
            });
          

        }
    }
}
