using Znaniya.Domain.Repositories.Abstract;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Znaniya.Domain.Entities;

namespace Znaniya.Domain.Repositories.EntityFramework
{
    public class EFShelfsRepository : IShelfsRepository
    {
        private readonly AppDbContext context;
        public EFShelfsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Shelf> GetShelves()
        {
            return context.Shelfs!;
        }

        public Shelf GetShelfById(Guid id)
        {
            return context.Shelfs!.FirstOrDefault(x => x.ShelfID == id)!;
        }

        public void SaveShelf(Shelf entity)
        {
            if (entity.ShelfID == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteShelf(Guid id)
        {
            context.Shelfs!.Remove(new Shelf() { ShelfID = id });
            context.SaveChanges();
        }
    }
}
