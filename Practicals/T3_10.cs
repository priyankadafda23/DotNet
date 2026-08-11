using System;

namespace Practicals
{
    class Employee
    {
        private int eid;
        private string name;
        private double basicSalary;
        private double netSalary;
        public Employee(int e, string n,double salary)
        {
            eid = e;
            name = n;
            basicSalary = salary;
        }
        public void calculate()
        {
            double hra = basicSalary * 0.20;
            double da = basicSalary * 0.10;
            netSalary = basicSalary + hra + da;
        }
        public void display()
        { 
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("ID: " + eid);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Basic Salary: " + basicSalary);
            Console.WriteLine("Net Salary: " + netSalary);
        }
    }
    class T3_10
    {
        public static void T3_10Main()
        {
            Console.Write("Enter ID: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            string n = Console.ReadLine();
            Console.Write("Enter Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Employee s = new Employee(e, n, salary);
            s.calculate();
            s.display();
        }
    }
}