using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    class _25Methodoverloading
    {
        public static void Main()
        {
            //Add()
        }

        public static void Add(int FN, int SN)
        {
            Console.WriteLine("{0}",FN+SN);
        }
        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine("{0}", FN + SN+ TN);
        }
    }


   
}
