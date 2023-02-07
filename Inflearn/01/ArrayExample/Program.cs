using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    internal class Program
    {
        static int GetHighestScore(int[] scores)
        {
            int highestScore = 0;
            foreach(int score in scores)
            {
                if(highestScore < score)
                {
                    highestScore= score;
                }
            }
            return highestScore;
        }
        static int GetAverageScore(int[] scores)
        {
            int averageScore = 0;
            foreach(int score in scores)
            {
                averageScore += score;
            }
            if (scores.Length == 0)
                return 0;

            return averageScore / scores.Length;
        }

        static int GetIndexOf(int[] scores, int value)
        {
            for(int i = 0; i < scores.Length; i++)
            {
                if(value == scores[i])
                {
                    return i;
                }
            }
            return -1;
        }

        static void Sort(int[] scores)
        {
            for(int i = 0; i < scores.Length; i++)
            {
                for(int j = i + 1; j < scores.Length; j++)
                {
                    if (scores[i] > scores[j])
                    {
                        int temp = scores[i];
                        scores[i] = scores[j];
                        scores[j] = temp;
                    }
                }
            }
            return;
        }
        static void Main(string[] args)
        {
            int[] scores = new int[5] {40, 30, 50, 10, 20};
            Console.WriteLine(GetHighestScore(scores));
            Console.WriteLine(GetAverageScore(scores));
            Console.WriteLine(GetIndexOf(scores, 20));
            Sort(scores);
            foreach(int score in scores)
            {
                Console.WriteLine(score);
            }
        }
    }
}
