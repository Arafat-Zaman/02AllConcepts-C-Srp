using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    public class Students
    {
        private int _ID;
        private string _Name;
        private int _PassMark = 35;

        public string Email{get;set;}

        public int id
        {
            set
            { 
                if (value <= 0)
                {
                    throw new Exception("not negative");
                }
                this._ID = value;
            }
            get
            {
                return this._ID;
            }
        }

      
    }

    public class _27Properties
    {
        public static void Main()
        {
            Students c1 = new Students();
            c1.id = 101;

            Console.WriteLine("{0}", c1.id);
            Console.ReadKey();
        }
    }



}
