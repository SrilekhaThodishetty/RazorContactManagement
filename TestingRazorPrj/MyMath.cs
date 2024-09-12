namespace TestingRazorPrj
{
public interface IMyinter

    {

        string AddNums(int num1, int num2);

        string DivideNums(int num1, int num2);

        string displayguid();

    }

    public class MyMathCls : IMyinter

    {

        Guid g;

        public MyMathCls()

        {

            g = Guid.NewGuid();

        }

        public string displayguid()

        {

            return g.ToString();

        }

        public string AddNums(int num1, int num2)

        {

            return "The sums is " + (num1 + num2);

        }

        public string DivideNums(int num1, int num2)

        {

            return "The Division is " + (num1 / num2);

        }

    }



    // seperate object is created for every request

    //builder.Services.AddTransient();

    // single object is created for each user

    //builder.Services.AddScoped();

    // 1 object is used  by all the user    

    //builder.Services.AddSingleton();

}
