namespace DemoProject.Data.DataModels
{
    public class Author
    {
        public string Id { get; set; }
        public string AuthorName { get; set; }
        public List<AuthorMovies> AuthorMovies { get; set; }
    }
}
