using System;

namespace Q2
{
    class Program
    {
        static string productCode;
        static double amount;
        static double multiple;
        static double total;

        static void Main(string[] args)
        {
            Console.Write("Enter product code: ");
            productCode = Console.ReadLine().ToUpper();

            PriceCalculation();

            Console.Write("how many are you ordering: ");
            multiple = int.Parse(Console.ReadLine());

            total = amount * multiple;

            Console.Write("The total is {0:c},", total);
        }

        static void PriceCalculation()
        {
            switch (productCode)
            {
                case "ASD":
                    amount = 67.95;
                    break;

                case "THF":
                    amount = 68.90;
                    break;

                case "TYG":
                    amount = 34.95;
                    break;

                case "GHT":
                    amount = 88.90;
                    break;

                case "YUR":
                    amount = 23.80;
                    break;

                case "UIT":
                    amount = 9.90;
                    break;

                case "HIT":
                case "UIP":
                case "RRT":
                case "JJK":
                case "IOP":
                    amount = 10;
                    break;

                default:
                    break;
            }
        }
    }
}
