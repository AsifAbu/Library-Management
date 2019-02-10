using System;

namespace AccountClass
{
    public class Account
    {
        string accName, accId;
        double balance;

        public Account()
        {
        }
        public Account(string accName, string accId,double balance)
        {
            this.accName = accName;
            this.accId = accId;
            this.balance = balance;
        }
        public string Name
        {
            set { this.accName = value; }
            get { return accName; }
        }
        public string Id
        {
            set { this.accId = value; }
            get { return accId; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return balance; }
        }
        public void Deposit(double ammount)
        {
            this.balance += ammount;
        }
        public void Withdraw(double ammount)
        {
            if (balance >= ammount)
            {
                this.balance -= ammount;
                Console.WriteLine("Your ammount Is Updated. Your Current balance Is: " + balance);
            }
            else
            {
                Console.WriteLine("Your ammount Is Law. Your Current Balance Is: " + balance);
            }
        }
        public void Transfer(double ammount, Account receiver)
        {
            if (balance >= ammount)
            {
                receiver.Balance += ammount;
                this.Balance -= ammount;
                //Console.WriteLine("Your ammount Is Tranfared. Your Current balance Is: " + balance);
            }
            else
            {
                Console.WriteLine("Your ammount Is Law. Your Current Balance Is: " + balance);
            }
        }
        public void ShowAll()
        {
            Console.WriteLine("Account Id= " + accId);
            Console.WriteLine("Account Name= " + accName);
            Console.WriteLine("Balance Is= " + balance);
        }
    }
}
