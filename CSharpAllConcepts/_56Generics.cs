using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    class _56Generics
    {
        //public static void Main()
        //{
            public static void test()
            {
                bool Equal = Calculator.AreEqual<int>(10, 10);
            if(Equal)
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
    public class Calculator
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
