using MovieManager.Data.Domains;
using NHibernate;

namespace MovieManager.BusinessLogic
{
    public class MovieController: IMovieController
    {
        private readonly ISessionFactory _sessionFactory;

        public MovieController(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }
        
        public void UpdateMovie(IMovie movie)
        {
            using (var session = _sessionFactory.OpenSession())
            {
                session.SaveOrUpdate(movie);
            }
        }
    }
}
