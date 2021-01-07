using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    public struct Customer
    {
        private int _id;
        private string _name;

        public string Name { get => _name; set => _name = value; }
        public int Id
        {
            get { return this._id; }
            set { this._id = value;  }
        }

        public Customer(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }
        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} && Name = {1}", Id, Name);
        }
    }

    public class _28Struct
    {
        //public static void Main()
        //{
            public static void test()
            {
                Customer c1 = new Customer(101, "Mark");
            c1.PrintDetails();

            Customer c2 = new Customer();
            c2.Id = 101;
            c2.Name = "John";
            c2.PrintDetails();

            Customer c3 = new Customer
            {
                Id = 101,
                Name = "C"
             };
            c3.PrintDetails();

        }
    }
}
