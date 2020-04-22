using System;
using System.Collections.Generic;
using System.Text;

namespace Q1
{
    class Customer
    {
        protected int _customerID;
        protected string _name;
        protected double _accountBalance;
        protected double _moneyOwed;

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
        public double MoneyOwed
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
        public double AccountBalance
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

        public Customer(string n, double c)
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

        public virtual bool AddCharge()
        {
            try
            {
                _accountBalance -= _moneyOwed;
            }
            catch (ArithmeticException myError)
            {
                Console.WriteLine(myError);
            }

            return true;
        }

        public override string ToString()
        {
            return string.Format("\nCustomer number is        :      {0}\nCustomer name is          :      {1}\nMoney Owed is             :      {2}", _customerID, _name, _moneyOwed);
        }
    }

    class TrialCustomer : Customer
    {
        protected double _maxCreditAvailable;
        public double MaxCreeditAvailable
        {
            get
            {
                return _maxCreditAvailable;
            }
            set
            {
                _maxCreditAvailable = value;
            }
        }

        TrialCustomer() : base()
        {
            _maxCreditAvailable = 0;
        }

        public TrialCustomer(string n, double c, double m) : base(n, c)
        {
            _maxCreditAvailable = m;
        }

        public virtual bool AddCharge(double _moneyOwed)
        {
            if ( _accountBalance + _maxCreditAvailable > _moneyOwed)
            {
                _accountBalance -= _moneyOwed;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            return string.Format("\nCustomer number is        :      {0}\nCustomer name is          :      {1}\nMoney Owed is             :      {2:c}\nMax Credit                :      {3:c}", _customerID, _name, _moneyOwed, _maxCreditAvailable);
        }
    }
}
