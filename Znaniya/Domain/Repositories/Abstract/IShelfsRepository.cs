using Znaniya.Domain.Entities;

namespace Znaniya.Domain.Repositories.Abstract
{
    public interface IShelfsRepository
    {
        IQueryable<Shelf> GetShelves();
        Shelf GetShelfById(Guid id);
        void SaveShelf(Shelf entity);
        void DeleteShelf(Guid id);
    }
}
