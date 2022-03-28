using Znaniya.Domain.Entities;
using System;
using System.Linq;
using Znaniya.Domain.Repositories.Abstract;

namespace Znaniya.Domain.Repositories.EntityFramework
{
    public class EFTextFieldsRepository : ITextFieldsRepository
    {
        public IQueryable<TextField> GetTextFields()
        {
            throw new NotImplementedException();
        }
    }
}
