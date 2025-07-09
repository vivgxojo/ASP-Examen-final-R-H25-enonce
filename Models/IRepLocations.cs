namespace ProjetSession.Models
{
    public interface IRepLocations
    {
        List<Film> LesJoueurs();
        Film GetJoueur(int joueurId);
        void AjouterJoueur(Film joueur);
        void ModifierJoueur(int joueurId, Film joueur);
        void DeleteJoueur(int joueurId);
    }
}
