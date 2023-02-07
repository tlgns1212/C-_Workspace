using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate // 대리자
{
    internal class Program
    {

        delegate int OnClicked(); // delegate -> 형식은 형식인데, 함수 자체를 인자로 넘겨주는 형식
        // 반환은 int, 입력은 void, OnClicked가 delegate 형식의 이름이다.

        static void ButtonPressed(OnClicked clickedFunction /* 함수 자체를 인자로 넘겨주고 */)
        {
            // 함수를 호출();
            clickedFunction();
        }

        static int TestDelegate()
        {
            Console.WriteLine("Hello Delegate");
            return 0;
        }
        static int TestDelegate2()
        {
            Console.WriteLine("Hello Delegate2");
            return 0;
        }
        static void Main(string[] args)
        {
            OnClicked clicked = new OnClicked(TestDelegate);
            clicked += TestDelegate2;

            ButtonPressed(clicked);
        }
    }
}
