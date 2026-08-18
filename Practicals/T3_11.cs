using System;

namespace Practicals
{
    class BankAccounts
    {
        private int accNo;
        private string accHolderName;
        private double accBalance;
        public BankAccounts(int ano, string name, double balance)
        {
            accNo = ano;
            accHolderName = name;
            accBalance = balance;
        }
        public void Deposit(double amount)
        {
            accBalance += amount;
            Console.WriteLine("Amount Deposited Successfully!");
        }
        public void Withdraw(double amount)
        {
            if (amount <= accBalance)
            {
                accBalance -= amount;
                Console.WriteLine("Withdraw successfully!");
            }
            else
            {
                Console.WriteLine("Insufficient Balance!");
            }
        }
        public void BalanceEnquiry()
        {
            Console.WriteLine("-----Balance Inquiry-----");
            Console.WriteLine("Account Number: " + accNo);
            Console.WriteLine("Account Holder Name: " + accHolderName);
            Console.WriteLine("Current Balance: " + accBalance);
        }
    }
    class T3_11
    {
        public static void T3_11Main()
        {
            BankAccounts b1 = new BankAccounts(101, "Priyanka", 5000);
            Console.WriteLine("\nAccount-1 Transactions:");
            b1.Deposit(2000);
            b1.Withdraw(3000);
            b1.BalanceEnquiry();

            BankAccounts b2 = new BankAccounts(102, "Ticha", 10000);
            Console.WriteLine("\nAccount-2 Transactions:");
            b2.Deposit(4000);
            b2.Withdraw(6000);
            b2.BalanceEnquiry();

            Console.WriteLine("\n-------User Input-------");
            Console.Write("Enter account number:");
            int ac = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter name:");
            string an = Console.ReadLine();

            Console.Write("Enter Balance:");
            double ab = Convert.ToDouble(Console.ReadLine());

            BankAccounts b3 = new BankAccounts(ac, an, ab);
            Console.WriteLine("\nAccount Details:");
            b3.BalanceEnquiry();
        }

    }
}