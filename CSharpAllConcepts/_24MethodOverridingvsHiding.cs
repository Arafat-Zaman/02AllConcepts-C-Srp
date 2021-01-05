using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    public class Baseclass
    {
        public virtual void Print()
        {
            Console.WriteLine("Base class");
        }
        
    }
    //overriding
    public class DerivedClass : Baseclass
    {
        public override void Print()
        {
            Console.WriteLine("Override");
        }
    }
    //Hiding
    //public class DerivedClass : _24MethodOverridingvsHiding
    //{
    //    public new void Print()
    //    {
    //        Console.WriteLine("Hiding");
    //    }
    //}
    public class _24MethodOverridingvsHiding
    {
        //public static void Main()
        //{
            public static void test()
            {
                Baseclass b = new DerivedClass();
            b.Print();
            Console.ReadKey();
        }
    }
   

}
