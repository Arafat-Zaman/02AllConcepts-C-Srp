using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    interface IA
    {
        void printA();
    }
    class AA: IA
    {
        public void printA()
        {
            Console.WriteLine("A");
        }
    }
    interface IB
    {
        void printB();
    }
    class BB : IB
    {
        public void printB()
        {
            Console.WriteLine("B");
        }
    }

    class AABB : IA, IB
    {
        AA a = new AA();
        BB b = new BB();

        public void printA()
        {
            a.printA();
        }
        public void printB()
        {
            b.printB();
        }
    }

    class _35Multipleinheritancofclass
    {
        //public static void Main()
        //{
            public static void test()
            {
                AABB aabb = new AABB();
            aabb.printA();
            aabb.printB();
        }
       
    }
}
