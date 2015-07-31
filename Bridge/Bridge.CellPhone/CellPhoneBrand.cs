using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.CellPhone
{
    abstract class CellPhoneBrand
    {
        protected CellPhoneSoft soft;

        public void SetCellPhoneSoft(CellPhoneSoft soft)
        {
            this.soft = soft;
        }

        public abstract void Run();
    }
}
