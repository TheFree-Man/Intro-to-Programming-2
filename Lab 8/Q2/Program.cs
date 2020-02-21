using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString;

            Console.Write("Enter characters: ");
            inputString = Console.ReadLine();
            Console.WriteLine();

            printCharacters(inputString);
        }

        static void printCharacters(string inputString)
        {
            for (int i = 2; i < inputString.Length; i += 3)
            {
                Console.WriteLine("{0}", inputString[i]);
            }

        }

    }
}
