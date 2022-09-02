namespace WebApplication1.Models
{
    public class BookModelView
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }

        public BookModelView(string name, string author, int numberOfPages)
        {
            Name = name;
            Author = author;
            NumberOfPages = numberOfPages;
        }
    }
}
