using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask25Class
    {
        public MyTask25Class(double c, double t)
        {
            C = c;
            T = t;
        }

        public double C { get; set; }
        public double T { get; set; }

        public double L()
        {
            return Math.Pow(Math.Cos(C), 2) + (3 * Math.Pow(T, 2) + 4) / Math.Sqrt(C + T);
        }
    }
}
