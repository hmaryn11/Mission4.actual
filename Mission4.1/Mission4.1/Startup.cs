using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4._1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); //this allows us to use the MVC format
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
//          app.UseDefaultFiles(); --we don't need this one because we are using MVC
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints => // "=>" this is the lamda function
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=extra}/{action=Index}/{id?}" //the ? allows for nulls
                );
            });

        }
    }
}
