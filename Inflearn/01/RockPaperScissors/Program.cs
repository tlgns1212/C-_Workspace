using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        enum Choice
        {
            ROCK = 1,
            PAPER = 0,
            SCISSORS = 2
        }
        static void Main(string[] args)
        {
            // 0 : 가위, 1 : 바위, 2 : 보

            const int ROCK = 0;
            const int PAPER = 1;
            const int SCISSORS = 2;

            Random rand = new Random();
            int aiChoice = rand.Next(0, 3);
            
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case (int)Choice.SCISSORS:
                    Console.WriteLine("당신의 선택은 가위입니다.");
                    break;
                case (int)Choice.ROCK:
                    Console.WriteLine("당신의 선택은 바위입니다.");
                    break;
                case (int)Choice.PAPER:
                    Console.WriteLine("당신의 선택은 보입니다.");
                    break;
            }
            switch (aiChoice)
            {
                case SCISSORS:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다.");
                    break;
                case ROCK:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다.");
                    break;
                case PAPER:
                    Console.WriteLine("컴퓨터의 선택은 보입니다.");
                    break;
            }

            if(choice== 1)
            {
                if(aiChoice == 0)
                {
                    Console.WriteLine("승리");
                }
                else if(aiChoice == 1)
                {
                    Console.WriteLine("무승부");
                }
                else
                {
                    Console.WriteLine("패배");
                }
            }
            else if (choice == 0)
            {
                if (aiChoice == 0)
                {
                    Console.WriteLine("무승부");
                }
                else if (aiChoice == 1)
                {
                    Console.WriteLine("패배");
                }
                else
                {
                    Console.WriteLine("승리");
                }
            }
            else if (choice == 2)
            {
                if (aiChoice == 0)
                {
                    Console.WriteLine("패배");
                }
                else if (aiChoice == 1)
                {
                    Console.WriteLine("승리");
                }
                else
                {
                    Console.WriteLine("무승부");
                }
            }


        }
    }
}
