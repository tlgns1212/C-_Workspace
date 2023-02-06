using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void HelloWorld()
        {
            Console.WriteLine("Hello World!!");
        }

        static void AddOne(ref int number)
        {   //참조
            number += 1;
        }
        static void Main(string[] args)
        {
            int a = 0;
            Program.HelloWorld();
            Program.AddOne(ref a);

            Console.WriteLine(a);
        }
    }
}
