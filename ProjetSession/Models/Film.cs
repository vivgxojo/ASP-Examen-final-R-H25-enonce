using System.ComponentModel.DataAnnotations;

namespace ProjetSession.Models
{
    public class Film
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La nom est obligatoire")]
        public string? Nom { get; set; }

        [Required(ErrorMessage = "L'url image est obligatoire")]
        public string? ImageUrl { get; set; }

        [Required(ErrorMessage = "Le prix est obligatoire")]
        public decimal? Prix { get; set; }
        public List<Location> Locations { get; set; } //Navigation
        public Film(string nom, string imageUrl)
        {
            Nom = nom;
            ImageUrl = imageUrl;
        }
        public Film(string nom, string imageUrl, decimal prix)
        {
            Nom = nom;
            ImageUrl = imageUrl;
            Prix = prix;
        }
        public Film(string nom)
        {
            Nom = nom;
        }
        public Film() { }
    }
}
