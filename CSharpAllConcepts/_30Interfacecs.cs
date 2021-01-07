using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    interface ICustomer1
    {
        void Print1();
    }
    interface ICustomer2
    {
        void Print2();
    }

    public class Customerss : ICustomer1, ICustomer2
    {
        public void Print1()
        {
            Console.WriteLine("1");
        }

        public void Print2()
        {
            Console.WriteLine("2");
        }
    }

    public class _30Interfacecs
    {
        public static void Main()
        {
            Customerss c1 = new Customerss();
            c1.Print1();
            c1.Print2();
        }
    }
}
