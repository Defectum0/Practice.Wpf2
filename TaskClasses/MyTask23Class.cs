using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask23Class
    {
        public MyTask23Class(double y, double d)
        {
            Y = y;
            D = d;
        }

        public double Y { get; set; }
        public double D { get; set; }

        public double R()
        {
            return (Math.Pow(Math.Sin(Y), 2) + 0.3 * D) / Math.Exp(Y) + Math.Log(D);
        }
    }
}
