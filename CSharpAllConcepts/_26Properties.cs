using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    public class Student
    {
        private int _ID;
        private string _Name;
        private int _PassMark = 35;

        public void SetId(int Id)
        {
            if(Id<=0)
            {
                throw new Exception("not negative");
            }
            this._ID = Id;
        }

        public int GetId()
        {
            return this._ID;
        }
        
    }

    public class _26Properties
    {
        //public static void Main()
        //{
            public static void test()
            {
                Student c1 = new Student();
            c1.SetId(101);

            Console.WriteLine("{0}",c1.GetId());
            Console.ReadKey();
        }
    }


    
}
