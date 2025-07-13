using ProjetSession.Models;
using Microsoft.AspNetCore.Mvc;

namespace ProjetSession.Controllers
{
    //TODO : 20. Ajouter les autorisations nécessaires pour que :
            //seul l'admin puisse supprimer des films;
            //tout le monde peut afficher la liste et les détails des films.

    public class HomeController : Controller
    {
        IRepFilms FilmsRep;

        /// <summary>
        /// Constructeur du contrôleur Home
        /// </summary>
        /// <param name="repFilms">Référentiel des films</param>
        public HomeController(IRepFilms repFilms)
        {
            this.FilmsRep = repFilms;
        }

        /// <summary>
        /// Affiche la page d'accueil avec la liste des films
        /// </summary>
        /// <returns>La vue de la page d'accueil</returns>
        public IActionResult Index()
        {
            //TODO : 19. Modifier cette méthode pour permettre :
                    // la recherche des films en écrivant une partie de leur nom dans la barre de recherche
            

            return View(FilmsRep.LesFilms());
        }

        /// <summary>
        /// Affiche les détails d'un film
        /// </summary>
        /// <param name="id">L'identifiant du film</param>
        /// <returns>La vue des détails du film</returns>
        public IActionResult Detail(int id)
        {
            var film = FilmsRep.GetFilm(id);
            return View(film);
        }


        /// <summary>
        /// Supprime un film
        /// </summary>
        /// <param name="id">L'identifiant du film à supprimer</param>
        /// <returns>Redirige vers l'index</returns>
        [HttpGet]
        public IActionResult Delete(int id)
        {
            FilmsRep.DeleteFilm(id);
            return RedirectToAction("Index");
        }

    }
}
