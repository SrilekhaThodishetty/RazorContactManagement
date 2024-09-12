using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestingRazorPrj.Pages
{
    public class MyPageModel : PageModel
    {
        public string result;
        public void OnGet()
        {
            int a = 10;
            int b = 2;
            int c = a / b;
            result = "the divide is " + c;
        }
    }
}
