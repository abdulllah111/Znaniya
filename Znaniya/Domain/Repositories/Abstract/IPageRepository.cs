using Znaniya.Domain.Entities;

namespace Znaniya.Domain.Repositories.Abstract
{
    public interface IPageRepository
    {
        IQueryable<Page> GetPages();
        Page GetPageById(Guid id);
        IQueryable<Page> GetPagesByChapterId(Guid id);
        void SavePage(Page entity);
        void DeletePage(Guid id);
    }
}