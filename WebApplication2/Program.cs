using accesslayaer;
using accesslayaer.data;
using accesslayaer.repostory;
using Bussiness_Logic_Layer;
using Bussiness_Logic_Layer.models;
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
            builder.Services.AddScoped<departmentrepository>();
            builder.Services.AddDbContext<dbcontext>(options =>
            {
                options.UseSqlServer("server=.;database=Mazen;trusted_connection=true;");


            });


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
