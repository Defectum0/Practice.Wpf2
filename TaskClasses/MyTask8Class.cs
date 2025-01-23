using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask8Class
    {
        public MyTask8Class(double y, double t)
        {
            Y = y;
            T2 = t;
        }

        public double Y { get; set; }
        public double T2 { get; set; }

        public double T()
        {
            return (2.37 * Math.Sin(T2 + 1)) / Math.Sqrt(4 * Math.Pow(Y, 2) - 0.1 * Y + 5);
        }
    }
}
