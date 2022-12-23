using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace WebApi
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
            services.AddControllers();
            services.AddDbContext<ProjectContext>(opt =>
            {
                opt.UseSqlServer("Server=DESKTOP-8EHVPE9\\SQLEXPRESS;Database=projectApiDB;Trusted_Connection=True;");
            });



            services.AddSwaggerDocument(config =>
            {
                config.PostProcess = (doc => 
                {
                    doc.Info.Title = "EmployeeTest";
                    doc.Info.Version = "1.1.1";
                    doc.Info.Contact = new NSwag.OpenApiContact()
                    {
                     Name = "Abdullah Müdür",
                     Email = "abdullah@gmail.com",
                     Url = "https://www.sample.com"
                    };

                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
