using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    public delegate void HelloFunction(string MEssage);

   
    class _36Delegate
    {
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }

        //public static void Main()
        //{
            public static void test()
            {
                HelloFunction hf = new HelloFunction(Hello);
            hf("Arafat");
        }
    }
}
