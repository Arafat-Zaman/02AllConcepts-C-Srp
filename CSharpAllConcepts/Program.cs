using System;

namespace CSharpAllConcepts
{
    public class ParentClass
    {
        public ParentClass()
        {

        }
        public ParentClass(string Message)
        {

        }

        public void PrintFullName()
        {

        }
    }
    public class ChildClass : ParentClass
    {
        public ChildClass() : base()
        {

        }
        public new void PrintFullName()
        {
            base.PrintFullName();
        }

    }
    public class ChildClassPart : ParentClass
    {
        public ChildClassPart() : base()
        {

        }
        public new void PrintFullName()
        {
            base.PrintFullName();
        }

    }
    class Program
    {

        static void Main()
        {
            ChildClass cc = new ChildClass();
            ((ParentClass)cc).PrintFullName();
            //Program.EvenNumber(30);
            //Program p = new Program();
            //p.Add(1,100);

            
        }
    }
        //class Customer
        //{
        //    string _FNAme;
        //    string _LName;

        //    public Customer() : this("No FName","No LName") { }

        //    public Customer(string FNAme, string LName)
        //    {
        //        this._FNAme = FNAme;
        //        this._LName = LName; 
        //    }


        //}

        //class Program
        //{

        //    static void Main()
        //    {
        //        //Program.EvenNumber(30);
        //        //Program p = new Program();
        //        //p.Add(1,100);

        //        Customer c1 = new Customer();
        //    }

        //public int Add(int FirstNumber, int SecondNumber)
        //{
        //    return FirstNumber + SecondNumber;
        //}

        //public static void EvenNumber(int Target)
        //{
        //    int Start = 0;

        //    while(Start<=Target)
        //    {
        //        Console.WriteLine("Start: ", Start);
        //        Start++;
        //    }
        //}

        //int[] Numbers = new int[3];

        //Numbers[0] = 100;
        //Numbers[1] = 101;
        //Numbers[2] = 102;

        //for(int j=0;j<Numbers.Length;j++)
        //{
        //    Console.WriteLine(Numbers[j]);
        //}

        //foreach(int k in Numbers)
        //{
        //    Console.WriteLine(k);
        //}

        //Console.WriteLine("Enter number : ");
        //int userTarget = int.Parse(Console.ReadLine());

        //int Start = 0;

        //while(Start <= userTarget)
        //{
        //    Console.Write(Start + " ");
        //    Start = Start + 2;
        //}

        //string UserChoice = "";


        //do
        //{

        //}
        //while(UserChoice!="Yes" && UserChoice!="No")

        //Start:

        ////string Name = "\"Arafat\"";
        //string Name = @"C:\\Arafat\\D\\CSharp";
        //Console.WriteLine(Name);
        //bool b = false;
        //b = 123;
        //}

        //static void Main()
        //{


        //    Console.WriteLine("Welcome to C#");


        //    String FristName =  Console.ReadLine();
        //    String LAstName = Console.ReadLine();


        //    //Console.WriteLine("Hello0" + userNAme);

        //    Console.WriteLine("Hello0 {0}", FristName);
        //    Console.WriteLine("Hello0 {0}", LAstName);

        //}
        //}
        /// <summary>
        /// 
        /// </summary>
        public class SampleClass
    {

    }

}
