using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceContravariance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICovariant<string> icovS = new CovariantClass<string>("Text");
            string s1 = icovS.Produce();
            object o1 = icovS.Produce();
            
            ICovariant<object> icovO = new CovariantClass<object>("Text");
            //string s2 = icovO.Produce();
            object o2 = icovO.Produce();

            int i = 50;
            object o = 50;

            IContravariant<int> icontrS = new ContravariantClass<int>();
            icontrS.GetCode(i);
            //icontrS.GetCode(o);

            IContravariant<object> icontrO = new ContravariantClass<object>();
            icontrO.GetCode(i);
            icontrO.GetCode(o);

            IContravariant<int> icontrS2 = new ContravariantClass<int>();
            IContravariant<object> icontrO2 = new ContravariantClass<object>();

            //icontrO2 = icontrS2;
            icontrS2 = icontrS2;
        }
    }
}
