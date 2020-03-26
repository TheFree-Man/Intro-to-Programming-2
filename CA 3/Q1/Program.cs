/*
 * Description: Programme that lets a user view player reports, 
 *              location analysis reports, and search for a player.
 *              
 * Author     : Mark Gilmartin
 * 
 * Date       : 
*/
using System;
using System.IO;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int userChoice = 0;
            bool validInput = false;
            bool validValue = false;

            do
            {
                Console.WriteLine("\nMenu\n");
                Console.WriteLine("1. Player Report");
                Console.WriteLine("2. Location Analysis Report");
                Console.WriteLine("3. Search for a player");
                Console.WriteLine("4. Exit");

                validInput = true;
            } while (!validInput);

            while (!validValue)
            {
                do
                {
                    Console.Write("\nEnter Choice: ");
                }
                while (!int.TryParse(Console.ReadLine(), out userChoice));

                if (userChoice < 1 || userChoice > 4)
                {
                    Console.WriteLine("\nInvalid value, Please try again");
                }
                else
                {
                    validValue = true;
                }
            }
        }
    }
}
