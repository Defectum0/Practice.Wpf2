using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask5Class
    {
        public MyTask5Class(double a, double t, double y)
        {
            A = a;
            T = t;
            Y = y;
        }

        public double A { get; set; }
        public double T { get; set; }
        public double Y { get; set; }

        public double D()
        {
            return (7.8 * Math.Pow(A, 2) + 3.52 * T) / Math.Log(A + 2 * Y) + Math.Exp(Y);
        }
    }
}
