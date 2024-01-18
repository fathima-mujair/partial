using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace partial
{
    class Program
    {
        public static void Main()
        {
            List < int > num= new List<int>() { 36, 71, 12, 15, 29, 18, 27, 17, 9, 34 };
            Console.WriteLine("list is");
            foreach(var i in num)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("square is ");
            var square = num.Select(x => x * x);
            foreach (var i in square)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("divisible by 3 is ");
            var div3 = num.FindAll(x => x % 3 == 0);
            foreach (var i in div3)
            {
                Console.Write("{0} ", i);
            }



            Console.ReadKey();
        }
        
    }
}
