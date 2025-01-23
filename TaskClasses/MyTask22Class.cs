using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace WpfApp6
{
    public class MyTask22Class
    {
        public MyTask22Class(double y, double t)
        {
            Y = y;
            T = t;
        }

        public double Y { get; set; }
        public double T { get; set; }

        public double S()
        {
            return (4.351 * Math.Pow(Y, 3) + 2 * T * Math.Log(T)) / Math.Sqrt(Math.Cos(2 * Y + 4.351));
        }
    }
}
