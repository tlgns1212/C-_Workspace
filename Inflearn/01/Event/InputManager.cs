using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    // Observer Pattern
    internal class InputManager
    {
        public delegate void OnInputKey();
        public event OnInputKey InputKey;

        public void Update()
        {
            if (Console.KeyAvailable == false)
                return;

            ConsoleKeyInfo info = Console.ReadKey();
            if(info.Key == ConsoleKey.A)
            {
                // 모두한테 A를 입력했다는 사실을 알려준다.
                InputKey();
            }
        }
    }
}
