using System;

namespace Practicals
{
    class Student
    {
        private int enroll;
        private string name;
        public Student(int e, string n)
        {
            enroll = e;
            name = n;
        }
        public void display()
        {
            Console.WriteLine("Enrollment Number is{0}\n Name is {1}", enroll, name);
        }
    }
    class T3_07
    {
        public static void T3_07Main()
        {
            Console.Write("Enter Enrollment Number: ");
            int e= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            string n = Console.ReadLine();
            Student s = new Student(e, n);
            s.display();
        }
    }
}