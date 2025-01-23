using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask17Class
    {
        public MyTask17Class(double y, double n)
        {
            Y = y;
            N = n;
        }

        public double Y { get; set; }
        public double N { get; set; }

        public double H()
        {
            return (Math.Pow(Y, 2) - 0.8 * Y + Math.Sqrt(Y)) / 23.1 * Math.Pow(N, 2) + Math.Cos(N);
        }
    }
}
