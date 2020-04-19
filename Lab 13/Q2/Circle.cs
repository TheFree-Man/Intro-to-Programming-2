using System;

namespace Q2
{
    class Program
    {
        private double radius;

        public Circle()
        {
            radius = 1;
        }

        public Circle(double r)
        {
            radius = r;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return string.Format("The radius of this circle is: {0}", radius);
        }
    }
}
