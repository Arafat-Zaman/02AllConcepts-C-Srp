using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    public abstract class Cus
    {
        public abstract void Print();
    }

    class _32Abstractclass : Cus
    {
        public override void Print()
        {
            Console.WriteLine("test");
        }

        public static void Main()
        {
            Cus c1 = new _32Abstractclass();
            c1.Print();
        }

        
    }
}
