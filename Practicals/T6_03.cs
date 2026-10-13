using System;
delegate int Calculate(int a, int b);
class T6_03
{
    static int Add(int a, int b)
    {
        return a + b;
    }
    static int Subt(int a, int b)
    {
        return a - b;
    }
    static int Multi(int a, int b)
    {
        return a * b;
    }
    static void Main()
    {
        Console.Write("Enter first number:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number:");
        int b = Convert.ToInt32(Console.ReadLine());

        //Delegatename variables
        Calculate c;
        c = Add;
        Console.WriteLine("Addition:" + c(a, b));
        c = Subt;
        Console.WriteLine("Subtraction:" + c(a, b));
        c = Multi;
        Console.WriteLine("Multiplication:" + c(a, b));

        //to run this program, use the command line and provide three arguments:
        // csc T6_03.cs
        // T6_03.exe
    }
}