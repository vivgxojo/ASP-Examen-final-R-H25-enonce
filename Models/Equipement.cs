namespace ProjetSession.Models
{
    public class Equipement
    {
        public int Id { get; set; } // clé primaire
        public string Name { get; set; } 
        public int JoueurId { get; set; } //clé etrangere
        public Film joueur{ get; set; } //navigation
    }
}
