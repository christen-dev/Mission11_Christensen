using Microsoft.EntityFrameworkCore;

namespace Mission11_Christensen.Models
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }

    }
}
