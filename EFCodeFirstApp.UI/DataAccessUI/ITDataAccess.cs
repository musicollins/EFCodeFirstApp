using EFCodeFirstApp.Model;
using System.Collections.Generic;

namespace EFCodeFirstApp.UI.DataAccessUI
{
    public interface ITDataAccess
    {
        IEnumerable<Book> GetBooks();
        Book GetById(int id);
        void SaveAsync(Book book);
    }
}