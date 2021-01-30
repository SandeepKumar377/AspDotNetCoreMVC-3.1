using BookLibrary.Data;
using BookLibrary.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BookLibraryContext>(
                options => options.UseSqlServer("Server=DELL;Database=BookLibrary;Integrated Security=True;"));

            services.AddControllersWithViews();

#if DEBUG
            services.AddRazorPages().AddRazorRuntimeCompilation();
            // uncomment this code to disable client side validation.
            //    .AddViewOptions(option => 
            //{
            //    option.HtmlHelperOptions.ClientValidationEnabled = false;
            //});
#endif
            services.AddScoped<BookRepository, BookRepository>();
            services.AddScoped<LanguageRepository, LanguageRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
            endpoints.MapDefaultControllerRoute();
            //endpoints.MapControllerRoute(
            //    name: "Default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}");

            //endpoints.MapControllerRoute(
            //     name: "AboutUs",
            //     pattern: "about-us",
            //     defaults: new { controller = "Home", action = "AboutUs" });
            });
        }
    }
}
