namespace ProjetSession.Models
{
    public static class InitBd
    {
        static List<Film> lstFilms = new List<Film> {
        new Film("The Lion King", "https://m.media-amazon.com/images/M/MV5BMjIwMjE1Nzc4NV5BMl5BanBnXkFtZTgwNDg4OTA1NzM@._V1_FMjpg_UX1000_.jpg", 5.99m),
        new Film("Avatar", "https://m.media-amazon.com/images/M/MV5BZDA0OGQxNTItMDZkMC00N2UyLTg3MzMtYTJmNjg3Nzk5MzRiXkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_FMjpg_UX1000_.jpg", 7.99m),
        new Film("Scream 3", "https://i.ebayimg.com/images/g/XuQAAOSwURpj0R6L/s-l1600.jpg", 6.99m),
        new Film("Fast & Furious 6", "https://m.media-amazon.com/images/M/MV5BMTM3NTg2NDQzOF5BMl5BanBnXkFtZTcwNjc2NzQzOQ@@._V1_.jpg", 5.99m),
        new Film("Lord of the Rings", "https://m.media-amazon.com/images/M/MV5BN2EyZjM3NzUtNWUzMi00MTgxLWI0NTctMzY4M2VlOTdjZWRiXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_.jpg", 5.99m),
        new Film("Fury", "https://m.media-amazon.com/images/M/MV5BMjA4MDU0NTUyN15BMl5BanBnXkFtZTgwMzQxMzY4MjE@._V1_.jpg", 7.99m)
        };

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<fl_DBContext>();
                
                // Ajouter des films si la table est vide
                if (!context.Films.Any())
                {
                    context.Films.AddRange(lstFilms);
                    context.SaveChanges();
                }

                //TODO : 1. Récupérer les services de Identity
                //TODO : 2. Créer le rôle Admin s'il n'existe pas
                //TODO : 3. Créer l'utilisateur admin@cegep.ca s'il n'existe pas, avec toutes les données nécessaires,
                       // utiliser la variable password_hash fournie, qui correspond à "P@ssword1!"
                string password_hash = "AQAAAAIAAYagAAAAEKIGTLGlONvlt8tfU2xKzSgFq6lbIFmLCZlkCer5P50YanaW0u7N5DFSaZuQOo46uw==";
                
                //TODO : 4. Assigner le rôle Admin à l'utilisateur

            }
        }


    }
}
