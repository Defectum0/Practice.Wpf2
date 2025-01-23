using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask19Class
    {
        public MyTask19Class(double y, double q)
        {
            Y = y;
            Q = q;
        }

        public double Y { get; set; }
        public double Q { get; set; }

        public double E()
        {
            return Math.Log((0.7 * Y + 2 * Q )) / Math.Sqrt(3 * Math.Pow (Y, 2) + 0.5 * Y + 4);
        }
    }
}
