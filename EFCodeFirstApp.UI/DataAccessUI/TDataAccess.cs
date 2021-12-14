using EFCodeFirstApp.DataAccess;
using EFCodeFirstApp.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EFCodeFirstApp.UI.DataAccessUI
{
    public class TDataAccess : ITDataAccess
    {
        private readonly TDbContext _tDbContext;

        public TDataAccess(TDbContext tDbContext)
        {
            _tDbContext = tDbContext;
        }
        public IEnumerable<Book> GetBooks()
        {
            return _tDbContext.Books.ToList();
        }

        public Book GetById(int id)
        {
            return _tDbContext.Books.AsNoTracking().Single(e => e.Id == id);
        }

        public void SaveAsync(Book book)
        {
            //Retrieve the object first, then update it!
            var b = _tDbContext.Books.SingleOrDefault(b => b.Id == book.Id);
            //CloneIt Method exists in the book model for the purposes of updating object
            //before it is saved into the database
            b.CloneIt(book);
            
            //_tDbContext.Entry(book).State = EntityState.Modified;
            _tDbContext.SaveChanges();
        }
    }
}
