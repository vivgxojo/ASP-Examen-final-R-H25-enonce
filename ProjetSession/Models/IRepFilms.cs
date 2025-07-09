namespace ProjetSession.Models
{
    public interface IRepFilms
    {
        List<Film> LesFilms();
        Film GetFilm(int filmId);
        void NouveauFilm(Film film);
        void ModifierFilm(int filmId, Film film);
        void DeleteFilm(int filmId);
    }
}
