namespace DemoRepPattern.Models
{
    public class Joueur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public List<Equipement> Equipements { get; set; } //Navigation
        public Joueur(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }
        public Joueur(string nom)
        {
            Nom = nom;
        }
        public Joueur() { }
    }
}
