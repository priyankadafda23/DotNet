using System;

namespace Practicals
{
    //this keyword belongs to the current object
    class Students1
    {
        private int roll_no;
        private string name;
        public Students1(int roll_no, string name)
        {
            this.roll_no=roll_no;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine("Roll number: " + roll_no);
            Console.WriteLine("Name: "+ name);
        }
    }

    class T3_20
    {
        public static void T3_20Main()
        {
            Students1 s1 = new Students1(1, "Priyanka");
            Students1 s2 = new Students1(2, "Ticha");

            s1.Display();
            s2.Display();
        }
    }
}