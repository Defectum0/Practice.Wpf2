using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class MyTask15Class
    {
        public MyTask15Class(double y, double j)
        {
            Y = y;
            J = j;
        }

        public double Y { get; set; }
        public double J { get; set; }

        public double F()
        {
            return (2 * Math.Sin((0.354* Y + 1))) / Math.Log((Y + 2 ));
        }
    }
}
