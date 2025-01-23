using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask29Class
    {
        public MyTask29Class(double y, double h)
        {
            Y = y;
            H = h;
        }

        public double Y { get; set; }
        public double H { get; set; }

        public double T()
        {
            return (0.355 * Math.Pow(H, 2) - 4.355) / Math.Exp(Y + H) + Math.Sqrt(2.7 * Y);
        }
    }
}
