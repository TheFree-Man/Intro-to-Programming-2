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

            myCircles[0].Radius = 10;
            myCircles[2].Radius = 10;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(myCircles.ToString());
            }
            
            Console.WriteLine("1st circle area is: {0}", myCircles[0].GetArea());
            Console.WriteLine("4th circle's area is: {0}", myCircles[3].GetArea());
        }
    }
}
