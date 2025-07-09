namespace ProjetSession.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; } // clé étrangère
        public DateTime DateLocation { get; set; }
        public List<Film> FilmsLouer { get; set; } // Navigation

        public Location(string nom)
        {
            Nom = nom;
            DateLocation = DateTime.Now;
        }
        public Location() { }
    }
}
