using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.DaHuaBasketballGame
{
    class ForeignCenter
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void 進攻()
        {
            Console.WriteLine("外籍中鋒 {0} 進攻", name);
        }

        public void 防守() 
        {
            Console.WriteLine("外籍中鋒 {0} 防守", name);
        }
    }
}
