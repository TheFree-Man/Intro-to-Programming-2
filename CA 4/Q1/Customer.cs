using System;
using System.Collections.Generic;
using System.Text;

namespace Q1
{
    class Customer
    {
        private int customerID = 0;
        private string name;
        private double accountBalance;

        public int CustomerID { get; set; }
        public string Name { get; set; }
        public double AccountBalance
        {
            get
            {
                return accountBalance;
            }
            set
            {
                accountBalance = value;
            }
        }

        public Customer()
        {
            customerID = DHCPserver();

            accountBalance = 0;
        }

        public int DHCPserver()
        {
            customerID++;
            return customerID;
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
