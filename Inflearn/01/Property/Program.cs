using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    internal class Program
    {
        class Knight
        {
            public int _Hp
            {
                get; set;
            } = 100;
            // 위는 private hp, gethp와 sethp와 같음



            //protected int _hp;

            //public int _Hp
            //{
            //    get { return _hp; }
            //    set { _hp = value; }        // value는 기본 설정된 ?변수? 이름
            //}

            //public int GetHP(){ return _hp; }
            //public void SetHP(int hp) { _hp = hp; }

            static void Main(string[] args)
            {
                Knight knight = new Knight();
                knight._Hp = 100;

                int hp = knight._Hp;
            }
        }
    }
}
