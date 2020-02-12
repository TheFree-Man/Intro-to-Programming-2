using System;

namespace Q1
{
    class Program
    {
        static int day;

        static void Main(string[] args)
        {

            Console.Write("Enter a day number: ");
            day = int.Parse(Console.ReadLine());

            Day();
        }

        static void Day()
        {
            switch (day)
            {
                case 1:
                    Console.WriteLine("Day is Monday");
                    break;
                case 2:
                    Console.WriteLine("Day is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Day is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Day is Thursday");
                    break;
                case 5:
                    Console.WriteLine("Day is Friday");
                    break;
                case 6:
                    Console.WriteLine("Day is Saturday");
                    break;
                case 7:
                    Console.WriteLine("Day is Sunday");
                    break;
                default:
                    Console.WriteLine("An unexpected value ({0})", day);
                    break;
            }
        }

    }
}
