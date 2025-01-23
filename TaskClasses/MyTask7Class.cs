using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask7Class
    {
        public MyTask7Class(double y, double m)
        {
            Y = y;
            M = m;
        }

        public double Y { get; set; }
        public double M { get; set; }

        public double N()
        {
            return (Math.Pow(M, 2) + 2.8 * M + 0.355) / Math.Cos(2 * Y) + Math.Exp(Y);
        }
    }
}
