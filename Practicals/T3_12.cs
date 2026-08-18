using System;

namespace Practicals
{
    class StudentDetails
    {
        public int enrollNo { get; set; }
        public string Name { get; set; }
    }
    class T3_12
    {
        public static void T3_12Main()
        {
            StudentDetails s1 = new StudentDetails();

            Console.Write("Enter Enrollment Number:");
            s1.enrollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name:");
            s1.Name=Console.ReadLine();

            Console.WriteLine("\n-----Student Details-----");
            Console.WriteLine("Enrollment Number is "+ s1.enrollNo);
            Console.WriteLine("Name is " + s1.Name);
        }
    }
}