namespace DemoProject.Data.DataModels
{
    public class Movie
    {
        public string Id { get; set; }
        public int Rating { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Duration { get; set; }
        public List<AuthorMovies> AuthorMovies { get; set; }
    }
}
