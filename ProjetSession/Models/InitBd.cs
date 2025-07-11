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
        new Film("Fury", "https://m.media-amazon.com/images/M/MV5BMjA4MDU0NTUyN15BMl5BanBnXkFtZTgwMzQxMzY4MjE@._V1_.jpg", 7.99m),
        new Film("Inception", "https://m.media-amazon.com/images/I/51zUbui+gbL._AC_.jpg", 6.99m),
        new Film("Interstellar", "https://m.media-amazon.com/images/I/91kFYg4fX3L._AC_SL1500_.jpg", 8.49m),
        new Film("The Dark Knight", "https://m.media-amazon.com/images/I/51k0qaipALL._AC_.jpg", 7.49m),
        new Film("Gladiator", "https://m.media-amazon.com/images/I/71pA0Xf93-L._AC_SY679_.jpg", 6.49m),
        new Film("The Matrix", "https://m.media-amazon.com/images/I/51vpnbwFHrL._AC_.jpg", 5.99m),
        new Film("Titanic", "https://m.media-amazon.com/images/I/51rggtPgmRL._AC_.jpg", 6.99m),
        new Film("Avengers: Endgame", "https://m.media-amazon.com/images/I/81ExhpBEbHL._AC_SL1500_.jpg", 8.99m),
        new Film("Joker", "https://m.media-amazon.com/images/I/71X5pV6B6nL._AC_SL1178_.jpg", 7.49m),
        new Film("Shrek", "https://m.media-amazon.com/images/I/61V5Z5v7iQL._AC_SY679_.jpg", 5.49m),
        new Film("Toy Story", "https://m.media-amazon.com/images/I/81IrLRqTL6L._AC_SY679_.jpg", 4.99m)
    };

        public static async Task Seed(IApplicationBuilder applicationBuilder)
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

                //TODO : 7. Récupérer les services de Identity
                //TODO : 8. Créer le rôle Admin s'il n'existe pas
                //TODO : 9. Créer l'utilisateur admin@cegep.ca s'il n'existe pas, avec toutes les données nécessaires,
                       // utiliser la variable password_hash fournie, qui correspond à "P@ssword1!"
                string password_hash = "AQAAAAIAAYagAAAAEKIGTLGlONvlt8tfU2xKzSgFq6lbIFmLCZlkCer5P50YanaW0u7N5DFSaZuQOo46uw==";
                
                //TODO : 10. Assigner le rôle Admin à l'utilisateur

            }
        }


    }
}
