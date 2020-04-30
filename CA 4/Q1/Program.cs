/*
 * Description: Displays account information and checks for credit and charge
 * 
 * Author     : Mark Gilmartin
 * 
 * Date       : 20/04/2020
*/

using System;
using System.IO;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays for Customer and Trial Customer
            Customer[] myCustomers = new Customer[2];
            TrialCustomer[] myTrialCustomers = new TrialCustomer[2];

            // Customer object 1
            myCustomers[0] = new Customer();
            myCustomers[0].Name = "Mandy";
            Console.WriteLine(myCustomers[0].ToString());

            // Customer object 2
            myCustomers[1] = new TrialCustomer("Jimmy", 500, 1000);
            Console.WriteLine(myCustomers[1].ToString());

            // Trial Customer object 1
            myTrialCustomers[0] = new TrialCustomer("Anastasia", 500, 1000);
            Console.WriteLine(myTrialCustomers[0].ToString());

            // Trial Customer object 2
            myTrialCustomers[1] = new TrialCustomer("Maximilian", 0, 500);
            Console.WriteLine(myTrialCustomers[1].ToString());
            bool isValid = myTrialCustomers[1].AddCharge(700);
            // Checks if charge can be added
            if (isValid == true)
            {
                Console.WriteLine(myTrialCustomers[1].ToString());
            }
            else
            {
                Console.WriteLine("\nInsufficient credit");
            }

            // try, catch block to check if filehandling is working
            try
            {
                // Arrays for customers in csv file
                Customer[] myCustomersCSV = new Customer[5];
                string[] fields = new string[3];

                FileStream fs = new FileStream(@"../../customers.txt", FileMode.Open, FileAccess.Read);
                StreamReader inputStream = new StreamReader(fs);
                string lineIn;
                lineIn = inputStream.ReadLine();
                
                int count = 0;
                double accountBalance = 0, maxCredit = 0;
                while (lineIn != null)
                {
                    // checks if there are 3 fields for each customer
                    fields = lineIn.Split(',');
                    if (fields.Length == 3)
                    {
                        accountBalance = double.Parse(fields[1]);
                        maxCredit = double.Parse(fields[2]);
                        myCustomersCSV[count] = new TrialCustomer(fields[0], accountBalance, maxCredit);
                    }
                    else
                    {
                        accountBalance = double.Parse(fields[1]);
                        myCustomersCSV[count] = new Customer(fields[0], accountBalance);
                    }
                    count++;
                    lineIn = inputStream.ReadLine();
                }

                inputStream.Close();
                for (int i = 0; i < myCustomersCSV.Length; i++)
                {
                    Console.WriteLine(myCustomersCSV[i].ToString());
                }

            }
            catch (Exception myError)
            {

                Console.WriteLine(myError);
            }
        }
    }
}
