using Microsoft.EntityFrameworkCore;

namespace ProjetSession.Models
{
    public class DBRepFilms : IRepFilms
    {
        fl_DBContext dbContext;
        public DBRepFilms(fl_DBContext db)
        {
            dbContext = db;
        }
        public List<Film> LesFilms()
        {
            return dbContext.Films.ToList();
        }
        public Film GetFilm(int filmId)
        {
            Film? film = dbContext.Films.FirstOrDefault(f => f.Id == filmId);
            return film;
        }
        public void NouveauFilm(Film film)
        {
            dbContext.Films.Add(film);
            dbContext.SaveChanges();
        }
        public void ModifierFilm(int Id, Film film)
        {
            dbContext.Films.Update(film);
            dbContext.SaveChanges();
        }
        public void DeleteFilm(int filmId)
        {
            if (LesFilms().Count > 1) 
            {
                dbContext.Films.Remove(GetFilm(filmId));
                dbContext.SaveChanges();
            }
        }

    }
}
