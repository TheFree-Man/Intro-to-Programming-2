using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] myCustomers = new Customer[4];

            myCustomers[0] = new Customer();
            myCustomers[0].Name = "Mandy";
            Console.WriteLine(myCustomers[0].ToString());

            myCustomers[1] = new TrialCustomer("Jimmy", 500, 1000);
            Console.WriteLine(myCustomers[1].ToString());
        }
    }
}
