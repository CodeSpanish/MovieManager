namespace MovieManager.Data.Domains
{
    public class Movie: IMovie
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Country { get; set; }
    }
}
