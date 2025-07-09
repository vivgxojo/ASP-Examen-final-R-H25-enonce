namespace ProjetSession.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public List<Equipement> Equipements { get; set; } //Navigation
        public Film(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }
        public Film(string nom)
        {
            Nom = nom;
        }
        public Film() { }
    }
}
