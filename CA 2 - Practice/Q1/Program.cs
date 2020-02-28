/*
 * Description: takes as input a series of student marks terminated with a value of -999.  For each value input, the grade is be determined and displayed.
 *              The program also keeps a count of students getting each grade as well as the cumulative marks. Thus, it is able to determine the average
 *              mark for each grade.
 * 
 * Author     : Mark Gilmartin
 * 
 * Date       : 28/02/2020
*/

using System;

namespace Q1
{
    class Program
    {
        static string[] GradeName = new string[] { "F", "E", "D", "C", "B", "A" };
        static double[] GradeTotals = new double[5];
        static double

        static void Main(string[] args)
        {
            int i;
            double studentMark;

            for (i= 0; i != -999;)
            {
                Console.Write("Enter student mark: ");
                studentMark = double.Parse(Console.ReadLine());
                getGradeIndex(studentMark);
            }
        }

        static int getGradeIndex(double studentMark)
        {

        }
    }
}
