using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorContactManagement.Models;

namespace RazorContactManagement.Pages
{
    public class ViewContactModel : PageModel
    {
        contactsdbContext dc = new contactsdbContext();
        public List<Contact> li = new List<Contact>();
        public void OnGet()
        {
            li = (from t in dc.Contacts select t).ToList();
           
        }
    }
}
