using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    public class _52Attribute
    {
        [Obsolete]
        public static int AddN(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }
        public static int AddN(List<int> Numbers)
        {
            int Sum = 0;
            foreach(int number in Numbers)
            {
                Sum = Sum + number;
            }
            return Sum;
        }
    }
    public class MainClas
    {
        //public static void Main()
        //{
            public static void test()
            {
                _52Attribute.AddN(new List<int>{10,20,40});
        }

    }
   
}
