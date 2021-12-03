using CalisanBilgi.Data.DataContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using CalisanBilgi.Common.Mapping;
using AutoMapper;
using CalisanBilgi.Data.Contracts;
using CalisanBilgi.Data.Implemention;
using CalisanBiligi.BusinesEngine.Contracts;
using CalisanBiligi.BusinesEngine.Implemention;

namespace CalisanPersonelBilgi.UI
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
            services.AddRazorPages();
            services.AddDbContext<CalisanBilgiContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));
            services.AddAutoMapper(typeof(Maps));
            //services.AddScoped<IEmployeLeaveAllocationRepository, EmployeLeaveAllocationRepository>();
            //services.AddScoped<IEmployeLeaveRequestRepository, EmployeLeaveRequestRepository>();
            //services.AddScoped<IEmployeLeaveTypeRepository, EmployeLeaveTypeRepository>();

            services.AddScoped<IEmployeLeaveTypeBusinesEngine, EmployeLeaveTypeBusinesEngine>();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
