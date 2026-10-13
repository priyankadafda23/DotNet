using System;
delegate void StudentDetails();
class T6_04
{
    static void DisplayName()
    {
        Console.WriteLine("Student Name: Priyanka");
    }
    static void DisplayCourse()
    {
        Console.WriteLine("Student Course: BTech");
    }
    static void DisplaySem()
    {
        Console.WriteLine("Student Sem: 5");
    }
    static void Main()
    {

        //Delegatename variables
        StudentDetails sd;
        sd = DisplayName;

        sd += DisplayCourse;
        sd += DisplaySem;

        // Invoke the multicast delegate
        sd();

        //to run this program, use the command line and provide three arguments:
        // csc T6_04.cs
        // T6_04.exe
    }
}