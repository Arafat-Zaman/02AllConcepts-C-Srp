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
                int Numerator;
                bool isNumeratorconversionsuccessful = Int32.TryParse(Console.ReadLine(), out Numerator);

                if(isNumeratorconversionsuccessful)
                {
                    int FN = Convert.ToInt32(Console.ReadLine());

                    int denominator;
                    bool isDenominatorsuccessful = Int32.TryParse(Console.ReadLine(), out denominator);

                    Console.WriteLine("2nd: ");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int result = FN / SN;
                    Console.WriteLine("{0}", result);
                }
               
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
