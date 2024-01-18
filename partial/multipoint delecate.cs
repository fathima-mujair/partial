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
        public void sum(int a,int b)//public void sum
        {
            Console.WriteLine("sum is {0}", a + b);
        }
        public void product(int a, int b)//public void sum
        {
            Console.WriteLine("the product is {0}", a * b);
        }
        static void Main(string[] args)
        {
            Program ob = new Program();
            del d = new del(ob.sum);
            d += new del(ob.product);
            d(10, 20);//d(10,20);
            
           
            Console.ReadKey();
        }
    }
}
