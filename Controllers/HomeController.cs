using ProjetSession.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using NuGet.Protocol;
using System.Diagnostics;

namespace ProjetSession.Controllers
{
    public class HomeController : Controller
    {
        IRepJoueurs JoueurRep;

        public HomeController(IRepJoueurs repJoueurs)
        {
            this.JoueurRep = repJoueurs;
        }

        public IActionResult Index()
        {
            // utilisation du session storage
            int compteur = 0;

            if(HttpContext.Session.Keys.Contains("compteur"))
            {
                compteur = (int)HttpContext.Session.GetInt32("compteur");
            }
            compteur++;
            HttpContext.Session.SetInt32("compteur", compteur);

            ViewBag.Compteur = compteur;

            // get les joueurs additionnels du session storage
            var value = HttpContext.Session.GetString("joueur");

            Film? joueurStorage = null;

            if (value != null) joueurStorage = JsonConvert.DeserializeObject<Film>(value);

            if (joueurStorage != null) JoueurRep.AjouterJoueur(joueurStorage);

            return View(JoueurRep.LesJoueurs());
        }

        public IActionResult Detail(int id)
        {
            return View(JoueurRep.GetJoueur(id));
        }

        /// <summary>
        /// Afficher le formulaire d'ajout
        /// </summary>
        /// <returns>le formulaire d'ajout</returns>
        [HttpGet]
        public IActionResult Ajouter()
        {
            return View();
        }
        /// <summary>
        /// Ajouter un joueur a la liste
        /// </summary>
        /// <param name="joueur">le joueur a ajouter qui vient du formulaire</param>
        /// <returns>retourne a lindex</returns>
        [HttpPost]
        public IActionResult Ajouter(Film joueur)
        {
            JoueurRep.AjouterJoueur(joueur);

            // utilisation du session storage

            if (HttpContext.Session.Keys.Contains("joueur"))
            {
                HttpContext.Session.SetString("joueur", JsonConvert.SerializeObject(joueur));
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            JoueurRep.DeleteJoueur(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Film joueur = JoueurRep.GetJoueur(id);
            return View(joueur);
        }
        [HttpPost]
        public IActionResult Edit(int oldid, Film joueur)
        {
            JoueurRep.ModifierJoueur(oldid, joueur);
            return RedirectToAction("Index");
        }

        public IActionResult ClearSession()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}