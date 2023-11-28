using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SysoevDA.Sprint6.Task0.V23.Lib
{
    public class DataService : ISprint6Task0V23
    {
        public double Calculate(int x)
        {
            double n1 = x + 1;
            double n2 = x + 2;
            double res = Math.Log(n1/n2);
            return Math.Round(res, 3);
        }
    }
}
