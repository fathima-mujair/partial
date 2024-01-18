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
            Hashtable ht = new Hashtable();
            ht.Add(4, "red");
            ht.Add(2, "green");
            ht.Add(3, "blue");
            foreach(DictionaryEntry i in ht)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
            Console.WriteLine(ht[4]);

            Console.WriteLine("sorted list");
            SortedList s1 = new SortedList();
            s1.Add(1, "red");
            s1.Add(4,"green");
            s1.Add(3, "blue");
            foreach (DictionaryEntry i in s1)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
            Console.WriteLine("sorted list");
            SortedList s2 = new SortedList();
            s2.Add("red",2);
            s2.Add("green",4);
            s2.Add("blue",3);
            foreach (DictionaryEntry i in s2)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }

            Console.ReadKey();
        }
    }
}
