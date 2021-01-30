using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    class _58overrideequals
    {
        public static void Main()
        {
            CustomerW c1 = new CustomerW();
            c1.FirstName = "A";
            c1.LastName = "B";

            CustomerW c2 = c1;

            Console.WriteLine(c1==c2);
            Console.WriteLine(c1.Equals(c2));
        }
    }

    public enum Direction
    {
        East=1,
        West=2,
        North=3,
        South=4
    }
    public class CustomerW
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
