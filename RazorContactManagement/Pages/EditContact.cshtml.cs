using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorContactManagement.Models;
using System.Security.Cryptography;

namespace RazorContactManagement.Pages
{
    public class EditContactModel : PageModel
    {
        contactsdbContext dc = new contactsdbContext();

        [BindProperty]
        public int Contactid { get; set; }
        public string result;

      public  Contact c = new Contact();   
        public void OnGet(string cid)
        {//get methodi is called when user request the page
         //to read from the server use get method
            Contactid = int.Parse(cid);

            var res = (from t in dc.Contacts
                       where t.Contactid == Contactid
                       select t).First();
            c = res;
        }
        
        public void OnPost(Contact c) { 
               //this will only called when u submit the page
               //use post method to send the data to server
                dc.Contacts.Update(c);
                var i = dc.SaveChanges();


                if (i > 0)
                {
                    result = " Contactid updated Successfully!!";
                }
                else
                {
                    result = "Could not update try again!!";
                }
            }
        
    }
}
