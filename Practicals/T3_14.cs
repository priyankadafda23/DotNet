using System;

namespace Practicals
{
    class Employees
    {
        private double salary;
        public void SetSalary(double amount)
        {
            if (amount > 0)
            {
                salary = amount;
            }
            else
            {
                Console.WriteLine("Invalid Salary");
            }
        }
        public double GetSalary() { 
            return salary; 
        }
    }
    class T3_14
    {
        public static void T3_14Main()
        {
            Employees e1 = new Employees();

            Console.Write("Enter Salary: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            e1.SetSalary(amount);

            Console.WriteLine("Employee Salary: " + e1.GetSalary());
        }
    }
}