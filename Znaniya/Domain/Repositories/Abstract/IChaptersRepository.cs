using Znaniya.Domain.Entities;
namespace Znaniya.Domain.Repositories.Abstract
{
    public interface IChaptersRepository
    {
        IQueryable<Chapter> GetChapters();
        Chapter GetChapterById(Guid id);
        IQueryable<Chapter> GetChaptersByBookId(Guid id);
        void SaveChapter(Chapter entity);
        void DeleteChapter(Guid id);
    }
}
