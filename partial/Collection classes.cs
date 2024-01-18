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
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(1002);
            al.Add(20);
            al.Add("hi");
            for(int i=0;i<al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }
            foreach(var i in al)
            {
                Console.WriteLine(i);
            }

            al.Insert(1, 1500);
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            al.Add(23);
            al.Add(12);
            al.Add(55);
            al.Remove("hi");
            al.Sort();
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            al.RemoveAt(2);
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
