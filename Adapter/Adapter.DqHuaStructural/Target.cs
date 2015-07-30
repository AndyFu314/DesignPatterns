using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.DqHuaStructural
{
    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("GeneralRequest");
        }
    }
}
