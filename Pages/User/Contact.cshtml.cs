using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageWeb.Models;

namespace RazorPageWeb.Pages.User
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public Contact contact { get; set; }

        public ContactModel()
        {
            contact = new Contact();
        }
        public string thongbao {  get; set; }

        public void OnPost()
        {
            thongbao = ModelState.IsValid ? "Valid" : "Invalid"; 
        }

        public void OnGet()
        {
        }
    }
}
