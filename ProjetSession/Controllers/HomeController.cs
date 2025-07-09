using ProjetSession.Models;
using Microsoft.AspNetCore.Mvc;

namespace ProjetSession.Controllers
{
    //TODO : Ajouter les autorisations nécessaires pour que :
            //seul l'admin puisse créer, modifier et supprimer des films;
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
            //TODO : Modifier cette méthode pour permettre :
                    // la recherche des films en écrivant une partie de leur nom dans la barre de recherche
                    // la pagination qui affiche 5 films par pages.
            

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
        /// Affiche le formulaire d'ajout de film
        /// </summary>
        /// <returns>Le formulaire d'ajout</returns>
        [HttpGet]
        public IActionResult Ajouter()
        {
            return View();
        }

        /// <summary>
        /// Ajoute un nouveau film à la liste
        /// </summary>
        /// <param name="film">Le film à ajouter</param>
        /// <returns>Redirige vers l'index</returns>
        [HttpPost]
        public IActionResult Ajouter(Film film)
        {
            FilmsRep.NouveauFilm(film);
            return RedirectToAction("Index");
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

        /// <summary>
        /// Affiche le formulaire de modification d'un film
        /// </summary>
        /// <param name="id">L'identifiant du film à modifier</param>
        /// <returns>La vue du formulaire de modification</returns>
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Film joueur = FilmsRep.GetFilm(id);
            return View(joueur);
        }
        /// <summary>
        /// Modifie un film existant
        /// </summary>
        /// <param name="oldid">L'ancien identifiant du film</param>
        /// <param name="film">Le film modifié</param>
        /// <returns>Redirige vers l'index</returns>
        [HttpPost]
        public IActionResult Edit(int oldid, Film film)
        {
            FilmsRep.ModifierFilm(oldid, film);
            return RedirectToAction("Index");
        }

    }
}
