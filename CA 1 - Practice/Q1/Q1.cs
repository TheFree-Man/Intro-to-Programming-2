/*
 * Description: Application to calculate insurance premiums and produce a report giving a 
 *              breaking down of the numbers of male and female customers and their ages.
 *              A maximum of 100 quotes will be given.
 *              
 * Author: Mark Gilmartin
 * 
 * Date: 07/20/2020
 */

using System;

namespace Q1
{
    class Q1
    {
        static int option;

        static void Main(string[] args)
        {
            // Menu System
            while (option != 3)
            {
                Console.WriteLine("\nMenu");

                Console.WriteLine("\n1. Calculate Quote");
                Console.WriteLine("2. Print Statistics");
                Console.WriteLine("3. Exit");
                
                Console.Write("\nEnter Choice: ");
                option = int.Parse(Console.ReadLine());

                if (option == 1)
                {

                }
                else if (option == 2)
                {

                }
                else
                {
                    Console.WriteLine("\nError, please try again");
                    continue;
                }
            }
        }
    }
}
