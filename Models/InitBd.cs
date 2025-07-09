namespace ProjetSession.Models
{
    public static class InitBd
    {
        static List<Film> lstJoueurs = new List<Film> {
            new Film("Bob"),
            new Film("Jessy")
        };

        public static List<Equipement> lstEquipements = new List<Equipement>{
            new Equipement()
            {
                Name = "Casque",
                JoueurId = 1
            },
            new Equipement()
            {
                Name = "Casque",
                JoueurId = 2
            },
            new Equipement()
            {
                Name = "Souliers",
                JoueurId = 2
            }
        };
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            // On ne peut pas utiliser l'injection de dépendances ici, 
            // le DbContext CatalogueGateauxDbContext sera donc récupéré à partir de applicationBuilder.
            FilmDBContext context =
            applicationBuilder.ApplicationServices.CreateScope()
            .ServiceProvider.GetRequiredService<FilmDBContext>();

            if (!context.Joueurs.Any())
            {
                context.Joueurs.AddRange(lstJoueurs);
            }

            context.SaveChanges();

            if (!context.Equipements.Any())
            {
                context.Equipements.AddRange(lstEquipements);
            }

            context.SaveChanges();
        }

    }
}
