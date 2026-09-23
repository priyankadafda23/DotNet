using System;

namespace Practicals
{
    //base class
    class Person4
    {
        private string name;
        protected int age;
        public string address;
        //constructor
        public Person4(string nm, int ag, string addr)
        {
            name = nm;
            age = ag;
            address = addr;
        }
        public void ShowName()
        {
            Console.WriteLine("Name: " + name);
        }
        public void ShowAge()
        {
            Console.WriteLine("Age: " + age);
        }
        public void ShowAddress() 
        { 
            Console.WriteLine("Address: " + address);
        }
    }
    //derived class
    class Student4 : Person4
    {
        private int rollNo;
        protected string branch;
        public double marks;
        public Student4(string name, int age, string address, int roll, string br, double m) : base(name, age, address)
        {
            rollNo = roll;
            branch = br;
            marks = m;
        }
        public void ShowRollNo()
        {
            Console.WriteLine("Roll No: " + rollNo);
        }
        public void ShowBranch()
        {
            Console.WriteLine("Branch: " + branch);
        }
        public void ShowMarks()
        {
            Console.WriteLine("Marks: " + marks);
        }

        //method to call all strudent details
        public void DisplayStudent()
        {
            ShowName();
            ShowAge();
            ShowAddress();
            ShowRollNo();
            ShowBranch();
            ShowMarks();
        }
    }
    class T4_03
    {
        public static void T4_03Main()
        {
            Student4 s1= new Student4("Priyanka", 20, "Bhuj", 38, "CE", 85.5);
            Console.WriteLine("Student 1 Details:");
            s1.DisplayStudent();
            Student4 s2= new Student4("Ticha", 19, "Ahmedabad", 46, "IT", 90.0);
            Console.WriteLine("\nStudent 2 Details:");
            s2.DisplayStudent();


        }
    }
}
