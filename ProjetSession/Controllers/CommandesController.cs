using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetSession.Models;

namespace ProjetSession.Controllers
{
    //TODO : 6. Ajouter les autorisations nécessaires pour que:
            // Tout le monde puisse remplir et voir son panier
            // Seul les usagés authentifiés puisse commander et obtenir une confirmation.

    public class CommandesController : Controller // Contrôleur pour les commandes/locations
    {
        IRepFilms FilmsRep;
        IRepLocations LocationsRep;

        /// <summary>
        /// Constructeur du contrôleur CommandesController
        /// </summary>
        /// <param name="repFilms">Référentiel des films</param>
        /// <param name="repLocations">Référentiel des locations</param>
        public CommandesController(IRepFilms repFilms,  IRepLocations repLocations)
        {
            FilmsRep = repFilms;
            LocationsRep = repLocations;
        }

        /// <summary>
        /// Action pour afficher la page de confirmation après une commande/location
        /// </summary>
        /// <returns>La vue de la page de confirmation</returns>
        public IActionResult Confirmation()
        {
            return View();
        }

        /// <summary>
        /// Action pour afficher le panier actuel
        /// </summary>
        /// <returns>La vue du panier</returns>
        public IActionResult Panier()
        {
            List<Film> panier = null;
            // TODO : Récupérer le panier de la session.

            if (panier == null)
            {
                panier = new List<Film>();
            }

            return View(panier);
        }

        /// <summary>
        /// Action pour ajouter un film au panier
        /// </summary>
        /// <param name="id">L'identifiant du film à ajouter au panier</param>
        /// <returns>Redirige vers la vue du panier</returns>
        public IActionResult AjouterPanier(int id)
        {
            List<Film> panier = null;
            var film = FilmsRep.GetFilm(id);

            // TODO : Récupérer le panier de la session.

            if (panier == null)
            {
                panier = new List<Film>();
            }

            panier.Add(film);
            

            //TODO : Sauvegarder le panier dans la session

            return RedirectToAction("Panier");
        }

        /// <summary>
        /// Affiche la page de checkout avec le form à remplir
        /// </summary>
        /// <returns>La vue de la page de checkout</returns>
        public IActionResult Checkout()
        {
            List<Film> panier = null;
            // TODO : Récupérer le panier de la session.

            if (panier == null)
            {
                panier = new List<Film>();
            }

            decimal total = (decimal)(panier?.Sum(s => s.Prix) ?? 0);

            ViewBag.Total = total;

            return View();
        }

        /// <summary>
        /// Action pour valider et effectuer la commande/location
        /// </summary>
        /// <param name="location">Les informations de la location/commande</param>
        /// <returns>Redirige vers la page de confirmation après ajout de la location</returns>
        [HttpPost]
        public IActionResult Checkout(Location location)
        {
            //TODO : Compléter cette méthode pour que la location soit sauvegardée dans la base de données.
            //TODO : Le panier doit aussi être vidé, puis redirger à la confirmation.
            //TODO : Ajouter des commentaires pour expliquer comment la location est sauvegardée.

            return null;
        }
    }
}
