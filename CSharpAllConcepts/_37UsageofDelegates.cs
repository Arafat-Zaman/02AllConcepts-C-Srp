using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    class _37UsageofDelegates
    {
        public static void Main()
        {
            List<Employeee> empList = new List<Employeee>();

            empList.Add(new Employeee() { ID = 101, Name = "A", Salary = 101, Experience = 1 });
            empList.Add(new Employeee() { ID = 101, Name = "B", Salary = 101, Experience = 5 });
            empList.Add(new Employeee() { ID = 101, Name = "C", Salary = 101, Experience = 6 });

            Employeee.Promote(empList);
        }

    }

    public class Employeee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void Promote(List<Employeee> emplist)
        {
            foreach(Employeee empl in emplist)
            {
                if(empl.Experience >=5)
                {
                    Console.WriteLine("Promoted"+ empl.Name);
                }
            }
        }

    }
}
