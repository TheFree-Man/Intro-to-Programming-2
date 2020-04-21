using System;
using System.Collections.Generic;
using System.Text;

namespace Q1
{
    class Customer
    {
        private int _customerID;
        private string _name;
        private decimal _accountBalance;
        private decimal _moneyOwed;

        public int CustomerID
        {
            get
            {
                return _customerID;
            }
            set
            {
                _customerID = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public decimal MoneyOwed
        {
            get
            {
                return _moneyOwed;
            }
            set
            {
                _moneyOwed = value;
            }
        }
        public decimal AccountBalance
        {
            get
            {
                return _accountBalance;
            }
            set
            {
                _accountBalance = value;
            }
        }

        public Customer()
        {
            _customerID = AcNoGenerator();
            _accountBalance = 0;
        }

        public Customer(string n, decimal c)
        {
            _customerID = AcNoGenerator();

            _accountBalance = 0;

            _name = n;

            _moneyOwed = c;
        }

        public int AcNoGenerator()
        {
            Random rnd = new Random();
            _customerID = rnd.Next(1, 99);
            return _customerID;
        }

        public virtual decimal AddCharge()
        {
            return _accountBalance - _moneyOwed;
        }
        public override string ToString()
        {
            return string.Format("Customer number is        :      {0}\nCustomer name is          :      {1}\nMoney Owed is             :      {2}", _customerID, _name, _moneyOwed);
        }
    }
}
