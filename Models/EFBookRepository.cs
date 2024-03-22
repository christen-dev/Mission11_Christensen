
namespace Mission11_Christensen.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookStoreContext _context;

        public EFBookRepository(BookStoreContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
