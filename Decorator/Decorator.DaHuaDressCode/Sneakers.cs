using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DaHuaDressCode
{
    class Sneakers: Finery
    {
        public override void Show()
        {
            Console.Write("破球鞋 ");
            base.Show();
        }
    }
}
