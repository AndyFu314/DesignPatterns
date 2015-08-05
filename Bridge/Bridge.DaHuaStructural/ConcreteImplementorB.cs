using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.DaHuaStructural
{
    class ConcreteImplementorB: Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具體實現B的方法執行");
        }
    }
}
