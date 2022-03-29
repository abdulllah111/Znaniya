using Znaniya.Domain.Entities;
using System;
using System.Linq;
using Znaniya.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Znaniya.Domain.Repositories.EntityFramework
{
    public class EFBooksRepository : IBooksRepository
    {
        private readonly AppDbContext context;
        public EFBooksRepository(AppDbContext context)
        {
            this.context = context!;
        }

        public IQueryable<Book> GetBooks()
        {
            return context.Books!;
        }

        public Book GetBookById(Guid id)
        {
            return context.Books!.FirstOrDefault(x => x.BookID == id)!;
        }

        public void SaveBook(Book entity)
        {
            if (entity.BookID == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteBook(Guid id)
        {
            context.Books!.Remove(new Book() { BookID = id });
            context.SaveChanges();
        }
    }
}
