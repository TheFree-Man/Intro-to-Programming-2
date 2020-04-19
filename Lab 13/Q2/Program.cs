using System;
using System.Collections.Generic;
using System.Text;

namespace Q2
{
    class Program
    {
        static void Main()
        {
            Circle [] myCircles = new Circle[4];

            for (int i = 0; i < 4; i++)
            {
                myCircles[i] = new Circle();
            }

            myCircles[1].Radius = 10;
            myCircles[3].Radius = 10;
        }
    }
}
