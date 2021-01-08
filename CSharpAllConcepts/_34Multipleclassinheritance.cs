using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{

    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A");
        }
    }
    class B:A
    {
        public override void Print()
        {
            Console.WriteLine("B");
        }
    }
    class C: A
    {
        public override void Print()
        {
            Console.WriteLine("C");
        }
    }
    //class D: B, C
    //{
        class D : B
        {

        }
    class _34Multipleclassinheritance
    {

    }
}
