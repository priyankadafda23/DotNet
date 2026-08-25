using System;

namespace Practicals
{
    //base keyword is used to inherit the parent's class method/constructor in the child class.

    //base class
    class Students2
    {
        protected int roll_no;
        protected string name;
        public Students2(int roll_no, string name)
        {
            this.roll_no = roll_no;
            this.name = name;
        }
    }

    //derived class
    class StudentsDetails : Students2
    {
        private int age;
        public StudentsDetails(int age, int roll_no,string name) : base(roll_no,name) 
        {
                this.age = age;
        }
        public void Display()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine("Roll number: " + roll_no);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }

    class T3_21
    {
        public static void T3_21Main()
        {
            StudentsDetails s1 = new StudentsDetails(19,1, "Priyanka");
            StudentsDetails s2 = new StudentsDetails(19, 2, "Ticha");

            s1.Display();
            s2.Display();
        }
    }
}