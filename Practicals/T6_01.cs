using System;

namespace Practicals
{
    interface IEmployee
    {
        void AcceptEmpDetails();
        void DisplayEmpDetails();
    }
    class Employee6 : IEmployee
    {
        string name, des;
        int age;
        public void AcceptEmpDetails()
        {
            Console.Write("Enter name:");
            name = Console.ReadLine();

            Console.Write("Enter designation:");
            des = Console.ReadLine();

            Console.Write("Enter age:");
            age = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayEmpDetails()
        {
            Console.WriteLine("\nEmployee Details: ");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Designation: " + des);
            Console.WriteLine("Age: " + age);
        }
    }
    class T6_01
    {
        public static void T6_01Main()
        {
            Employee6 e = new Employee6();
            e.AcceptEmpDetails();
            e.DisplayEmpDetails();
            
        }
    }
}