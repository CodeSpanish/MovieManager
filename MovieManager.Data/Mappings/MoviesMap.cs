using FluentNHibernate.Mapping;

namespace MovieManager.Data.Mappings
{
    public class MovieMap: ClassMap<MovieManager.Data.Domains.Movie>
    {
        public MovieMap()
        {
            Id(c => c.Id);
            Map(c => c.Title);
            Map(c => c.Country);
        }
    }
}
