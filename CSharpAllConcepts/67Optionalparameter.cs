using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    class _67Optionalparameter
    {
        public static void Main()
        {
            AddNumber(10,20,30);

        }

        public static void AddNumber(int FirstNumber, int SecondNumber, params object[] restofNumbers)
        {
            int result = FirstNumber + SecondNumber;

            if(restofNumbers!=null)
            {
                foreach(int i in restofNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum= " + result);
        }

    }

   
}
