using System;

namespace Practicals
{
    class Employee4
    {
        private int employeeCode;
        private string name;
        private string designation;
        private double basicPay;
        private double hra;
        private double da;
        private double totalPay;

        //constructor to initialize employee detials
        public Employee4(int code, string empName, string desig, double pay)
        {
            employeeCode = code;
            name = empName;
            designation = desig;
            basicPay = pay;
        }

        //method to calculate and display hra, da and total pay
        public void calculate()
        {
            hra = basicPay * 0.20;
            da = basicPay * 0.10;
            totalPay = basicPay + hra + da;
        }
        public void display()
        {
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("Code: " + employeeCode);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Basic Pay: " + basicPay);
            Console.WriteLine("HRA(10%): " + hra);
            Console.WriteLine("DA(45%): " + da);
            Console.WriteLine("Total Pay: : " + totalPay);
        }
    }
    class T4_01
    {
        public static void T4_01Main()
        {
            Employee4 s = new Employee4(101, "Priyanka", "Developer", 30000);
            s.calculate();
            s.display();
            Employee4 s1 = new Employee4(102, "Ticha", "Developer", 35000);
            s1.calculate();
            s1.display();
        }
    }
}