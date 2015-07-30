using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.DaHuaBasketballGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player a = new Forwards("阿忠");
            a.Attack();
            Player s = new Guards("小政");
            s.Attack();

            Player ym = new Translator("姚明");
            ym.Attack();
            ym.Defense();

            Console.ReadKey();
        }
    }
}
