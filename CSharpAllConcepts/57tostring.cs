using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    class _57tostring
    {
        public static void Main()
        {
            int Number = 10;
            Console.WriteLine(Number.ToString());

            CutomerT c1 = new CutomerT();
            c1.FirstName = "A";
            c1.LastName = "B";

            Console.WriteLine(c1.ToString());
        }
        
    }
    public class CutomerT
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
