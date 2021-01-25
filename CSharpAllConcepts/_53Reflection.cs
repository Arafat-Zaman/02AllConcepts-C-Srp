using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CSharpAllConcepts
{
    class _53Reflection
    {
        public static void Main()
        {
            Type T = Type.GetType("CSharpAllConcepts.CustomerR");
            Console.WriteLine("Full Name = {0}",T.FullName);
            Console.WriteLine("Just the name = {0}", T.Name);
            Console.WriteLine("Just the namespace = {0}", T.Namespace);

            PropertyInfo[] propertyInfos = T.GetProperties();
            
            foreach(PropertyInfo propertyInfo in propertyInfos)
            {
                Console.WriteLine(propertyInfo.PropertyType.Name + "" + propertyInfo.Name);
            }

             
        }
    } 

    class CustomerR
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
