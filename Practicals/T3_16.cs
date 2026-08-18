using System;

namespace Practicals
{
    //base class
    class Employee1
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public double BasicSalary { get; set; }
    }
    //inherited class
    class PermanentEmployee : Employee1
    {
        public void CalculateSalary()
        {
            double hra = BasicSalary * 0.20;
            double da = BasicSalary * 0.10;
            double netSalary = BasicSalary + hra + da;

            Console.WriteLine("\n-----Permanent Employee-----");
            Console.WriteLine("Employee ID: " + EmployeeID);
            Console.WriteLine("Employee Name: " + EmployeeName);
            Console.WriteLine("Basic Salary: " + BasicSalary);
            Console.WriteLine("HRA: " + hra);
            Console.WriteLine("DA: " + da);
            Console.WriteLine("Net Salary: " + netSalary);
        }
    }

    class ContractEmployee : Employee1
    {
        public void CalculateSalary()
        {
            double netSalary = BasicSalary;

            Console.WriteLine("\n-----Contract Employee-----");
            Console.WriteLine("Employee ID: " + EmployeeID);
            Console.WriteLine("Employee Name: " + EmployeeName);
            Console.WriteLine("Salary: " + netSalary);
        }
    }
    class T3_16
    {
        public static void T3_16Main()
        {
            PermanentEmployee p = new PermanentEmployee();
            p.EmployeeID = 101;
            p.EmployeeName = "Priyanka";
            p.BasicSalary = 20000;
            p.CalculateSalary();

            ContractEmployee c= new ContractEmployee();
            c.EmployeeID = 102;
            c.EmployeeName = "Prachi";
            c.BasicSalary = 30000;
            c.CalculateSalary();
        }
    }
}