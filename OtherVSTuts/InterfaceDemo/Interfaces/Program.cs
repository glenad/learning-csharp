using System;

namespace Interfaces
{
    public interface ITransactions
    {
        // interface members
        void ShowTransaction();
        double GetAmount();
    }

    public class Transaction : ITransactions
    {
        private string tCode;
        private string date;
        private double amount;

        public Transaction()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }

        public Transaction(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }

        public double GetAmount()
        {
            return amount;
        }

        public string MyMethod()
        {
            return "a string";
        }

        public void ShowTransaction()
        {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", GetAmount());
        }
    }

    class Tester
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
            Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);
            t1.ShowTransaction();
            t2.ShowTransaction();
            Console.ReadKey();
        }
    }
}
