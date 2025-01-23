using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask13Class
    {
        public MyTask13Class(double y, double h)
        {
            Y = y;
            H = h;
        }

        public double Y { get; set; }
        public double H { get; set; }

        public double A()
        {
            return (Math.Sin(2 * Y + H) + Math.Pow(Y, 2)) / Math.Exp(H) + Y;
        }
    }
}
