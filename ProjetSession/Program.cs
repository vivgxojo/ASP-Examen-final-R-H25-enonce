using ProjetSession.Models;

namespace ProjetSession
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IRepFilms, DBRepFilms>();
            builder.Services.AddScoped<IRepLocations, DBRepLocations>();

            builder.Services.AddSession();

            // TODO : 3. Ajouter les services pour la base de donn�es et l'authentification avec les r�les.

            
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // TODO : 22. Impl�menter la gestion globale des erreurs


            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // Configure the HTTP request pipeline.
            else
            {
                app.UseStatusCodePagesWithReExecute("/Error/Index");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSession();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            await InitBd.Seed(app);

            app.MapRazorPages(); // Ensure Razor Pages are mapped

            app.Run();
        }
    }
}

//TODO : 23. D�ployer l'application, incluant la BD, sur Azure:
    // Copier-coller votre URL ici et laisser le site actif jusqu'� ce que vous receviez votre note finale.
    // URL :
         // _______________________________________________________________________________________________
