using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    public delegate void SampleDelegate();

    public class _39MulticastDelegate
    {
        public static void Main()
        {
            SampleDelegate del1, del2, del3, del4;


            del1 = new SampleDelegate(SampelMethod1);
            del2 = new SampleDelegate(SampelMethod2);
            del3 = new SampleDelegate(SampelMethod3);

            del4 = del1 + del2 + del3;

            del4();
        }
        public static void SampelMethod1()
        { Console.WriteLine("1"); }

        public static void SampelMethod2()
        { Console.WriteLine("2"); }

        public static void SampelMethod3()
        { Console.WriteLine("3"); }

        public static void SampelMethod4()
        { Console.WriteLine("4"); }
    }
}
