using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.DaHuaStructural
{
    class ConcreteImplementorA: Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具體實現A的方法執行");
        }
    }
}
