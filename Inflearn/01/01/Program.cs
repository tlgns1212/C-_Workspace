using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // byte(1바이트 0~255), short(2바이트 -3만~3만), int(4바이트 -21억~21억), long(8바이트)
            int hp = 100;
            short level = 200;
            long id;

            // 1바이트
            bool b;

            // 4 바이트
            float f = 3.14f;
            // 8 바이트
            double d = 3.14;

            // 2바이트
            char c = 'A';
            string str = "Hello World";

            int a = 1000;
            short b = (short)a;


            Console.WriteLine(str);
        }
    }
}
