using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCodeFirstApp.Model;
using EFCodeFirstApp.UI.DataAccessUI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCodeFirstApp.UI.Pages
{
    public class EditModel : PageModel
    {
        private readonly ITDataAccess _dataAccess;

        public EditModel(ITDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        [BindProperty]
        public Book Book { get; set; }
        [BindProperty]
        public string Feedback { get; set; }

        public void OnGet(int id)
        {
            Book = _dataAccess.GetById(id);
        }

        public IActionResult OnPostUpdate()
        {
            if (ModelState.IsValid)
            {
                _dataAccess.SaveAsync(Book);
                Feedback = "Book Updated";
                return Page();    
                
            }
            return Page();
        }
    }
}
