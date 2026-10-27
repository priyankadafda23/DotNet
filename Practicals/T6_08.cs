using System;

namespace Practicals
{
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message): base(message)
        {

        }
    }
    class BankAccount
    {
        double balance = 50000;
        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new InsufficientBalanceException("\nERROR: "+"Insufficient balance!");
            }
            balance = balance - amount;
            Console.WriteLine("Withdrawal Successful!");
            Console.WriteLine("Remaining Balance: " + balance);
        }
    }
    class T6_08
    {
        public static void T6_08Main()
        {
            BankAccount b = new BankAccount();

            try
            {
                Console.Write("Enter withdrawal amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                b.Withdraw(amount);
            }
            catch (InsufficientBalanceException e)
            {
                Console.WriteLine("ERROR:" + e);
            }
        }
    }
}