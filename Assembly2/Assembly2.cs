using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assembly1;

namespace Assembly2
{
    public class Assembly2 : Assembly11
    {
        public void Print()
        {
            Assembly11 Aa1 = new Assembly11();
            base.ID = 101;
        }
    }
}
