using EFCodeFirstApp.Model;
using EFCodeFirstApp.UI.DataAccessUI;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCodeFirstApp.UI.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly ITDataAccess _dataAccess;

        public DetailsModel(ITDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Book Book { get; set; }

        public void OnGet(int id)
        {
            Book = _dataAccess.GetById(id);
        }
    }
}
