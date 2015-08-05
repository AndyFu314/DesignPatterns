using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DaHuaStructural
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent TextView = new ConcreteComponent();
            ConcreteDecoratorA ScrollDecorator = new ConcreteDecoratorA();
            ConcreteDecoratorB BorderDecorator = new ConcreteDecoratorB();

            ScrollDecorator.SetComponent(TextView);
            BorderDecorator.SetComponent(ScrollDecorator);
            BorderDecorator.Operation();

            Console.ReadKey();
        }
    }
}
