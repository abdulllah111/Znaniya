using Znaniya.Domain.Entities;

namespace Znaniya.Domain.Repositories.Abstract
{
    public interface IBooksRepository
    {
        IQueryable<Book> GetBooks();
        Book GetBookById(Guid id);
        void SaveBook(Book entity);
        void DeleteBook(Guid id);
    }
}
