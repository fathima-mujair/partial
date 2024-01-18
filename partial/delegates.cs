using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace partial
{
    public delegate int del(int x, int y);//public delegate void del(int x,int y)
    class Program
    {
        public int sum(int a,int b)//public void sum
        {
            return (a + b);//print a+b
        }
        static void Main(string[] args)
        {
            Program ob = new Program();
            del d = new del(ob.sum);
            int s = d(10, 20);//d(10,20);
            Console.WriteLine("sum is {0}", s);
           
            Console.ReadKey();
        }
    }
}
