using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    public class _43Exceptionhandling
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("1st: ");
                int FN = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2nd: ");
                int SN = Convert.ToInt32(Console.ReadLine());

                int result = FN / SN;
                Console.WriteLine("{0}",result);
            }
            catch(FormatException)
            {

            }
            catch(OverflowException)
            {

            }
            catch(DivideByZeroException)
            {

            }
            catch(Exception ex)
            {

            }
        }
    }
}
