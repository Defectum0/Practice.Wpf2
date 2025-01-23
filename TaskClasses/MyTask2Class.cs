using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask2Class
    {
        public MyTask2Class(double d, double y)
        {
            D = d;
            Y2 = y;
        }
        public double D { get; set; }
        public double Y2 { get; set; }

        public double F()
        {
            return Math.Log(D) + (3.5 * Math.Pow(D, 2) + 1) / (Math.Cos(2 * Y2));
        }
    }
}
