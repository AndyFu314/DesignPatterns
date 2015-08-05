using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DaHuaStructural
{
    class ConcreteComponent: Component
    {
        public override void Operation()
        {
            Console.WriteLine("具體物件的操作");
        }
    }
}
