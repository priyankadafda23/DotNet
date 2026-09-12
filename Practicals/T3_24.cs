using System;
using System.Collections.Generic;
using System.Text;

namespace Practicals
{
    sealed class Employee24
    {
        public double emp_salary { get; set; }
        public string designation { get; set; }

        public Employee24(double emp_salary, string designation)
        {
            this.emp_salary = emp_salary;
            this.designation = designation;
        }

        public void EmployeeDetails()
        {
            Console.WriteLine("Employee Salary: " + emp_salary);
            Console.WriteLine("Employee Designation: " + designation);
        }
    }

    class T3_24
    {
        public static void T3_24Main()
        {
            Employee24 emp1 = new Employee24(50000, "Software Engineer");
            emp1.EmployeeDetails();
        }
    }
}
