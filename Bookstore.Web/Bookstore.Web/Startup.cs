using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Bookstore.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }



            ///Below We add Middleware to httppipeline in dotnetcore request,Next() is to pass thing to next middle where 
            /*app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from First middleware");
                await next();
                await context.Response.WriteAsync("Hello from First middleware Response");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from Secound middleware");
                await next();
            });*/

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    if (env.IsEnvironment("Development"))
                    {
                        await context.Response.WriteAsync("Hello World from Development !");
                    }
                    else { await context.Response.WriteAsync("Hello World from "+env.EnvironmentName); }

                });
            });
            ///below code is to add route for the url https://localhost:5050/Get request
           /* app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Get", async context =>
                {
                    await context.Response.WriteAsync("Hello Every One !! Good Morning");
                });
            });*/
        }
    }
}
