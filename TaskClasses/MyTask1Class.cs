using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.TaskClasses
{
    public class MyTask1Class
    {
        public MyTask1Class(double y, double f)
        {
            Y = y;
            F = f;
        }

        public double Y { get; set; }
        public double F  { get; set; }

        public double G()
        {
            return Math.Exp(2 * Y) + Math.Sin(F) / Math.Log10(3.8 * Convert.ToDouble(Y) + F);
        }
    }
}
