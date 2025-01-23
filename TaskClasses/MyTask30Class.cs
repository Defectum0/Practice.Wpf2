using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask30Class
    {
        public MyTask30Class(double y, double p)
        {
            Y = y;
            P = p;
        }

        public double Y { get; set; }
        public double P { get; set; }

        public double N()
        {
            return (3 * Math.Pow(Y, 2) + Math.Sqrt(2.7 * Y)) / Math.Log(P + Y) + Math.Exp(P);
        }
    }
}
