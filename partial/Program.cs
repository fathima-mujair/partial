using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Firstname = "Fathima";
            emp.lastname = "Nechikkad";
            emp.Designation = "Engineer";
            emp.age = 25;

            Console.WriteLine("Name is {0} {1}", emp.Firstname, emp.lastname);
            Console.WriteLine("designation is {0}", emp.Designation);
            Console.WriteLine("age is {0}", emp.age);
            Console.ReadKey();
        }
    }
}
