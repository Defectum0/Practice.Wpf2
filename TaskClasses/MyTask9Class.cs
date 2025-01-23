using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask9Class
    {
        public MyTask9Class(double y, double w)
        {
            Y = y;
            W = w;
        }

        public double Y { get; set; }
        public double W { get; set; }

        public double V()
        {
            return (Math.Pow((Y + 2 * W), 3)) / Math.Log(Y + 0.75);
        }
    }
}
