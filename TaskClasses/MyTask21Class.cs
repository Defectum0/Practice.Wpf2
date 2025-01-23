using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask21Class
    {
        public MyTask21Class(double x, double k, double d, double p)
        {
            X = x;
            K = k;
            D = d;
            P = p;
        }

        public double X { get; set; }
        public double K { get; set; }
        public double D { get; set; }
        public double P { get; set; }

        public double Q()
        {
            return (Math.Sqrt(K + 2.6 * P * Math.Sin(K))) / X - Math.Pow(D, 3);
        }
    }
}
