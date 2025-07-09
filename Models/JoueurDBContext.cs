using Microsoft.EntityFrameworkCore;

namespace DemoRepPattern.Models
{
    public class JoueurDBContext : DbContext
    {
        public JoueurDBContext(DbContextOptions<JoueurDBContext> options)
            : base(options) { }
        public DbSet<Joueur> Joueurs { get; set;}
        public DbSet<Equipement> Equipements { get; set;}
    }
}
