using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.InteropServices.JavaScript;

namespace TestingRazorPrj.Pages
{
    public class indiaModel : PageModel
    {
        // this page will only use the object

        //  MyMathCls ob = new MyMathCls();

        IMyinter i;
        IMyinter j;
        public indiaModel(IMyinter obj,IMyinter obj1, ILogger<indiaModel> l)
        {
            i = obj;
            j = obj1;
            l.LogInformation("India class access by the user on :" + DateTime.Now);

        }

        public string result;
        public void OnGet()
        {
            // result=  i.AddNums(10, 10);

            //  Guid g = Guid.NewGuid();
            result = i.displayguid()+" : "+j.displayguid();

        }
    }
}
