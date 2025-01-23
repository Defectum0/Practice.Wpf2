using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask18Class
    {
        public MyTask18Class(double y, double k)
        {
            Y = y;
            K = k;
        }

        public double Y { get; set; }
        public double K { get; set; }

        public double R()
        {
            return (Math.Sqrt(Math.Pow(Math.Sin(Y), 2) + 6.835)) / Math.Log((Y + K)) + 3 + Math.Pow(Y, 2);
        }
    }
}
