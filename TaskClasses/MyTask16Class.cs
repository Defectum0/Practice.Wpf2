using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask16Class
    {
        public MyTask16Class(double t, double r, double y)
        {
            T = t;
            R = r;
            Y = y;
        }

        public double T { get; set; }
        public double R { get; set; }
        public double Y { get; set; }
        public double W()
        {
            return (4 * Math.Pow(T, 3) + Math.Log(R)) / Math.Exp(Y + R) + 7.2 * Math.Sin(R);
        }
    }
}
