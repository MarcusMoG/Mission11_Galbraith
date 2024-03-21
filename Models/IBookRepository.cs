namespace Mission11_Galbraith.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book>Books{  get; }
    }
}
