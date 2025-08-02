namespace Library.Models
{
    public class User
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string BorrowedBooks { get; set; }

        public Book Libro { get; set; }
    }
}

