using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.DaHuaStructural
{
    abstract class Abstraction
    {
        protected Implementor implementor;

        public void setImplementor(Implementor implementor)
        {
            this.implementor = implementor;
        }

        public abstract void Operation();
    }
}
