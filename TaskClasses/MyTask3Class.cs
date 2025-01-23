using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask3Class
    {
        
        public MyTask3Class(double y, double k)
        {
            Y = y;
            K = k;
        }

        public double Y { get; set; }
        public double K { get; set; }

        public double U()
        {
            return (Math.Log(K - Y) + Math.Pow(Y, 4)) / Math.Exp(Y) + 2.355 * Math.Pow(K,2) ;
        }
    }
}

