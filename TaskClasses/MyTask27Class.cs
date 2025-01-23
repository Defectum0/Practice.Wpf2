using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask27Class
    {
        public MyTask27Class(double y, double p)
        {
            Y = y;
            P = p;
        }

        public double Y { get; set; }
        public double P { get; set; }

        public double Z()
        {
            return (Math.Pow(Math.Sin((P + 0.4)), 2)) / Math.Pow(Y, 2) + 7.325 * P;
        }
    }
}
