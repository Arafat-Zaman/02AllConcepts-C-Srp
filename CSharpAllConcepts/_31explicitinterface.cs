using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    interface I1
    {
        void Print1();
    }
    interface I2
    {
        void Print1();
    }


    public class _31explicitinterface : I1, I2
    {
        void I1.Print1()
        {
            Console.WriteLine("1");
        }

        void I2.Print1()
        {
            Console.WriteLine("2");
        }

        public static void Main()
        {
            //_31explicitinterface expl = new _31explicitinterface();
            // ((I1)expl).Print1();
            // ((I2)expl).Print1();

            I1 i1 = new _31explicitinterface();
            I2 i2 = new _31explicitinterface();

            i1.Print1();
            i2.Print1();


        }


    }
}
