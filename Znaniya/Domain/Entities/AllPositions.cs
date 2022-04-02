namespace Znaniya.Domain.Entities
{
    public class AllPositions
    {
        public IQueryable<Shelf>? Shelves { get; set; }
        public IQueryable<Book>? Books { get; set; }
        public IQueryable<Chapter>? Chapters { get; set; }
        public IQueryable<Page>? Pages { get; set; }
        public IQueryable<Book>? Boks { get; set; }
        public Shelf? Shelf { get; set; }
        public Book? Book { get; set; }
        public Chapter? Chapter { get; set; }
        public Page? Page { get; set; }
    }
}
