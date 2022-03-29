using Znaniya.Domain.Repositories.Abstract;

namespace Znaniya.Domain
{
    public class DataManager
    {
        public IShelfsRepository Shelfs { get; set; }
        public IBooksRepository Books { get; set; }
        public IChaptersRepository Chapters { get; set; }
        public IPageRepository Pages { get; set; }
        public DataManager(IShelfsRepository shelfsRepository, IBooksRepository booksRepository, IChaptersRepository chaptersRepository, IPageRepository pagesRepository
)
        {
            Shelfs = shelfsRepository;
            Books = booksRepository;
            Chapters = chaptersRepository;
            Pages = pagesRepository;
        }
    }
}
