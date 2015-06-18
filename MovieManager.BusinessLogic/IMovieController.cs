using NHibernate;

namespace MovieManager.BusinessLogic
{
    interface IMovieController
    {
        void UpdateMovie(MovieManager.Data.Domains.IMovie movie);
    }
}
