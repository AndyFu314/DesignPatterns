using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.CellPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            CellPhoneBrand M4;
            CellPhoneBrand Z3;

            M4 = new CellPhoneBrandN();

            M4.SetCellPhoneSoft(new CellPhoneGame());
            M4.Run();
            M4.SetCellPhoneSoft(new CellPhoneAddressList());
            M4.Run();

            Z3 = new CellPhoneBrandM();

            Z3.SetCellPhoneSoft(new CellPhoneGame());
            Z3.Run();
            Z3.SetCellPhoneSoft(new CellPhoneAddressList());
            Z3.Run();

            Console.ReadKey();
        }
    }
}
