using Znaniya.Domain.Entities;
using System;
using System.Linq;
using Znaniya.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Znaniya.Domain.Repositories.EntityFramework
{
    public class EFPagesRepository : IPageRepository
    {
        private readonly AppDbContext context;
        public EFPagesRepository(AppDbContext context)
        {
            this.context = context!;
        }

        public void DeletePage(Guid id)
        {
            context.Pages!.Remove(new Page() { PageID = id });
            context.SaveChanges();
        }

        public Page GetPageById(Guid id)
        {
            return context.Pages!.FirstOrDefault(x => x.PageID == id)!;
        }

        public IQueryable<Page> GetPages()
        {
            return context.Pages!;
        }

        public void SavePage(Page entity)
        {
            if (entity.PageID == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
