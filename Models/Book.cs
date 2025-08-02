namespace Library.Models
{
    public class Book
    {
        public int AuthorId { get; set; }
        
        public string Title { get; set; }
        
        public int ISBN { get; set; }

        public Author Writer { get; set; }
    }
}


