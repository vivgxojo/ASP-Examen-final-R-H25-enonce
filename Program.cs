using ProjetSession.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace ProjetSession
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IRepLocations, BdRepJoueurs>();

            builder.Services.AddSession();

            builder.Services.AddDbContext<FilmDBContext>(options =>
            {
                options.UseSqlServer(builder.Configuration["ConnectionStrings:CatalogueJoueursDbContextConnection"]);
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

            app.UseSession();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            InitBd.Seed(app);

            app.Run();
        }
    }
}