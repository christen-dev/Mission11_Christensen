namespace Mission11_Christensen.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
