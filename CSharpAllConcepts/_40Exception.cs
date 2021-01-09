using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CSharpAllConcepts
{
    public class _40Exception
    {
        //public static void Main()
        //{
            public static void test()
            {
                StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"C:\\data.txt");
            }
            catch(FileNotFoundException  ex)
            {
                Console.WriteLine(ex.FileName);
            }
            finally
            {
                if(streamReader != null)
                {
                    streamReader.Close();
                }

                Console.WriteLine();
            }
        }
       
    }
}
