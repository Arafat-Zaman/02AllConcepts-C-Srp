using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    class _59Converttostringvstostring
    {
        public static void Main()
        {
            //CustomerC c1 = new CustomerC();
            CustomerC c1 = null;

            string str = c1.ToString();
            //string str = Convert.ToString(c1);

            Console.WriteLine(str);
        }
    }
    public class CustomerC
    {
        public string FirstName { get; set; }
    }
}
