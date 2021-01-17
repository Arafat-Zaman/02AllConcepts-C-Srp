using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    public class _46Enum
    {
        //public static void Main()
        //{
            public static void testMain()
            {
                Customerrs[] customerrs = new Customerrs[3];

            customerrs[0] = new Customerrs
            {
                Name = "A",
                Gender = Gender.Male
            };
            customerrs[2] = new Customerrs
            {
                Name = "A",
                Gender = Gender.Male
            };


        }
        public static string GetGender(Gender gender)
        {
            switch(gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid";
            }
        }
    }
        




    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public class Customerrs
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }

}