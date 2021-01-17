using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly1
{
    public class Assembly11
    {
        protected int ID = 101;
    }

    public class Assembly12
    {
        public void SampleMethod()
        {
            Assembly11 A1 = new Assembly11();
            //Console.WriteLine(A1.ID);
        }
    }
}
