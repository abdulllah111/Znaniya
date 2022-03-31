using Znaniya.Domain.Entities;
using System;
using System.Linq;
using Znaniya.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Znaniya.Domain.Repositories.EntityFramework
{
    public class EFChaptersRepository : IChaptersRepository
    {
        private readonly AppDbContext context;
        public EFChaptersRepository(AppDbContext context)
        {
            this.context = context!;
        }
        public void DeleteChapter(Guid id)
        {
            context.Chapters!.Remove(new Chapter() { ChapterId = id });
            context.SaveChanges();
        }

        public Chapter GetChapterById(Guid id)
        {
            return context.Chapters!.FirstOrDefault(x => x.ChapterId == id)!;
        }
        public IQueryable<Chapter> GetChaptersByBookId(Guid id)
        {
            return context.Chapters!.Where(x => x.BookID == id)!;
        }
        public IQueryable<Chapter> GetChapters()
        {
            return context.Chapters!;
        }

        public void SaveChapter(Chapter entity)
        {
            if (entity.ChapterId == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
