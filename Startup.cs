using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
//using Microsoft.EntityFrameworkCore;
using cdscntmkpapinetcore2webapp.Models;
using cdscntmkpapinetcore2webapp.Hubs;

namespace cdscntmkpapinetcore2webapp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
       public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
            services.AddRazorPages();
            services.AddSignalR();
            
            services.AddMvc(option => option.EnableEndpointRouting = false) ;
            /*services.AddDbContext<cdscntmkpapinetcore2webappContext>(options =>
                    options.UseSqlite("Data Source=SoapCall.db"));
                    */
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();                
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseDeveloperExceptionPage();
            app.UseRouting();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Contact}/{id?}");
            });
             app.UseEndpoints(endpoints =>
            {   
                endpoints.MapRazorPages();
                endpoints.MapHub<MyHub>("/myHub");
                endpoints.MapHub<myProgressHub>("/myProgressHub");
                endpoints.MapHub<myUpdaterHub>("/myUpdaterHub");
            });
        }
    }
}
