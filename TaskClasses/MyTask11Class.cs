using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask11Class
    {
        public MyTask11Class(double y, double n)
        {
            Y = y;
            N = n;
        }

        public double Y { get; set; }
        public double N { get; set; }

        public double D()
        {
            return Math.Pow(Y, 2) + (0.5 * N + 4.8) / Math.Sin(Y);
        }
    }
}
