using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.ResumeClone
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume R1 = new Resume("Rucy");
            R1.SetPersonalInfo("Female", "30");
            R1.SetWorkExperience("1990-2005", "NASA");

            Resume R2 = (Resume)R1.Clone();
            R2.SetWorkExperience("2006-2010", "Google");

            Resume R3 = (Resume)R1.Clone();
            R3.SetPersonalInfo("Male", "36");
            R3.SetWorkExperience("2000-2020", "UDN");

            R1.Show();
            R2.Show();
            R3.Show();

            Console.ReadKey();
        }
    }
}
