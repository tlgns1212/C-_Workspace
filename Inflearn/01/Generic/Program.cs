using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Program
    {
        //class MyIntList
        //{
        //    int[] arr = new int[10];
        //}
        //class MyFloatList
        //{
        //    float[] arr = new float[10];
        //}
        //class MyShortList
        //{
        //    short[] arr = new short[10];
        //}

        class MyList<T> where T : struct
        {
            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return arr[i];
            }
        }

        static void Test<T>(T input)
        {

        }


        static void Main(string[] args)
        {
            //object obj = 3;
            //object obj2 = "hello world";
            //int num = (int)obj;
            //string str = (string)obj2;

            MyList<int> myIntList = new MyList<int>();
            MyList<short> myShortList = new MyList<short>();

            Test<int>(3);
            Test<float>(4.0f);

        }
    }
}
