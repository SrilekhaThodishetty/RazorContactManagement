using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorContactManagement.Pages
{

    public class IndexModel : PageModel
    {
        [BindProperty]
       
        public int res { get; set; }

        public List<students> li = new List<students>()
{
     new students(){ sid=100, studentname="raj", totalmarks= 90 },
      new students(){ sid=200, studentname="srilekha", totalmarks= 91 },
      new students(){ sid=300, studentname="hemsri", totalmarks= 92 },


};
       
    }
    public class students
    {

        public int sid { get; set; }
        public string studentname { get; set; }
        public int totalmarks { get; set; }
    }
    public class mycls
    {
        public int txt1 { get; set; }
        public int txt2 { get; set; }

    }
}