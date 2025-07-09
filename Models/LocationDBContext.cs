using Microsoft.EntityFrameworkCore;

namespace ProjetSession.Models
{
    public class FilmDBContext : DbContext
    {
        public FilmDBContext(DbContextOptions<FilmDBContext> options)
            : base(options) { }
        public DbSet<Film> Joueurs { get; set;}
        public DbSet<Equipement> Equipements { get; set;}
    }
}
