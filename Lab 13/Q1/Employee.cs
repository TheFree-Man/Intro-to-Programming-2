using System;

namespace Q1
{
    class Program
    {
        // program to test our class
        static void Main(string[] args)
        {
            Employee myEmployee; // declares an object of type Employee
            myEmployee = new Employee(); // create an object of type employee
            myEmployee._name = "Mary"; // set the name of the employee to "Mary"
            myEmployee._name2 = "John";
            myEmployee.PrintName();
            Console.WriteLine(Employee.t());
        }
    }

    class Employee
    {
        public string _name;  // the name field
        public string _name2;

        //default constructor
        public Employee()
        {

        }

        //parameterised constructor
        public Employee(string n)
        {
            _name = n;
        }

        //method
        public void PrintName()
        {
            Console.WriteLine("Name is {0}", _name);
        }
        public override string ToString() 
        { 
            return "Name is" + _name2.ToString(); 
        }
    }
}
