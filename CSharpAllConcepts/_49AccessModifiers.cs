using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    public class _49AccessModifiers
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
    }

    public class MainClass
    {
        public static void Main()
        {
            _49AccessModifiers AM = new _49AccessModifiers();
            Console.WriteLine(AM.ID); 
        }
    }
}
