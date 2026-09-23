using System;

namespace Practicals
{
    //Abstract class
    abstract class Account
    {
        protected double amount;
        public Account(double amount)
        {
            this.amount = amount;
        }

        //Abstract method
        public abstract void CalculateInterest();
    }

    //Derived class
    class SavingsAccount : Account
    {
        public SavingsAccount(double amount) : base(amount) { }
        public override void CalculateInterest()
        {
            Console.WriteLine("Saving Account Interest= " + (amount * 4 / 100));
        }
    }

    class CurrentAccount : Account
    {
        public CurrentAccount(double amount) : base(amount) { }
        public override void CalculateInterest()
        {
            Console.WriteLine("Current Account Interest= " + (amount * 2 / 100));
        }
    }

    class T3_23
    {
        public static void T3_23Main()
        {
            SavingsAccount a = new SavingsAccount(10000);
            a.CalculateInterest();
            CurrentAccount b = new CurrentAccount(10000);
            b.CalculateInterest();
        }
    }
}