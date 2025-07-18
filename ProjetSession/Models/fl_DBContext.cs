using Projet_Session.Models;

namespace ProjetSession.Models
{
    //TODO : 2. Installer les packet NuGet pour EntityFramework, Identity et la Session.
    //TODO : 4. Créer une première migration
    //TODO : 5. Implémenter l'authentification
    //TODO : 6. Créer une deuxième migration

    public class fl_DBContext : DbContext
    {
        public fl_DBContext(DbContextOptions<fl_DBContext> options)
            : base(options)
        {
        }

        public DbSet<Film> Films { get; set; }
        public DbSet<Location> Locations { get; set; }

    }
}
