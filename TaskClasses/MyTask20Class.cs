using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask20Class
    {
        public MyTask20Class(double y, double t, double l)
        {
            Y = y;
            T = t;
            L = l;
        }

        public double Y { get; set; }
        public double T { get; set; }
        public double L { get; set; }

        public double K()
        {
            return (2 * Math.Pow(T, 2) + 3 * L + 7.2) / Math.Log(Y + Math.Exp(2 * L));
        }
    }
}
