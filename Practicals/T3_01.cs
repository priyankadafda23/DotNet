using System;

namespace Practicals
{
    class Prog1
    {
        private int enroll_no;
        private string name;
        private string branch;

        //constructor
        public void Student(int eno, string n, string b)
        {
            enroll_no= eno;
            name = n;
            branch = b;

        }
        //static method to display student details
        public void display()
        {
            Console.WriteLine("---Student Details:---");
            Console.WriteLine("Enrollment number: " + enroll_no);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Branch: " + branch);

        }
    }
    internal class T3_01
    {
        public static void T3_01Main()
        {
            Prog1 p1 = new Prog1(); //creating object
            Prog1 p2 = new Prog1();//creating object

            //Static values
            //int e = 14;
            //string n = "Priyanka";
            //string b = "CSE";

            //user inputs
            Console.Write("Enter Enrollment number:");
            int e=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name:");
            string n=Console.ReadLine();

            Console.Write("Enter Branch:");
            string b=Console.ReadLine();

            p1.Student(e, n, b); //passing values to method
            p1.display(); //display values

            p2.Student(102, "Tisha", "CSE"); //passing values to method
            p2.display(); //display values

        }
    }
}