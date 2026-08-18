using System;

namespace Practicals
{
    //base class
    class Studenti
    {
        public string course { get; set; }
        public string department { get; set; }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("\n-----Student Details-----");
            Console.WriteLine("Course is " + course);
            Console.WriteLine("Department is " + department);
        }
    }
    //inherited class
    class Person : Studenti
    {
        public string name { get; set; }
        public int age { get; set; }

        public void DisplayPersonDetails()
        {
            Console.WriteLine("\n-----Person Details-----");
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Age is " + age);
        }
    }
    class T3_15
    {
        public static void T3_15Main()
        {
            Person p1 = new Person();
            Console.Write("Enter Name:");
            p1.name = Console.ReadLine();

            Console.Write("Enter Age:");
            p1.age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Course:");
            p1.course = Console.ReadLine();

            Console.Write("Enter Department:");
            p1.department = Console.ReadLine();

            p1.DisplayPersonDetails();
            p1.DisplayStudentDetails();

        }
    }
}