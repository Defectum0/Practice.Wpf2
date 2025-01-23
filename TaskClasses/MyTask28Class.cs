using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask28Class
    {
        public MyTask28Class(double y, double v)
        {
            Y = y;
            V = v;
        }

        public double Y { get; set; }
        public double V { get; set; }

        public double W()
        {
            return (0.004 * V + Math.Exp(2 * Y)) / Math.Exp(Y / 2);
        }
    }
}
