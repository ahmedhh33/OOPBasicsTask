

namespace OOPBsicsTasks
{
    internal class BankAccount
    {
        public string AccountNumber;
        public string OwnertName;
        public double Balance;
        public double Amount;

        public BankAccount(string accountNumber, string ownertName,double balance)
        {
            this.AccountNumber = accountNumber;
            this.OwnertName = ownertName;
            this.Balance = balance;
            Amount = Disposit(50);
        }

        public double Disposit(double amount)
        {
            return  Balance +amount;
        }

        public double Withdraw(double amount ) 
        {
            if (amount> Balance)
            {
                return 0;
            }
            //Balance = Balance -amount;
            return Balance - amount; 
        }
    }
}
