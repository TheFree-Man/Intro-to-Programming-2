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
        public int moneyOwed { get; set; }
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

        public Customer(int c, string n, double a, int charge)
        {
            customerID = c;
            Name = n;
            accountBalance = a;
            moneyOwed = charge;
        }

        public int DHCPserver()
        {
            customerID++;
            return customerID;
        }

        public double AddCharge()
        {
            return accountBalance - moneyOwed;
        }
        public override string ToString()
        {
            return string.Format("Customer number is        :      {0}\nCustomer name is          :      {1}\nMoney Owed is             :      {2}", customerID, Name, AddCharge());
        }
    }
}
