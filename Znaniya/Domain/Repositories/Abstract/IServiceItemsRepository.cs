using Znaniya.Domain.Entities;

namespace Znaniya.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextFieldById(int id);
        TextField GetTextFieldByCodeWord(string codeWord);
        void SaveTextFlield(TextField entity);
        void DeleteTextFlield(Guid id);

    }
}
