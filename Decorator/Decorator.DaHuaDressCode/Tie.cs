using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DaHuaDressCode
{
    class Tie: Finery
    {
        public override void Show()
        {
            Console.Write("領帶 ");
            base.Show();
        }
    }
}
