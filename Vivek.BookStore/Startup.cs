using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting; 

namespace Vivek.BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Try Middle Ware Concept

            //app.Use(async (context,next)=>
            //{

            //    await context.Response.WriteAsync("Hello From My First Middleware");
            //    await next();
            //    await context.Response.WriteAsync("Hello From My First Middleware Response");
            //}
            //);

            //app.Use(async (Context, next) =>
            //{
            //    await Context.Response.WriteAsync("Hello From My Second Middleware");
            //});

            //app.Use(async(context,next)=>
            //    {
            //        await context.Response.WriteAsync("Hello From My Third Middleware");
            //        await next();
            //});

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapDefaultControllerRoute();

                // Now Add Librerary of MVC in Current Application

                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello Vivek!");
            //    });
            //});
        }
    }
}
