using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DaHuaDressCode
{
    class Suit: Finery
    {
        public override void Show()
        {
            Console.Write("西裝 ");
            base.Show();
        }
    }
}
