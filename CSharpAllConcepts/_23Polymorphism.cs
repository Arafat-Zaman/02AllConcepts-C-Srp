using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    public class Employee
    {
        public string Fname = "Arafat";
        public string LName = "Zaman";

        public virtual void printFullName()
        {
            Console.WriteLine(Fname + "" + LName);
        }
    }

    public class PartEmployee : Employee
    {
        public override void printFullName()
        {
            Console.WriteLine(Fname + "P" + LName);
        }
    }

    public class FullTime : Employee
    {
        public override void printFullName()
        {
            Console.WriteLine(Fname + "F" + LName);
        }
    }
    public class Temp : Employee
    {
        public override void printFullName()
        {
            Console.WriteLine(Fname + "T" + LName);
        }
    } 
    public class _23Polymorphism 
    {

        //public static void Main()
        //{
            public static void Main2()
            {
                Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new PartEmployee();
            employees[2] = new Temp();
            employees[3] = new FullTime();

            foreach(Employee e in employees)
           {
                e.printFullName();
           }
            Console.ReadKey();
        }

    }
}
