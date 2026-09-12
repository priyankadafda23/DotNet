using System;

namespace Practicals
{
    //base keyword is used to inherit the parent's class method/constructor in the child class.

    //base class
    class Student22
    {
        private string course;
        public void DisplayDetails()
        {
            Console.WriteLine("My Course is BTech-CE");
        }
    }

    //derived class
    class Stu : Student22
    {
        public new void DisplayDetails()
        {
            Console.WriteLine("My Course is MTech-CE");
        }
    }

    class T3_22
    {
        public static void T3_22Main()
        {
            Stu s1 = new Stu();
            s1.DisplayDetails(); // Calls the derived class method
        }
    }
}