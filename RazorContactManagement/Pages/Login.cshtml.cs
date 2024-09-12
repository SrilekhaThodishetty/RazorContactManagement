using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorContactManagement.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string uname { get; set; }
        [BindProperty]

        public string pwd { get; set; }
        public void OnGet()
        {
        }
        public string errormessage;
        public IActionResult Onpost()
        {

            if (uname=="admin" && pwd =="india")
            {
                return RedirectToPage("ViewContact");
            }
            else
            {
                errormessage = "invalid credentials";
                return Page();
            }

        }
    }
}
