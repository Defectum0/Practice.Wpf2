using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask10Class
    {
        public MyTask10Class(double y, double t)
        {
            Y = y;
            T = t;
        }

        public double Y { get; set; }
        public double T { get; set; }

        public double Z()
        {
            return (2 * T + Y * Math.Cos(T)) / Math.Sqrt(Y + 4.831);
        }
    }
}
