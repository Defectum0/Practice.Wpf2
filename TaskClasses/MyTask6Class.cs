using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask6Class
    {
        public MyTask6Class(double y, double i)
        {
            Y = y;
            I = i;
        }

        public double Y { get; set; }
        public double I { get; set; }

        public double L()
        {
            return (0.81 * Math.Cos(I))/ Math.Log(Y) + 2 * Math.Pow(I, 3);
        }
    }
}
