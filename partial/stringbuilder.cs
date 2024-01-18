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
            StringBuilder sb = new StringBuilder("");
            sb.Append("hello");
            sb.AppendLine();
            sb.Append("welcome to our world");
            Console.WriteLine(sb);
            
            //hello
            //welcome to our world

            sb.Replace("o", "O");
            Console.WriteLine(sb);
            //hellO
            //welcOme tO Our wOrld

            sb.Remove(1, 13);
            Console.WriteLine(sb);//h tO Our wOrld

            Console.ReadKey();
        }
    }
}
