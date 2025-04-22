using System.Configuration;
using accesslayaer.data;
using accesslayaer.repostory;
using accesslayaer.repostory.interfaces;
using Bussiness_Logic_Layer;

using Bussiness_Logic_Layer.services;
using Demo.Buisness.Services.Departments;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<dbcontext>(Options =>
            {
                Options
                .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            }
            );


            builder.Services.AddScoped<idepartmentrepository, departmentrepository>();  // allow dependency injection for IDepartmentRepository

            builder.Services.AddScoped<IDepartmentServices,departmentservice>();


          builder.Services.AddScoped<iemployeerepository, employeerepository>(); // allow dependency injection for IEmployeeRepository

            builder.Services.AddScoped<iemployeeservice, employeeservice>();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
