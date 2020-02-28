using System;

namespace Q1
{
    class Program
    {
        static string[] gradeName = new string[] { "F", "E", "D", "C", "B", "A" };

        static void Main(string[] args)
        {
            int i;
            double studentMark;

            for (i= 0; i != -999;)
            {
                Console.Write("Enter student mark: ");
                studentMark = double.Parse(Console.ReadLine());
                getGradeBand(studentMark);
            }
        }

        static string getGradeBand(double studentMark)
        {

        }
    }
}
