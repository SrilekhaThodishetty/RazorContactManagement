using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorContactManagement.Models;

namespace RazorContactManagement.Pages
{
    public class AddContactsModel : PageModel
    {
        contactsdbContext dc = new contactsdbContext();
        public string result { get; set; }

        public void OnPost(Contact c)
        {
            dc.Contacts.Add(c);
            int i = dc.SaveChanges();
            if(i>0)
            {
                  result = "New Contact Added Successfully!!";
            }
            else
            {
                  result = "Could not contact try again!!";
            }
        }

        
    }
}
