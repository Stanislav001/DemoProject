namespace DemoProject.Data.DataModels
{
    public class AuthorMovies
    {
        public string Id { get; set; }
        public string AuthorId { get; set; }
        public Author Author { get; set; }
        public string BookId { get; set; }
        public Movie Movie { get; set; }
    }
}
