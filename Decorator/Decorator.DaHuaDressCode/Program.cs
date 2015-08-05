using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DaHuaDressCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Tony = new Person("Tony");

            Console.WriteLine("\n第一種裝扮:");
            Finery dtx = new TShirts();
            Finery kk = new BigTrouser();
            Finery pqx = new Sneakers();

            pqx.Decorate(Tony);
            kk.Decorate(pqx);
            dtx.Decorate(kk);
            dtx.Show();
            
            Console.Read();
        }
    }
}
