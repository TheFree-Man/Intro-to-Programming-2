using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            double quotient;
            bool isValid;

            do
            {
                try
                {
                    isValid = true;

                    Console.WriteLine("enter the first number : ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second number : ");
                    num2 = int.Parse(Console.ReadLine());

                    quotient = Divide(num1, num2);
                    Console.WriteLine("The quotient is {0}", quotient);
                }
                catch (ArithmeticException myError)
                {
                    Console.WriteLine(myError.Message);

                    isValid = false;
                }
                finally
                {
                    Console.WriteLine("In Finally block");
                }
            }
            while (isValid == false);

        }

        public static double Divide(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArithmeticException ("Cannot divide by zero");

            else
                return (double)numerator / denominator;


        }
    }
}
