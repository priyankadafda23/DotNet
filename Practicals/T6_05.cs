using System;

class BankAccount
{
    public delegate void DepositHandler();
    public event DepositHandler DepositEvent;
    public void Deposit(double amount)
    {
        Console.WriteLine("Amount deposited Successfully: " + amount);
        if (DepositEvent != null)
        {
            DepositEvent();
        }
    }
}
class T6_05
{
    static void DepositMessage()
    {
        Console.WriteLine("Event: Amount Deposited Successfully!");
    }
    static void Main()
    {
        Console.WriteLine("Dafda Priyanka Tarunbhai - 25SOECE13051\n");
        //Delegatename variables
        BankAccount ba = new BankAccount();
        ba.DepositEvent += DepositMessage;
        ba.Deposit(5000);

        //to run this program, use the command line and provide three arguments:
        // csc T6_05.cs
        // T6_05.exe
    }
}