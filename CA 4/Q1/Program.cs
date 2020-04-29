using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] myCustomers = new Customer[2];
            TrialCustomer[] myTrialCustomers = new TrialCustomer[2];

            myCustomers[0] = new Customer();
            myCustomers[0].Name = "Mandy";
            Console.WriteLine(myCustomers[0].ToString());

            myCustomers[1] = new TrialCustomer("Jimmy", 500, 1000);
            Console.WriteLine(myCustomers[1].ToString());

            myTrialCustomers[0] = new TrialCustomer("Anastasia", 500, 1000);
            Console.WriteLine(myTrialCustomers[0].ToString());

            myTrialCustomers[1] = new TrialCustomer("Maximilian", 0, 500);
            Console.WriteLine(myTrialCustomers[1].ToString());
            bool isValid = myTrialCustomers[1].AddCharge(700);
            if (isValid == true)
            {
                Console.WriteLine(myTrialCustomers[1].ToString());
            }
            else
            {
                Console.WriteLine("\nInsufficient credit");
            }

            try
            {
                Customer[] myCustomersCSV = new Customer[5];
                FileStream fs = new FileStream(@"../../customers.txt", FileMode.Open, FileAccess.Read);

            }
            catch (Exception myError)
            {

                Console.WriteLine(myError); ;
            }
        }
    }
}
