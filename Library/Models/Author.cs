using System.Collections.Generic;

namespace Library.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => FirstName + " " + LastName;
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
