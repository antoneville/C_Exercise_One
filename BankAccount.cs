using System;
using System.Collections.Generic;

namespace ExerciseOne
{
    public abstract class BankAccount
    {
        private String accountNumber;
        private double balance;

        public String AccountNumber
        {
            get { return accountNumber; }
        }

        public double Balance
        {
            get { return balance; }
            set { this.balance = value; }
        }

        public BankAccount(String accNumber)
        {
            this.accountNumber = accNumber;
            this.balance = 0;
        }

        public abstract void MakeDeposit();
        public abstract void MakeWithDrawals();
        public static void Main()
        {

            //BankAccount h2 = new BankAccount();
            //h2.Balance = 400.89;                      
            //Console.WriteLine(h2.Balance);        //Testing Set Property for Balance

            // BankAccount x2 = new BankAccount("AIB314666P");
            // Console.WriteLine(x2.accountNumber);
            // Console.WriteLine(x2.balance);       //Testing Constructor



        }
    }

    public class CurrentAccount : BankAccount
    {
        private double limit;
        private List<AccountTransaction> history;
        public double Limit
        {
            get { return limit; }
        }

        public CurrentAccount(double limit, string accNumber)
            : base(accNumber)
        {
            this.limit = limit;
            Balance = 0;
            history = new List<AccountTransaction>(50);
        }

        public override void MakeDeposit()
        {

        }
        public override void MakeWithDrawals()
        {
            if (limit < Balance)
            {
                Console.WriteLine("You have reached the limit of your Bank Account");
            }
            else
            {
                Console.WriteLine("New Balance: {0}", Balance);
                Console.WriteLine("Transaction Completed");
            }
        }

        public override string ToString()
        {
            return String.Format(" ");
        }
    }

    public enum TransactionType
    {
        Deposit, Withdrawal
    }

    // an account transaction
    public class AccountTransaction
    {
        private TransactionType type;       // deposit/withdrawal
        private double amount;          // amount concerned

        // constructor
        public AccountTransaction(TransactionType type, double amount)
        {
            this.type = type;
            this.amount = amount;
        }

        // return human readable String
        public override String ToString()
        {
            return "type: " + type + " amount: " + amount;
        }
    }


}
