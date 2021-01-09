using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CSharpAllConcepts
{
    class _41innerexception
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter First Number: ");
                int FN = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number: ");
                int SN = Convert.ToInt32(Console.ReadLine());

                int Result = FN / SN;

                Console.WriteLine("Result= {0}",Result);
            }
            catch(Exception ex)
            {
                string FileName = @"C:\\SampleFiles\\log.txt";
                StreamWriter sw = new StreamWriter(FileName);
                sw.Write(ex.GetType().Name);
                sw.WriteLine();
                sw.Write(ex.Message);
                sw.Close();
                Console.WriteLine("There is a Problem, Please try later");

            }
        }

    }
}
