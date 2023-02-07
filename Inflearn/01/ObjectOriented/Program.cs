using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    class Player
    {
        static public int counter = 1;
        public int id, hp, attack;

        public void Move()
        {
            Console.WriteLine("Player Move");
        }
        public virtual void Attack()
        {
            Console.WriteLine("Plyaer Attack");
        }
    }
    class Mage : Player
    {
        public new void Move()
        {
            Console.WriteLine("Mage Move");
        }
        public override void Attack()
        {
            Console.WriteLine("Mage Attack");
        }
    }
    class Archer : Player
    {
        public new void Move()
        {
            Console.WriteLine("Archer Move");
        }
        public override void Attack()
        {
            Console.WriteLine("Archer Attack");
        }
    }

    class Knight : Player
    {
        //public Knight() : base(100)
        //{
        //    base.attack = 11;
        //    Console.WriteLine("Knight");
        //}
        //public Knight(int hp) : this()
        //{
        //    this.hp = hp;
        //    Console.WriteLine("int 생성자 호출!");
        //}
        //public Knight(int hp, int attack) : this(hp)
        //{
        //    this.hp = hp;
        //    this.attack = attack;
        //    Console.WriteLine("int, int 생성자 호출!");
        //}
        //static public Knight CreateKnight()
        //{
        //    Knight knight = new Knight();
        //    return knight; 
        //}

        public new void Move()
        {
            Console.WriteLine("Knight Move");
        }
        public override void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Knight knight2 = Knight.CreateKnight();

        }
    }
}
