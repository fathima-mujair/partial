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
            string a = "Good Morning";
            string b = "hello friends";
            string c = a.Clone().ToString();
            Console.WriteLine(c);//good morning
            Console.WriteLine(a.CompareTo(b));//-1
            Console.WriteLine(a.CompareTo(a));//0
            Console.WriteLine(a.Equals(a));//true
            Console.WriteLine(a.StartsWith("g"));//true
            Console.WriteLine(b.EndsWith("d"));//false
            Console.WriteLine(a.Contains("good"));//true
            Console.WriteLine(b.GetType());//synstem.string
            Console.WriteLine(a.IndexOf("o"));//1
            Console.WriteLine(b.ToUpper());//HELLO FRIENDS
            Console.WriteLine(b.ToLower());//hello friends

            //int l = b.Length;
            Console.WriteLine("Length is {0}",b.Length);//13

            string s = " haii hello ";
            Console.WriteLine(s.Trim());//haii hello

            string x = a.Insert(0, "hai...");
            Console.WriteLine(x);//hai..good morning

            Console.WriteLine(b.Remove(7));//hello f

            Console.WriteLine(a.Substring(1,10));

            string d = "hai how are you?";
            char[] ar = new char[15];
            d.CopyTo(0, ar, 0, 6);
            for(int i=0;i<ar.Length;i++)
            {
                Console.WriteLine(ar[i]);//hai ho
            }



            Console.ReadKey();
        }
    }
}
