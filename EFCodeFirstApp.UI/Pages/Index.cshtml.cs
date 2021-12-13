using EFCodeFirstApp.Model;
using EFCodeFirstApp.UI.DataAccessUI;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace EFCodeFirstApp.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ITDataAccess _dataAccess;

        public IndexModel(ITDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public IEnumerable<Book> Books { get; set; }

        public void OnGet()
        {
            Books = _dataAccess.GetBooks();
        }
    }
}
