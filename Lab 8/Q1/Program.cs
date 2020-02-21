using System;

namespace Q1
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
            for (int i = 0; i < inputString.Length; i++)
            {
                Console.WriteLine("{0}", inputString[i]);
            } 

        }
    }
}
