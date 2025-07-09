namespace ProjetSession.Models
{
    public class MemRepJoueurs : IRepLocations
    {
        List<Film> lstJoueurs = new List<Film> {
            new Film(1,"Bob"),
            new Film(2,"Jessy")
        };
        public List<Film> LesJoueurs()
        {
            return lstJoueurs;
        }
        public Film GetJoueur(int joueurId)
        {
            Film joueur = lstJoueurs.FirstOrDefault(j  => j.Id == joueurId);
            return joueur;
        }
        public void AjouterJoueur(Film joueur)
        {
            lstJoueurs.Add(joueur);
        }
        public void ModifierJoueur(int joueurId, Film joueur)
        {
            Film joueurExistant = lstJoueurs.FirstOrDefault(j => j.Id == joueurId);
            if (joueurExistant != null)
            {
                joueurExistant.Id = joueur.Id;
                joueurExistant.Nom = joueur.Nom;
                // Ajoutez ici toutes les autres propriétés à mettre à jour
            }
            //2e facon
            int i = lstJoueurs.IndexOf(GetJoueur(joueurId));
            lstJoueurs[i] = joueur;
        }
        public void DeleteJoueur(int joueurId)
        {
            lstJoueurs.Remove(GetJoueur(joueurId));
        }
    }
}
