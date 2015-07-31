using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.DaHuaCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCompany root = new ConcreteCompany("北京總公司");
            root.Add(new HRDepartment("總公司人力資源部"));
            root.Add(new FinanceDepartment("總公司財務部"));

            ConcreteCompany comp = new ConcreteCompany("上海華東分公司");
            comp.Add(new HRDepartment("華東分公司人力資源部"));
            comp.Add(new FinanceDepartment("華東分公司財務部"));
            root.Add(comp);

            ConcreteCompany comp1 = new ConcreteCompany("南京辦事處");
            comp1.Add(new HRDepartment("南京辦事處人力資源部"));
            comp1.Add(new FinanceDepartment("南京辦事處財務部"));
            comp.Add(comp1);

            ConcreteCompany comp2 = new ConcreteCompany("杭州辦事處");
            comp2.Add(new HRDepartment("杭州辦事處人力資源部"));
            comp2.Add(new FinanceDepartment("杭州辦事處財務部"));
            comp.Add(comp2);

            Console.WriteLine("\n結構圖：");
            root.Display(1);

            Console.WriteLine("\n職責：");
            root.LineDuty();

            Console.ReadKey();
        }
    }
}
