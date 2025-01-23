using System;

namespace WpfApp6
{
    public class MyTask12Class
    {
        public MyTask12Class(double y, double t)
        {
            Y = y;
            T = t;
        }

        public double Y { get; set; }
        public double T { get; set; }

        public double R()
        {
            return (Math.Pow(Math.Sin(2 * T + 1), 2)) + 0.3 / Math.Log(T + Y);
        }
    }
}
