using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask24Class
    {
        public MyTask24Class(double y, double k)
        {
            Y = y;
            K = k;
        }

        public double Y { get; set; }
        public double K { get; set; }

        public double U()
        {
            return (Math.Log((2 * K + 4.3))) / Math.Exp(K + Y) + Math.Sqrt(Y);
        }
    }
}
