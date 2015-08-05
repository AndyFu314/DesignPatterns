using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DaHuaDressCode
{
    class BigTrouser: Finery
    {
        public override void Show()
        {
            Console.Write("垮褲 ");
            base.Show();
        }
    }
}
