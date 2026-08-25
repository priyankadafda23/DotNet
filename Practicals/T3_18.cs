using System;

namespace Practicals
{
    //base class
    class Employee2
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public double BasicSalary { get; set; }

        //virtual method
        public virtual void GenerateSalarySlip()
        {
            Console.WriteLine("Employee Salary Slip.");
        }
    }
    //inherited class
    class PermanentEmployee1 : Employee2
    {
        public override void GenerateSalarySlip()
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

    class ContractEmployee1 : Employee2
    {
        public override void GenerateSalarySlip()
        {
            double netSalary = BasicSalary;

            Console.WriteLine("\n-----Contract Employee-----");
            Console.WriteLine("Employee ID: " + EmployeeID);
            Console.WriteLine("Employee Name: " + EmployeeName);
            Console.WriteLine("Salary: " + netSalary);
        }
    }
    class T3_18
    {
        public static void T3_18Main()
        {
            Employee2 e = new Employee2();
            e.GenerateSalarySlip();

            PermanentEmployee1 p = new PermanentEmployee1();
            p.EmployeeID = 101;
            p.EmployeeName = "Priyanka";
            p.BasicSalary = 20000;
            p.GenerateSalarySlip();

            ContractEmployee1 c = new ContractEmployee1();
            c.EmployeeID = 102;
            c.EmployeeName = "Prachi";
            c.BasicSalary = 30000;
            c.GenerateSalarySlip();
        }
    }
}