using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.DataAccessLayer
{
    public class LibraryDbContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public LibraryDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
