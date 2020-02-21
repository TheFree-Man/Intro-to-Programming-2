using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter;
            string inputString;

            Console.Write("Enter characters: ");
            inputString = Console.ReadLine();
            Console.WriteLine();

            counter = printCharacters(inputString);

            Console.WriteLine("amount of X & Y = {0}", counter);
        }

        static int printCharacters(string inputString)
        {
            int counter = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == 'x' || inputString[i] == 'y')
                {
                    counter++;
                }
            }

            return counter;

        }
    }
}
