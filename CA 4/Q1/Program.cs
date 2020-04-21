using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer Customer1;
            Customer1 = new Customer();
            Customer1.Name = "Mandy";
            Console.WriteLine("Customer1 = {0}", Customer1.Name);
            Console.Write("\nEnter amount: ");
            int charge = int.Parse(Console.ReadLine());
            Console.WriteLine(Customer1.ToString());
        }
    }
}
