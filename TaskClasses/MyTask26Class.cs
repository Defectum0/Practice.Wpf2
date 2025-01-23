using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask26Class
    {
        public MyTask26Class(double y, double u)
        {
            Y = y;
            U = u;
        }

        public double Y { get; set; }
        public double U { get; set; }

        public double T()
        {
            return (Math.Sin (2 * U)) / Math.Log((2 * Y + U));
        }
    }
}
