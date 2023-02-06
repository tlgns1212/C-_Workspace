using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static int Factorial(int n)
        {
            //int ret = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    ret *= i;
            //}
            //return ret;
            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            int ret = Factorial(5);
            Console.WriteLine(ret);
        }
    }
}
