using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorContactManagement.Models;

namespace RazorContactManagement.Pages
{
    public class DeleteContactModel : PageModel
    {
        contactsdbContext dc = new contactsdbContext();
        public string a;
        public string result;
        public void OnGet(string cid)
        {
            a = cid;
            int id = int.Parse(a);
            var res = (from t in dc.Contacts
                       where t.Contactid == id
                       select t).First();
            dc.Remove(res);
            var i = dc.SaveChanges();


            if (i > 0)
            {
                result = " Contactid deleted Successfully!!";
            }
            else
            {
                result = "Could not delete try again!!";
            }
        }
    }
}
