using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] myCustomers = new Customer[4];

            myCustomers[0] = new Customer("Mandy", 0);
            Console.WriteLine(myCustomers[0].ToString());

            myCustomers[1] = new Customer("Jamie", 500);
            Console.WriteLine(myCustomers[1].ToString());
        }
    }
}
