using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask14Class
    {
        public MyTask14Class(double y, double h)
        {
            Y = y;
            H = h;
        }

        public double Y { get; set; }
        public double H { get; set; }

        public double P()
        {
            return (Math.Exp(Y + 2.5) + 7.1 * Math.Pow(H,3)) / Math.Log(Math.Sqrt(Y + 0.04 * H));
        }
    }
}
