using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    abstract class Monster  // 추상화
    {
        public abstract void Shout();  
    }

    interface IFlyable // 인터페이스
    {
        void Fly();
    }
    class Orc : Monster
    {
        public override void Shout()
        {
            Console.WriteLine("록타르 오가르");
        }
    }
    class FlyableOrc : Orc, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Fly");
        }
    }
    class Skeleton : Monster
    {
        public override void Shout()
        {
            Console.WriteLine("끼익");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Monster monster = new Monster();    // 추상화된건 만들 수 없음

        }
    }
}
