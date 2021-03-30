using System;

namespace moneyPrinter
{
    public class BankAccount
    {
        private Client client { get; }
        private double balance { get; set; }

        public double CheckBalance()
        {
            return balance;
        }
        
        public void MakeDeposit(double amount)
        {
            balance += amount;
            Console.WriteLine("you deposit "+amount+" to your account. ");
        }
        public void MakeWithdrawal(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("You can't go under 0!");
                Console.WriteLine("Your new total is: " + balance);
            }else if (amount == balance)
            {
                Console.WriteLine("Are you sure you want to empty your account?");
                var answer = Console.ReadLine();
                if (answer == "yes")
                {
                    balance -= amount; 
                    Console.WriteLine("We're sorry to see you go");
                    
                }
            }
            else
            {
                balance -= amount;    
                Console.WriteLine("You withdraw " + amount + " from your account.");
            }
            
        }

        public BankAccount(Client _client, double initialBalance)
        {
            client = _client;
            balance = initialBalance;
        }
    }
}