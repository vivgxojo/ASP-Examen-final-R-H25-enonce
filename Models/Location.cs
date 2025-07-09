namespace ProjetSession.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public List<Equipement> Equipements { get; set; } //Navigation
        public Location(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }
        public Location(string nom)
        {
            Nom = nom;
        }
        public Location() { }
    }
}
