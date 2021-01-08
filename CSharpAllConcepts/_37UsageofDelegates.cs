using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    public delegate bool ISPromotable(Employeee empl);
    public class _37UsageofDelegates
    {
        //public static void Main()
        //{
            public static void test()
            {
                List<Employeee> empList = new List<Employeee>();

            empList.Add(new Employeee() { ID = 101, Name = "A", Salary = 101, Experience = 1 });
            empList.Add(new Employeee() { ID = 101, Name = "B", Salary = 101, Experience = 5 });
            empList.Add(new Employeee() { ID = 101, Name = "C", Salary = 101, Experience = 6 });

            ISPromotable isPromotable = new ISPromotable(Promoted);

            Employeee.Promote(empList, isPromotable);
        }

        public static bool Promoted(Employeee emp)
        {
            if(emp.Experience >=5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    public class Employeee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void Promote(List<Employeee> emplist, ISPromotable isEligiblePromotable)
        {
            foreach(Employeee empl in emplist)
            {
                if(isEligiblePromotable(empl))
                {
                    Console.WriteLine("Promoted"+ empl.Name);
                }
            }
        }

    }
}
