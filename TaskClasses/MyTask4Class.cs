using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask4Class
    {
        
        public MyTask4Class(double y, double w)
        {
            Y = y;
            W = w;
        }

        public double Y { get; set; }
        public double W { get; set; }

        public double G()
        {
            return (9.33 * Math.Pow(W, 3) + Math.Sqrt(W)) / Math.Log(Y + 3.5) + Math.Sqrt(Y);
        }
    }
}

