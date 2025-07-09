using Microsoft.EntityFrameworkCore;

namespace ProjetSession.Models
{
    public class BdRepJoueurs : IRepLocations
    {
        FilmDBContext dbContext;
        public BdRepJoueurs(FilmDBContext db)
        {
            dbContext = db;
        }
        public List<Film> LesJoueurs()
        {
            return dbContext.Joueurs.ToList();
        }
        public Film GetJoueur(int joueurId)
        {
            Film joueur = dbContext.Joueurs.Include(j => j.Equipements).FirstOrDefault(j => j.Id == joueurId);
            return joueur;
        }
        public void AjouterJoueur(Film joueur)
        {
            dbContext.Joueurs.Add(joueur);
            dbContext.SaveChanges();
        }
        public void ModifierJoueur(int joueurId, Film joueur)
        {
            dbContext.Joueurs.Update(joueur);
            dbContext.SaveChanges();
        }
        public void DeleteJoueur(int joueurId)
        {
            if (LesJoueurs().Count > 1) 
            {
                dbContext.Joueurs.Remove(GetJoueur(joueurId));
                dbContext.SaveChanges();
            }
        }
    }
}
