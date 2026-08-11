using System;

namespace Practicals
{
    class Student8
    {
        private int enroll;
        private string name;
        private string course;
        private int age;
        public Student8(int e, string n, string c, int a)
        {
            enroll = e;
            name = n;
            course = c;
            age = a;
        }
        public void display()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine("Enrollment Number: " + enroll);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("Age: " + age);
        }
    }
    class T3_08
    {
        public static void T3_08Main()
        {
            Console.Write("Enter Enrollment Number: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            string n = Console.ReadLine();
            Console.Write("Enter Course: ");
            string c = Console.ReadLine();
            Console.Write("Enter Age: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Student8 s = new Student8(e, n,c,a);
            s.display();
        }
    }
}