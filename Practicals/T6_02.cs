using System;

namespace Practicals
{
    interface IPersonalDetails
    {
        void PersonalDetails();
    }
    interface IProfessionalDetails
    {
        void ProfessionalDetails();
    }
    class Employee62 : IPersonalDetails, IProfessionalDetails
    {
        string name,gender,des;
        int age;
        double salary;
        int exp;
        public void PersonalDetails()
        {
            Console.Write("Enter name:");
            name = Console.ReadLine();

            Console.Write("Enter age:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter gender:");
            gender = Console.ReadLine();

            Console.WriteLine("\n---Personal Details---");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
        }
        public void ProfessionalDetails()
        {
            Console.Write("\nEnter designation:");
            des = Console.ReadLine();

            Console.Write("Enter salary:");
            salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter years of experience:");
            exp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n---Professional Details---");
            Console.WriteLine("Designation: " + des);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Experience: " + exp);
        }
    }
    class T6_02
    {
        public static void T6_02Main()
        {
            Employee62 e = new Employee62();
            e.PersonalDetails();
            e.ProfessionalDetails();
        }
    }
}