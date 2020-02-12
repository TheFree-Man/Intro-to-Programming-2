/*
 * Description: Program will read in the name of the product, the number of units purchaced, 
 *              and output a receipt
 * 
 * Author: Mark Gilmartin
 * 
 * Date: 10/02/2020
 */

using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static string[] items = new string[10];
        static int[] quantities = new int[10];
        static double[] unitPrices = new double[10];
        static double[] cost = new double[10];
        static int counter = 0;

        static void Main(string[] args)
        {
            string item = "";
            int quantity;
            // Input
            while (counter < 10)
            {
                Console.Write("Please enter item name, type exit to quit : ");
                item = Console.ReadLine();
                item = item.ToLower();
                if (item != "twix" && item != "coke" && item != "sprite" && item != "crunchie" && item != "biscuits" && item != "sandwich" && item!= "soup" && item != "pizza slice" && item != "ice cream" && item != "exit" )
                {
                    Console.WriteLine("Error, please try again");
                    continue;
                }
                else if (item == "exit")
                {
                    break;
                }

                Console.Write("Please enter qantity : ");
                quantity = int.Parse(Console.ReadLine());

                // Storing values in an array
                items[counter] = item;
                UnitPrice(item);

                quantities[counter] = quantity;
                counter++;
            }
        }

        static double UnitPrice(string item)
        {
            double unitPrice = 0;

            // Determines the price of each item in the items[] array
            switch (item)
            {
                case "twix":
                    unitPrice = 0.78;
                    break;

                case "coke":
                    unitPrice = 0.95;
                    break;
                case "sprite":
                    unitPrice = 0.95;
                    break;

                case "crunchie":
                    unitPrice = 0.89;
                    break;

                case "biscuits":
                    unitPrice = 2.50;
                    break;

                case "soup":
                    unitPrice = 2.95;
                    break;

                case "pizza slice":
                    unitPrice = 1.50;
                    break;

                case "ice cream":
                    unitPrice = 1.75;
                    break;

                default:
                    break;
            }

            unitPrices[counter] = unitPrice;

            return unitPrice;
        }

        static void PriceCalculation()
        {
            double cost;
            double subtotal;
            double totalCost;
            
            // Calculates cost, Subtotal, and Total Cost
            for (int i = 0; i < counter; i++)
            {
                cost = quantities[i] * unitPrices[i];
            }
        }
    }
}
