using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.UleevRI.Sprint1.TaskReview.V27.Lib
{
    public class DataService : ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            if (Math.Sin(y) == 1) return -1;
            else
            {
                double res = Math.Round((Math.Cos(Math.Pow(x, 2)) + Math.Sin(Math.Pow(y, 2))) / (Math.Sin(y) + 1) - (x * y - 12) / (15 + Math.Cos(x)), 3);
                double z = res;
                return z;
            }
        }
    }
}
