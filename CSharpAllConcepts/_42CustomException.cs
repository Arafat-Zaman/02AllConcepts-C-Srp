using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAllConcepts
{
    public class _42CustomException
    {
        //public static void Main()
        //{
            public static void test()
            {
                throw new UserAlreadyloggedin();
        }
    }
    public class UserAlreadyloggedin : Exception
    {
        public UserAlreadyloggedin() : base()
        {

        }

        public UserAlreadyloggedin(string message) : base(message)
        {
            
        }

        public UserAlreadyloggedin(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
